using Microsoft.EntityFrameworkCore;
using Project24_efCore_Basic.Data;
using Project24_efCore_Basic.Models;

namespace Project24_efCore_Basic;

class Program
{
    static void Main(string[] args)
    {
        // Db ile ilgili tüm işlemle bu nesne ile yapılır.
        var context = new AppDbContext();


        // // Yeni Kayıt(Author) Oluşturma
        // // 1.Aşama
        // Console.WriteLine("Yazar bilgisi oluşturuluyor...");
        // Author author = new Author
        // {
        //     FirstName = "Merve2",
        //     LastName = "Kabakcı2"
        // };
        // context.Authors.Add(author);
        // // 2.Aşama
        // context.SaveChanges();
        // Console.WriteLine("Yeni yazar bilgisi oluşturuldu!!!");
        // Console.WriteLine($"Id: {author.Id}, Ad Soyad: {author.FirstName} {author.LastName}");

        // Yeni Kayıt(Post) Oluşturma
        // 1.Aşama
        // Console.WriteLine("Yeni post oluşturuluyor...");
        // Post post = new Post
        // {
        //     Title = "Post 2123",
        //     Content = "Content 2123",
        //     PublishedOn= new DateTime(2025,10,22)
        //     PublishedOn = DateTime.UtcNow,
        //     AuthorId = 2
        // };
        // context.Posts.Add(post);
        // 2.Aşama
        // context.SaveChanges();
        // Console.WriteLine("Yeni post oluşturuldu!");
        // Console.WriteLine($"Id: {post.Id}, Title:{post.Title}, Author:{post.AuthorId}");

        // Tüm yazarları listelemek
        // Console.WriteLine("Tüm Yazarlar");
        // var authors = context.Authors.ToList();//select * from Authors
        // foreach (var author in authors)
        // {
        //     Console.WriteLine($"{author.Id}, {author.FirstName} {author.LastName}");
        // }

        // // Id'si 1 olan postu görüntüle
        // Console.WriteLine("Id'si 1 olan post");
        // var post = context
        //     .Posts
        //     .Where(p => p.Id == 1)
        //     .FirstOrDefault();
        // Console.WriteLine($"{post!.Id}, {post.Title}, {post.Content}, {post.AuthorId}");

        // Id'si 1 olan postu yazar bilgisiyle görüntüle
        // Console.WriteLine("Id'si 1 olan post");
        // var post = context
        //     .Posts
        //     .Where(p => p.Id == 1)
        //     .Include(p => p.Author)
        //     .FirstOrDefault();

        // Console.WriteLine($"{post!.Id}, {post.Title}, {post.Content}, {post.Author!.FirstName}");

        // Tüm postları, yazar ad soyad bilgileriyle birlikte listele
        // var posts = context
        //     .Posts
        //     .Include(p => p.Author)
        //     .ToList();
        // foreach (var post in posts)
        // {
        //     Console.WriteLine($"{post.Id} - {post.Title} - {post.Content} - {post.PublishedOn} - {post.Author!.FirstName} {post.Author.LastName}");
        // }


        // Id'si 1 olan Author'u güncelleyelim
        // - Güncellenecek olan nesneyi veritabanından oku/bul(Id'si 1 olan Author)
        // - Bu nesnenin ihtiyaç duyulan property güncellemelerini yap
        // - SaveChanges() yap.
        // var updatedAuthor = context
        //     .Authors
        //     .Where(a => a.Id == 1)
        //     .FirstOrDefault();
        // if (updatedAuthor != null)
        // {
        //     // Console.WriteLine($"Eski Ad: {updatedAuthor.FirstName}");
        //     // updatedAuthor.FirstName = "Ceyda";
        //     updatedAuthor.LastName = "Kabakcı";
        //     context.SaveChanges();
        //     Console.WriteLine($"Yeni Ad: {updatedAuthor.FirstName}");
        // }
        // else
        // {
        //     Console.WriteLine("İlgili yazar bulunamadı!");
        // }

        // Id'si 1 olan Author'u silelim
        // - Silinecek nesneyi veri tabanından oku/bul(Id'si 1 olan Author)
        // - DbSet üzerinden Remove() metoduna bu nesneyi ver
        // - SaveChanges() yap
        var deletedAuthor = context
            .Authors
            .Where(a => a.Id == 1)
            .FirstOrDefault();
        if (deletedAuthor != null)
        {
            context.Authors.Remove(deletedAuthor);
            context.SaveChanges();
            Console.WriteLine("Kayıt başarıyla silindi...");
        }
        else
        {
            Console.WriteLine("Silinmek istenen kayıt bulunamadı!");
        }


    }
}
