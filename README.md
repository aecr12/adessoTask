# Adesso World League

Grupları takımlara belirtilen şartlara göre dağıtarak fikstür sağlayan bir api uygulaması.
Asp.Net 6.0 ve entity framework - postgresql kullanılmıştır.

## Kurulum

1)
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Npgsql.EntityFrameworkCore.PostgreSQL
Microsoft.EntityFrameworkCore.Tools, paketleri kurulu olmalıdır.
Nuget paket yöneticisinden kurulabilir veya proje dizininde aşağıdaki komutlar çalıştırılır

dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Microsoft.EntityFrameworkCore.Tools

2) AppSettings.json üzerinde veritabanı bağlantısı için connection string bulunuyor, projenin kurulumu yapılırken locale göre değiştirilebilir.

## Kullanım

Öncelikle "dotnet ef migrations add '_?aciklama?-'" komutu ile migration alınır ve ardından "dotnet ef database update" komutu ile veritabanı güncellenir.
Proje çalıştığında swagger üzerinde belirtilen kaynağa gidilerek, grup sayısı - isim - soyisim ile kaynağa (https://localhost::port?/api/FixtureDraw/Draw) istek atılır. Proje dökümanında verilen referans datalar oluşturulmamışsa, kaynağa istek atıldığında databasede yok ise oluşturulacak şekilde kodlanmıştır.

## Belirlediğim Buglar
Group tablsunda istek atan kişinin ve takımın bilgileri yazmıyor, DTO'dan Entity'e maplerken bu iki niteliğin fonksiyona verilmediği fark edildi.
8 gruba 4 takım dağıtıldğı durumda yanlış bir mantık izlendi.
