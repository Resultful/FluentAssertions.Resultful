dotnet tool install fake-cli -g --version=5.12.4
dotnet tool install paket -g --version=5.198.0
fake -v build  -t Publish
