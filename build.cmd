dotnet tool install fake-cli -g --version=5.13.0
dotnet tool install paket -g --version=5.203.2
fake -v build  -t Publish
