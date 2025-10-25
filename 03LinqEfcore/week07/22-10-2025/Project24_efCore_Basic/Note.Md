EF core ile çalışmak için yapılıcaklar :

1) sistem düzeyinde : Bir kez yüklenmesi gereken Ef tool yüklemesi yapılmalıdır. 
dotnet tool install --global dotnet-ef

dotnet ef

2) Proje Düzeyinde: Her Proje için yüklenmesi gereken Microsoft.EntityFramework.SqlServer yada Microsoft.EntityFramework.Sqllite yada Microsoft.EntityFramework.MySql

Her proje için eklemek : 
dotnet add package Microsoft.EntityFrameworkCore.Sqlite

Her proje için Kaldırmak: 
dotnet remove package Microsoft.EntityFrameworkCore.Sqlite

ayrıca EF Tool ile migration komutlarının clı içinde çalışabilmesi içinde  çalışabilmesi  dotnet add package Microsoft.EntityFrameworkCore.Design pkaetine ihtiyaç vardır. 



3) DbContext sınıfından miras alan bir sınıf yaratacağız. Bu sınıf veritabanı ile olan tüm ilişkilerimizi , oturumumuzu yönetecek/belirleyecek olan sınıf.

4) codefirst : Tasarıma koddan başlmak. Veritabanını kod ile yönetmek.

 Dbfirst : Önce veritabnını yaratmak, sonra koda onu ve yapısını aktarmak.

 Operasyonlarımız : 

 -Veritabanında Posts adında bir tabloya karşılık gelicek bir Post Sınıfı yarattık.

 -EFCore dan gelen DbContext'ten miras alan AppDbContext adlı sınıfı yarattık. Bu projemiz için EF Core'un Kalbi.

 -DbSet<Post> ile Post sınıfın veri tabanındaki tabloyu temsil edeceğini EF Core'a bildirdik.
 Kodumuzun ihtiyaç duyduğumuz noktalarında context.Posts gibi bir komut kullanarak direkt db içindeki Posts tablosu üzerinde işlem yapabiliyor olacağız.

 -OnConfiguring adlı metotu override ederek bunun içinde UseSqlite metodu ile veri tabanı bağlantı bilgimizi EF Core'a bildirdik.

 Migrations: Modelimizdeki(yani entity sınıflarımızdaki) her değişikliği bir geçis dosyası olarak kaydeder. Bu dosyalar , veri tabanının bir önceki durumdan yeni duruma nasıl geçiceğini anlatan c# kodları içerir. ve bir sonraki aşamaya bizi hazırlamış olur.

 dotnet ef migrations add InitialCreate     Bu kod Veritabanı tablosunu oluşturuyor

 dotnet ef database update // database açıyoruz ve güncelliyoruz

 Şimdilik: Mıgratoıns  klasörümüzde ki