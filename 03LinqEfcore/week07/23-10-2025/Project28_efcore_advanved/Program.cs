using Microsoft.EntityFrameworkCore;
using Project26_efCore_relationship_data.DTos;
using Project26_efCore_relationship_data.Entites;

namespace Project26_efCore_relationship_data;

class Program
{
    static void Main(string[] args)
    {

        #region Projection Yöntemi ile Sadece Gerekli veriyi çekmek
        // Postların Idleri ve başlıkları yazar bilgilerini içeren bir liste oluşturalım.

        // var context = new BlogDbContext();
        // var posts = context
        //             .Posts
        //             .Include(p => p.Author)
        //             .Select(p => new PostDto
        //             {
        //                 PostId = p.Id,
        //                 PostTitle = p.Title,
        //                 AuthorName = $"{p.Author!.FirstName} {p.Author.LastName}"
        //             })

        //             .ToList();
        // foreach (var post in posts)
        // {
        //     Console.WriteLine($"{post.PostId} - {post.PostTitle } - {post.AuthorName} ");
        // }

        #endregion

        #region Salt Okunur sorgular (Performans için)

        var context = new BlogDbContext();

        var posts = context.Posts
                            .AsNoTracking()//Ef core buradaki okunan verileri izlemeyecek ChangeTracker devre dışı bırakıldı
                           .Where(p => p.AuthorId == 1)
                           .ToList();
        posts[0].Title = "Değişen başlık";
        context.SaveChanges();// AsnoTracking ile çekilen post üzerinde hiçbir etkisi olmaz !
        Console.WriteLine(posts[0].Title);
        Console.WriteLine("AsnoTracking ile çekilen postlar üzerinde değişiklik yapılamaz.");

                 //Eğer bir sorgunun sonunda savechanges() çağırmayacaksınız, çağırma ihtimaliniz yoksa zincire AsnoTracking ekleyin. Daha hızlı olur uygulamamız.         
        #endregion
    }
}
