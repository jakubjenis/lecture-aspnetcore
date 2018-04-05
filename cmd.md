# Script

```
dotnet new solution -n Lecture

mkdir emptyWeb
cd emptyWeb
dotnet new web

cd ..

mkdir razor
cd razor
dotnet new razor

-- dotnet new razor -au Individualcd ..

cd..

mkdir mvc
cd mvc
dotnet new mvc

cd ..

dotnet sln add razor/razor.csproj
dotnet sln add emptyWeb/emptyWeb.csproj

```