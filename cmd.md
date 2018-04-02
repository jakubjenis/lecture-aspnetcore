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

cd ..

dotnet sln add razor/razor.csproj
dotnet sln add emptyWeb/emptyWeb.csproj

```

