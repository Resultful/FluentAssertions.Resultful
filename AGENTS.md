# FLUENTASSERTIONS.RESULTFUL

## 🛑 Repository Conventions & Workflow Policy

1. **Squash Merge Only**: All pull requests must be merged using **Squash and Merge** exclusively.
2. **Delete Branch on Merge**: Feature branches must be automatically deleted immediately upon merge.
3. **Linear History**: Maintain a strictly linear history. Rebase feature branches before merging; no merge commits allowed.
4. **Direct Push Protection**: Non-force direct pushes to primary branches are blocked; PR mechanism required.
5. **Local Temp & Worktree Directory**: All temporary files, local databases, scratch files, and git worktrees MUST go inside the root `/temp/` directory (gitignored).
6. **Gitignored Local TODO File**: A root `TODO.md` file MUST exist for local task tracking and be gitignored.

## Development Commands

- Build solution: `~/.dotnet/dotnet build FluentAssertions.Resultful.sln`
- Run tests: `~/.dotnet/dotnet test FluentAssertions.Resultful.sln`
- Pack: `~/.dotnet/dotnet pack -c Release`
