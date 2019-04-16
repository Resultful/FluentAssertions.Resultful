#!/usr/bin/env bash
dotnet tool install fake-cli -g --version=5.13.0
dotnet tool install paket -g --version=5.203.2
export PATH="$HOME/.dotnet/tools:$PATH"
fake -v build  -t Publish
