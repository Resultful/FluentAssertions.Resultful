# RESULTFUL.AWESOMEASSERTIONS

## 🛑 Repository Conventions & Workflow Policy

1. **Squash Merge Only**: All pull requests must be merged using **Squash and Merge** exclusively.
2. **Delete Branch on Merge**: Feature branches must be automatically deleted immediately upon merge.
3. **Linear History**: Maintain a strictly linear history. Rebase feature branches before merging; no merge commits allowed.
4. **Direct Push Protection**: Non-force direct pushes to primary branches are blocked; PR mechanism required.
5. **Local Temp & Worktree Directory**: All temporary files, local databases, scratch files, and git worktrees MUST go inside the root `/temp/` directory (gitignored).
6. **Gitignored Local TODO File**: A root `TODO.md` file MUST exist for local task tracking and be gitignored.

## Development Commands

- Build solution: `~/.dotnet/dotnet build Resultful.AwesomeAssertions.slnx`
- Run tests: `~/.dotnet/dotnet test Resultful.AwesomeAssertions.slnx`
- Pack: `~/.dotnet/dotnet pack -c Release`
- Regenerate the OneOf files after changing `eng/GenerateOneOf.cs`: `dotnet run eng/GenerateOneOf.cs`
  (CI runs it with `-- --check`). Never edit the generated `OneOfAssertions.cs` / `AssertionExtensions.Should.cs`.

## Two flavors from one source

- `src/` and `tests/` are the AwesomeAssertions flavor: packages `Resultful.AwesomeAssertions*`.
- `legacy/` holds project files only. They compile the same sources against FluentAssertions 7.x (Apache-2.0) as the
  original `FluentAssertions.*` packages and namespaces. Never add source under `legacy/`.
- The flavor is chosen in `Directory.Build.props`; `FLUENTASSERTIONS` is defined for the legacy build.
- Library code uses `#if FLUENTASSERTIONS` only for the namespace line and inside `AssertionStart`. Assertion-library
  namespaces come from global usings in `Directory.Build.targets`; this repo's own namespaces are referenced with
  relative `using`s inside the namespace block (`using Union.Models;`), which resolve in both flavors.
- Test sources are flavor-neutral (`Resultful.AssertionTests.*`); each test project supplies the namespaces.
- Keep the legacy flavor on FluentAssertions 7.x: 8.0 and later need a commercial licence.
