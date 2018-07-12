#r "paket: groupref build-deps //"
open Fake.IO
#load "./.fake/build.fsx/intellisense.fsx"
#if !FAKE
  #r "netstandard"
#endif

open System
open Fake.Core
open Fake.DotNet

type Build = {
    Version: string
    Publish: bool
}

type Config = {
    Main: Build
    ROP: Build
}

let config = {
    Main = {
        Version = "0.0.5"
        Publish = true
    }
    ROP = {
        Version = "0.0.2"
        Publish = true
    }
}

let globalTimeout = TimeSpan.FromMinutes 1.;

let runCommand execuatable command timeout  =
    let exitCode =
        Process.execSimple (fun info ->
        { info with
            FileName = execuatable
            Arguments = command
        }) (timeout)

    if exitCode <> 0 then failwithf "Look at error for command %s %s" execuatable command


let runMonoCommand timeout command  =
    runCommand "mono" command timeout

let runPaketCommand timeout paketCommand =
    sprintf ".paket/paket.exe %s" paketCommand |> runMonoCommand timeout

let buildDir = "./build"

let assertVersion inputStr =
    if Fake.Core.SemVer.isValid inputStr then
        ()
    else
        failwith "Value in version.yml must adhere to the SemanticVersion 2.0 Spec"

let inline withVersionArgs version options =
    assertVersion version
    options |> DotNet.Options.withCustomParams (Some (sprintf "/p:VersionPrefix=\"%s\"" version))


let nugetKeyVariable =
    "NUGET_KEY"

// *** Define Targets ***
Target.create "Clean" (fun _ ->
    let projects = [
        "./src/FluentAssertions.OneOf"
        "./src/FluentAssertions.OneOf.ROP"
        "./test/FluentAssertions.OneOf.Tests"
        "./test/FluentAssertions.OneOf.ROP.Tests"
    ]

    let allFoldersToClean =
        projects
        |> List.collect (fun project -> [ sprintf "%s/bin" project ; sprintf "%s/obj" project ])

    Shell.cleanDirs (buildDir :: allFoldersToClean)
)

Fake.Core.Target.create "Build" (fun _ ->
    DotNet.build (fun p ->
        { p with
            Configuration = DotNet.BuildConfiguration.Release;
        }) ""
)

Fake.Core.Target.create "Test" (fun _ ->
    let test project =
        DotNet.test (fun p ->
            { p with
                Configuration = DotNet.BuildConfiguration.Release;
                NoBuild = true
            }) project
    test "FluentAssertions.OneOf.Tests"
)

Fake.Core.Target.create "Package" (fun _ ->

    let packProject version projectPath =
        DotNet.pack (fun p ->
            { p with
                Configuration = DotNet.BuildConfiguration.Release
                OutputPath = Some "../build"
                NoBuild = true
            } |> withVersionArgs version) projectPath

    Directory.ensure buildDir
    packProject config.Main.Version "FluentAssertions.OneOf/FluentAssertions.OneOf.csproj"
    packProject config.ROP.Version "FluentAssertions.OneOf.ROP/FluentAssertions.OneOf.ROP.csproj"
)



Fake.Core.Target.create "Publish" (fun _ ->

    let publishPackage shouldPublish version project =
        if shouldPublish then
            sprintf "push build/%s.%s.nupkg" project version
                |> runPaketCommand globalTimeout
        else
            Trace.log (sprintf "Package upload skipped because %s was not set to be published" project )

    let publishBothPackages ()  =
        publishPackage config.Main.Publish config.Main.Version "FluentAssertions.OneOf"
        publishPackage config.ROP.Publish config.ROP.Version "FluentAssertions.OneOf.ROP"

    match Environment.environVarOrNone nugetKeyVariable with
    | Some _ -> publishBothPackages()
    | None -> Trace.log (sprintf "Package upload skipped because %s was not found" nugetKeyVariable)
)

// *** Define Dependencies ***
open Fake.Core.TargetOperators

"Clean"
    ==> "Build"

"Build"
    ==> "Package"
    ==> "Publish"

"Build"
    ==> "Test"
    ==> "Publish"

// *** Start Build ***
Fake.Core.Target.runOrDefault "Package"
