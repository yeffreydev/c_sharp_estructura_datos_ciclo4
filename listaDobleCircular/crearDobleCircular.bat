dotnet new console --name "ConsoleApp"
dotnet new classlib --name "Clases"
dotnet new sln
dotnet sln add .\ConsoleApp\ConsoleApp.csproj
dotnet sln add .\Clases\Clases.csproj
cd ConsoleApp
dotnet add reference ..\Clases\Clases.csproj
dotnet run
