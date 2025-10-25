using Efcoreodev.Entity;
using Microsoft.EntityFrameworkCore;

namespace Efcoreodev;

class Program
{
    static void Main(string[] args)
    {
        var context = new LibraryContext();

        /* #region Yeni yazar oluşturma

         //1.Aşama

         Console.WriteLine("Yazar bilgisi oluturuluyor.....");
         Author author = new Author          // Yazar clasından yeni nesne üretip içerisine bilgilerini girdik
         {
             Id = 1,
             FirstName = "Samet ",
             LastName = "Ece",
             BirthYear = "2000"

         };


         context.Authors.Add(author); // Bu bilgileri yazar listesine ekle

         // 2.Aşama
         context.SaveChanges();                // veri tabanına kaydet.
         Console.WriteLine("Yeni yazar bilgisi oluşturuldu.....");
         Console.WriteLine($"Id: {author.Id}, Ad Soyad: {author.FirstName} - {author.LastName} Doğum Yılı : {author.BirthYear}  ");

         #endregion
 */

        /* #region Kitap oluşturma yazarla eşleştirme

         Console.WriteLine("Yeni Kitap oluşturluyor....");

         Book book = new Book
         {
             Id = 2,
             Title = "Deneme6",
             TotalPaper = 106,
             AuthorId = 2        // oluşturulucak bu kitap yazar ıd si 2 olanla bağlansın
         };

         context.Books.Add(book);

         context.SaveChanges();
         Console.WriteLine("Yeni kitap Eklendi.....");
         Console.WriteLine($"Kitap Id: {book.Id} Kitap Başlığı: {book.Title} Sayfa Sayısı: {book.TotalPaper}");


         #endregion
 */

        /* #region Yazarlarla kitapları oluşturma

         var author = new Author
         {
             Id = 4,
             FirstName = "Ece",
             LastName = "arslan",
             BirthYear = "2004",

             Books = new List<Book>    //kitap ekleme
             {
               new Book {Title =" Animal" , TotalPaper =325 },
               new Book {Title="Alice Harikalar Diyarında", TotalPaper=125}
             }

         };

         #endregion
         */



        /*   #region Tüm Kitapları Listele


            Console.WriteLine("Tüm Kitaplar");
            var books = context.Books.ToList();//select * from Authors
            foreach (var item  in books)
            {
                Console.WriteLine($"Id: {item.Id}, Başlık : {item.Title} Sayfa Sayısı: {item.TotalPaper}");
            }


           #endregion
   */


        /* #region 4.Soru Başlıklar ve yazar adları için join kullanıcaz

         var booksWithAuthors = context.Books
                                       .Include(b => b.Author)
                                        .Select(b => new
                                        {
                                            Title = b.Title,
                                            AuthorName = b.Author!.FirstName + b.Author.LastName
                                        })
                                        .ToList();

         Console.WriteLine("\n📚 Kitap Listesi:");
         foreach (var item in booksWithAuthors)
         {
             Console.WriteLine($"Kitap: {item.Title} | Yazar: {item.AuthorName}");
         }
         #endregion
 */

        /*  #region  5.Soru update işlemi

           var book = context.Books.FirstOrDefault(b => b.Title == "c# eğitim kitabı 1");
         if (book != null)
         {
             book.TotalPaper = 350; // yeni sayfa sayısı
             context.SaveChanges();
             Console.WriteLine($"✅ {book.Title} kitabının sayfa sayısı güncellendi: {book.TotalPaper}");
         }

          #endregion

     */




    }
}
