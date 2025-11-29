1) dotnet ef migrations add InitialCreate -s ../ECommerce.API
2) dotnet ef database update -s ../ECommerce.API

Not: Artık katmanlı mimaride çalıştığımız için migration/database komutlarını Data katmanında vermemiz gerekiyor. Bu yüzden komutlarımızın her ikisinin de son kısmına -s (yani başlangıç projesi) parametresini ekleyerek başlangıç projemizin ECommerce.API olduğunu belirtiyoruz.

3) Paketler: 
    a) Microsoft.EntityFrameworkCore.Sqlite: Data katmanına
    b) Microsoft.EntityFrameworkCore.Design: API katmanına


## Unit Of Work
### Sipariş Oluşturma Senaryosu
    1. Orders tablosuna yeni bir sipariş ekleme(_orderRepository.AddAsync(...))
    2. Products tablosunda sipariş edilen ürünün adet kadar stoğunu güncelleme(_productRepository.Update(....))

- Unit Of Work: Yapılacak olan tüm veri tabanı değişikliklerini(ekleme, güncelleme, silme) tek bir transaction(işlem) altında toplamamızı sağlayan bir sınıftır.

    - Tüm Repository'lere tek bir noktadan erişim sağlar.
    - Tek bir SaveChanges noktası oluşacak.
    - Transactional Intergrity'i garanti eder.