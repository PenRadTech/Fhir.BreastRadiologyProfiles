# dotnet nuget add source https://api.nuget.org/v3/index.json -n nuget.org


dotnet nuget locals all --clear

dotnet tool uninstall --global Eir.AutoMate
dotnet tool uninstall --global Eir.MFSH
dotnet tool uninstall --global Eir.FGraph
dotnet tool uninstall --global Eir.IGBuilder

dotnet tool install --global Eir.AutoMate
dotnet tool install --global Eir.MFSH
dotnet tool install --global Eir.FGraph
dotnet tool install --global Eir.IGBuilder

pause