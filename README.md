# .NET Core project template
---
This is a template for .NET Core CLI `dotnet new`. It creates a solution in which contains a console or library project as well as a separated unit test project.

## Installation
---
To install the template, open a command prompt and type:
```
$ dotnet new -i com.zhusmelb.Template.Project
```
To uninstall the template, type:
```
$ dotnet new -u com.zhusmelb.Template.Porject
```
## Usage
---
To create a new project with unit test:
```
$ mkdir MyProj && cd MyProj
$ dotnet new yzproj
```
Another way to create a project with unit test is:
```
$ dotnet new yzproj -n MyProj -o MyProj
```
This template supports creating both Exe or Library project, use `-P|--ProjectType' paramter to specify which type of project to create. You can sepcify either "Exe" or "Library" as argument.
```
$ dotnet new yzproj -n MyProj -o MyProj -P [Exe|Library]
```
This template includes an unit test project use NUnit 3.0 by default. If you don't want the test project, use the following:
```
$ dotnet new yzproj -n MyProj -o MyProj -T false
```
