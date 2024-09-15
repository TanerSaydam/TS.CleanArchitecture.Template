# Clean Architecture

Clean Architecture starter project for ASP.NET Core. [Clean Architecture](https://8thlight.com/blog/uncle-bob/2012/08/13/the-clean-architecture.html) is the latest in a series of architectures aiming towards a loosely-coupled, dependency-inverted architecture. You may also hear it referred to as [Hexagonal](http://alistair.cockburn.us/Hexagonal+architecture), [ports-and-adapters](http://www.dossier-andreas.net/software_architecture/ports_and_adapters.html), or [onion architecture](http://jeffreypalermo.com/blog/the-onion-architecture-part-1/). ASP.NET Core için Clean Architecture başlangıç projesi.  loosely-coupled, dependency-inverted architecture mimarisine yönelik bir dizi mimarinin sonuncusu.  diye de adlandırıldığını duyabilirsiniz.

## Table Of Contents

- [Clean Architecture](#clean-architecture)    
  - [Give a start! :star:](#give-a-star-star)
  - [Versions](#versions)
  - [Getting Started](#getting-started)
  - [Libraries Used in the Project](#libraries-used-in-the-project)

## Give a start! :star:
If you are using or like this project, you can support it by giving a star. Thank you!

## Versions
The project currently uses .NET version 8. There is no support for older versions.

# Getting Started
This project has been published as a template via a NuGet package. After installing, it will appear in your project list in the "Create New Project" section of VS2022.

To install, you can visit [NuGet (https://www.nuget.org/packages/TS.CleanArchitecture)](https://www.nuget.org/packages/TS.CleanArchitecture/)

Or you can install it by running the following code block:

```powershell
dotnet new install TS.CleanArchitecture
```

After the installation is complete, you can view the VS2022 project list with `dotnet new list` and search for the project template "ASP.NET Clean Architecture Solution" with the short name "ts.cleanarchitecture". If you find it in the list, you can now create a new project via VS2022 and find it by searching for "Clean Architecture" in the project search bar.

![Proje Template](https://github.com/TanerSaydam/CleanArchitecture.Template/blob/main/images/projeyibulma.png)

After selecting the project, give it any name you want, for example `eCommerce`

![Proje Structure](https://github.com/TanerSaydam/CleanArchitecture.Template/blob/main/images/projestructure.png)

## Libraries Used in the Project
- **EntityFrameworkCore**
- **EntityFrameworkCore.Identity**
- **MediatR**
- **AutoMapper**
- **FluentValidation**
- **TS.Result**
- **TS.EntityFrameworkCore.GenericRepository**

The project is initially configured with MSSQL. If you want to continue with MSSQL, adjust the ConnectionStrings section in the `appsetting.json` file according to your settings.

![Connection String](https://github.com/TanerSaydam/CleanArchitecture.Template/blob/main/images/connectionstring.png)

If you want to change the database, you need to change the installed NuGet package in the Infrastructure layer and modify the connection information.

The `Login` method and `User` class are present in the project. When the project runs, it automatically creates an admin user.

![Create First User](https://github.com/TanerSaydam/CleanArchitecture.Template/blob/main/images/createfirstuser.png)