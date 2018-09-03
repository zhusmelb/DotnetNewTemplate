# .NET Core project template
---
This is a template for .NET Core CLI `dotnet new`. It creates a solution in which contains a console or library project as well as a separated unit test project.

## Installation
---
To install the template, open a command prompt and type:
```
$ dotnet new -i com.zhusmelb.Template.Library
```
To uninstall the template, type:
```
$ dotnet new -u com.zhusmelb.Template.Library
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