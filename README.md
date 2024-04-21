# Clean Architecture

ASP.NET Core için Clean Architecture başlangıç projesi. [Clean Architecture](https://8thlight.com/blog/uncle-bob/2012/08/13/the-clean-architecture.html) loosely-coupled, dependency-inverted architecture mimarisine yönelik bir dizi mimarinin sonuncusu. [Hexagonal](http://alistair.cockburn.us/Hexagonal+architecture), [ports-and-adapters](http://www.dossier-andreas.net/software_architecture/ports_and_adapters.html), or [onion architecture](http://jeffreypalermo.com/blog/the-onion-architecture-part-1/) diye de adlandırıldığını duyabilirsiniz.

## Table Of Contents

- [Clean Architecture](#clean-architecture)  
  - [Table of contents](#table-of-contents)
  - [Give a start! :star:](#give-a-star-star)
  - [Versions](#versions)
  - [Getting Started](#getting-started)

## Give a start! :star:
Eğer bu projeyi kullanıyor ya da beğendiyseniz yıldız vererek destek olabilirsiniz. Teşekkürler!

## Versions

Proje şu anda .NET 8 versiyonunu kullanıyor. Eski versiyonlarda desteği yok.

# Getting Started

Bu proje bir template olarak NuGet package üzerinden yayımlandı. Kurduktan sonra VS2022 de yeni proje oluştur sekmenizde proje listenizde yer alacaktır.

Kurmak için [NuGet (https://www.nuget.org/packages/TS.CleanArchitecture)](https://www.nuget.org/packages/TS.CleanArchitecture/) burayı ziyaret edebilirsiniz

Ya da aşağıdaki kod bloğunu çalıştırarak kurabilirsiniz

```powershell
dotnet new install TS.CleanArchitecture
```

kurulum bittikten sonra `dotnet new list` ile VS2022 proje listesini görüntüleyip "ASP.NET Clean Architecture Solution" kısa adı "ts.cleanarchitecture" proje template'ini arayabilirsiniz. Eğer listede bulduysanız artık VS2022 üzerinden yeni proje oluştur deyip proje arama çubuğunda "Clean Architecture" diye arayarak bulabilirsiniz.

![Proje Template](https://github.com/TanerSaydam/CleanArchitecture.Template/blob/main/images/projeyibulma.png)

Projeyi seçtikten sonra istediğiniz ismi verin örneğin `eCommerce`

![Proje Structure](https://github.com/TanerSaydam/CleanArchitecture.Template/blob/main/images/projestructure.png)

## Projede kullanılan kütüphaneler
- **EntityFrameworkCore**
- **EntityFrameworkCore.Identity**
- **MediatR**
- **AutoMapper**
- **FluentValidation**
- **TS.Result**
- **TS.EntityFrameworkCore.GenericRepository**

Proje başlangıçta MSSQL ile ayarlandı. MSSQL ile devam etmek istiyorsanız `appsetting.json` dosyasında ConnectionStrings kısmını kendinize göre düzenleyin

![Connection String](https://github.com/TanerSaydam/CleanArchitecture.Template/blob/main/images/connectionstring.png)

Eğer Database değiştirmek istiyorsanız kurulu NuGet package'ini Infrastructure katmanında değiştirip connection bilgisini değiştirmelisiniz.

Login metodu ve User classı projede mevcut.
Proje çalıştığında otomatik bir admin kullanıcısı oluşturur

![Create First User](https://github.com/TanerSaydam/CleanArchitecture.Template/blob/main/images/createfirstuser.png)



