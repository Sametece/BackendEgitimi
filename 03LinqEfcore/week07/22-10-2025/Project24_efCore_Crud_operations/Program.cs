using Microsoft.EntityFrameworkCore;
using Project24_efCore_Basic.Data;
using Project24_efCore_Basic.Models;

namespace Project24_efCore_Basic;

class Program
{
    static void Main(string[] args)
    {
        // Db ile ilgili tüm işlemle bu nesne ile yapılır.
        // var context = new AppDbContext();

        // // Yeni kayıt oluşturma
        // //1.Aşama

    //      Console.WriteLine("Yazar bilgisi oluturuluyor.");
    //      Author author = new Author
    //      {
    //          FirstName = "Samet2",
    //         LastName = "Ece2"
    //     };
    //    context.Authors.Add(author);

        // //2.Aşama
       // context.SaveChanges();
        // Console.WriteLine("yeni yazar bilgisi oluşturuldu.");
        // Console.WriteLine($"Id: {author.Id}, Ad Soyad: {author.FirstName} {author.LastName} ");
        //--------------------------------------------------------------
        //Yeni kayıt(Post) oluşturma
        //1.Aşama

        // Console.WriteLine("yeni post oluşturuluyor..");
        // Post post = new Post
        // {
        //     Title = "Post 123",
        //     Content = "Content 123",
        //     PublishedOn = DateTime.UtcNow ,//new DateTime(2025,10,22)
        //     AuthorId = 4
        // };
        // context.Posts.Add(post);
        // //2.aşama
        // Console.WriteLine("Yeni post oluşturuldu.");
        // Console.WriteLine($"Id: {post.Id} Title: {post.Title}, Author: {post.AuthorId}");

        // Tüm Yazarları Listelemek
        // Console.WriteLine("Tüm yazarlar");

        // var authors = context.Authors.ToList();//Select * from Authors anlamına gelir.
        // foreach (var author in authors)
        // {
        //     Console.WriteLine($"{author.Id} {author.FirstName} {author.LastName}");
        // }

        // Idsi 1 olan Postu Listele

        // Console.WriteLine("Id'si 1 olan postu görüntüle ");

        // var post = context
        //            .Posts
        //            .Where(p => p.Id == 1)
        //            .FirstOrDefault();

        // Console.WriteLine($"{post!.Id} {post.Title} {post.Content} {post.AuthorId}");

        // Idsi 1 olan Postu yazar bilgisiyle görüntüle 


        // Console.WriteLine("Id'si 1 olan postu görüntüle ");

        // var post = context
        //            .Posts
        //            .Where(p => p.Id == 1)
        //            .Include(p=>p.Author)
        //            .FirstOrDefault();

        // Console.WriteLine($"{post!.Id} {post.Title} {post.Content} {post.Author!.FirstName}");

        //Tüm postları yazar ad soyad bilgileriyle listele.

        // var posts = context
        //             .Posts
        //             .Include(p =>p.Author)
        //             .ToList();
        //         foreach (var post in posts)
        //         {
        //     Console.WriteLine($"{post.Id} {post.Title} {post.Content} {post.PublishedOn}{post.Author.FirstName} {post.Author.LastName}");
        //         }


       


    }
}
