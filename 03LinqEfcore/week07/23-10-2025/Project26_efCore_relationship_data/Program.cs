using Microsoft.EntityFrameworkCore;
using Project26_efCore_relationship_data.Entites;

namespace Project26_efCore_relationship_data;

class Program
{
    static void Main(string[] args)
    {
        #region Seed Data İşlemleri 

        Console.WriteLine("Örnek Veriler yüklenmeye Başlandı");
        var seedData = new SeedData();
        seedData.CreateAuthors();
        Console.WriteLine("Yazarlar Oluşturuldu.");
        seedData.CreatePosts();
        Console.WriteLine("Postlar oluşturuldu");
        Console.WriteLine("SeedData işlemleri tamamladı.");
        #endregion

        // Ef Core da ilişkili verileri yüklemenin temel olarak üç yolu vardır 
        // Idsi 3 olan yazarın(Authorun verilerini postlarıyla birlikte ) çekmek

        #region Eager Loading()
        // ana nesneyi sorgulurken, ilişkili verilerin de tek bir sorguda getirilmesini sağlar. En yaygın, verimli yöntemdir.
        //Include, ThenInclude 

        var context = new BlogDbContext();
        var authors = context
                     .Authors
                     .Include(a => a.Posts)
                     .ToList();
        if (authors.Any()) // Eğer authors koleksiyonunu eleman sayısı 1 ya da dafa fazla ise ture, 0 ise false döndür
        {

            foreach (var author in authors)
            {
                Console.WriteLine($"{author.FirstName} {author.LastName}");
                if (author.Posts.Any())
                {
                    foreach (var post in author.Posts)
                    {
                        Console.WriteLine($" --- {post.Title}");
                    }
                }
            }
        }
        #endregion
        
        #region Lazy Loading 
        // İlişkili verilere, onlara ilk kez erişilmeye çalışıldığı  anda ayrı bir sorgu ile otomatik olarak yüklenmesine denir.
        // Bu n+1 problemine yol açar. Bi bakılıcak..
            
        #endregion

        #region Explicit Loading 
        // Ana nesneyi yükledikten sonra istenilen herhangi bir zamanda ilişkili verileri ayrı bir sorgu ile manuel olarak yüklenmesine denir .
            
        #endregion

        
    }
}
