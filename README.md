# lecture-aspnetcore

first change

https://www.microsoft.com/net/download/windows

dotnet --version
dotnet --info

## DOCS

<https://docs.microsoft.com/en-us/aspnet/core/>

## History

### ASP

* Part of IIS (v3.0 - v5.0; ASP 1.0 - ASP 3.0)
* HTML markup and your code together in the same file. 
* Similar to PHP

### ASP.NET

* Bundled with .NET Framework

#### WebForms

* ASP.NET 1.0 2002
* Rapid development using a rich library of controls that encapsulate HTML markup
* Similar to WinForms, WPF

#### MVC

* ASP.NET MVC 1 2009 - ASP.NET MVC 6 2015
* Full control over HTML markup, code and markup separated, and easy to write tests. The best choice for mobile and single-page applications (SPA).
* Inspired by Ruby on Rails

### ASP.NET Core

* ASP.NET Core is a redesign of ASP.NET 4.x, with architectural changes that result in a leaner, more modular framework.

[Richard Campbell - History of .net](https://www.youtube.com/watch?v=trHTLFNFoWk&index=2&list=PLhXtQ8wzJ0uEDyBeqHIHxE6cwD6Ux5oeB&t=0s)

## Main characteristics

* easy client side framework integration
  * gulp, grunt, npm, bower, bootstrap, LESS, typescript
  * SPA templates for REACT, Angular
* environment based configuration system 
  * <https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/index?tabs=basicconfiguration>
* ships as nuget packages
  * since 2.0 - single metapackage Microsoft.AspNetCore.All
  * <https://docs.microsoft.com/en-us/aspnet/core/fundamentals/metapackage>
* lightweight HTTP request pipeline
* high performance
  * Over 2 million plaintext requests (without MVC)
  * <https://github.com/aspnet/benchmarks>
  * <https://www.techempower.com/benchmarks/#section=data-r15&hw=ph&test=plaintext>
* multiple hosting options
  * IIS, Nginx, Apache, Docker, self hosted
* target .NET Core or Full framework option
  * ASP.NET as netstandard 2.0 libraries can run anywhere netstandard 2.0 runs
  * .NET framework - windows only
  * .NET Core - 
    * metapackages
    * precompilation
    * smaller application size
    * CLI tooling
    * IDE independent
* run on Windows, Linux or masOS
* open source
  * <https://github.com/aspnet>
* community focused
  * <https://live.asp.net/>

## .NET Core

<https://docs.microsoft.com/en-us/dotnet/core/>

* Netstandard
  * <https://docs.microsoft.com/en-us/dotnet/standard/net-standard>
  * [.NET Standard Video series](https://www.youtube.com/watch?v=HyfDG4mjBPk&feature=youtu.be&list=PLRAdsfhKI4OWx321A_pr-7HhRNk7wOLLY)

* target framework monikers
* runtime

* compat shim for nugets targetting .NET Framework

### Workloads

* Console apps
* ASP.NET Core
* UWP

[Awesome .NET Core](https://github.com/thangchung/awesome-dotnet-core)

## Alternatives

* Nancy
  * simple way to build WebAPIs
  * <http://nancyfx.org/>

* Giraffe
  * F# middleware on top of ASP.NET Core
  * <https://github.com/giraffe-fsharp/Giraffe>

## Tooling

* Visual Studio 2017
* VS Code
* NET CLI
* Omnisharp
* Rider

## C# Prerequisities

* async / await
* lambdas
* LINQ

## ASP.NET Core MVC

* Program.cs
  * UseStartup

* Startup.cs
  * injected IConfiguration, IHostingEnvironment, IApplicationBuilder from  IApplicationBuilder.ApplicationServices
  * ConfigureServices
    * Adding services to the service container makes them available within the app
    * **Add** convention
  * Configure
    * Specify how the app responds to HTTP requests by adding middleware components to IApplicationBuilder
    * **Use** convention

* Dependency injection
  * TODO

* Middleware _(out of scope)_
  * Routing
  * Compression
  * Response caching
  * Authentication
  * URL rewriting
  * Session
  * Web sockets

* Static files _(out of scope_
  * TODO Investigate

* Routing basics
  * TODO

* Environments
  * default - Development, Staging, Production
  * env.IsDevelopment(), env.IsStaging(), env.IsProduction(), env.IsEnvironment("envName")
  * ASPNETCORE_ENVIRONMENT
  * Appsettings.Development.json, Appsettings.Production.json

* Error handling
* Logging

* Data access
  * localdb - (localdb)\\mssqllocaldb, C:\Users\<user>\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\LocalDBApp1\.
  * ```dotnet ef database update```

