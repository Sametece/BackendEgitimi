1) dotnet ef migrations add InitialCreate -s ../ECommerce.API
2) dotnet ef database update -s ../ECommerce.API

Not: Artık katmanlı mimaride çalıştığımız için migration/database komutlarını Data katmanında vermemiz gerekiyor. Bu yüzden komutlarımızın her ikisinin de son kısmına -s (yani başlangıç projesi) parametresini ekleyerek başlangıç projemizin ECommerce.API olduğunu belirtiyoruz.

3) Paketler: 
    a) Microsoft.EntityFrameworkCore.Sqlite: Data katmanına
    b) Microsoft.EntityFrameworkCore.Design: API katmanına