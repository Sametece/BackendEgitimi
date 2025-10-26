using Microsoft.EntityFrameworkCore;
using OdevCozum.Data;
using OdevCozum.Entity;

namespace OdevCozum;

class Program
{
    static void Main(string[] args)
    {
        var context = new LibraryContext();  // LibraryContext veri tabanından nesne oluşturduk.

        Console.WriteLine("***** Welcome Ece Library *****");

        #region Yazarlar Ve Kitapları Dbye Aktarma.

        if (!context.Authors.Any()) // 📌 Eğer hiç yazar yoksa
        {
            var author1 = new Author()      // Yeni yazar oluştur
            {
                FullName = "Samet Ece",     // Yazar bilgilerini ver.Ama Id verme
                BirthYear = 2000,
                Books = new List<Book>         // Kitap listesinin içindeki propları bilgileri ver.Id verme
            {
                new Book {Title = "Aşk",PageCount=450},
                new Book {Title = "Suç",PageCount=550},
                new Book {Title = "Ceza",PageCount=400}

            }
                //Neden Id vermedik.Çünkü Otomatik olarak EfCore Bizim Yerimize Dbye Idleri vericek..:)
            };
            context.Authors.Add(author1); // verileri-> db içindeki -> Authors ve Books Tablosuna ekle.
            context.SaveChanges(); // Veritabanını (db) Kaydet. 
            Console.WriteLine("Yazar 1 ve Eserleri VeriTabanına eklendi...");


            var author2 = new Author()
            {
                FullName = "Selin Ece",
                BirthYear = 2005,
                Books = new List<Book>
            {
               new Book {Title = "Nefret", PageCount=700},
               new Book {Title = "Kin", PageCount=300},
               new Book {Title = "Neşe", PageCount=400},

            }
            };

            context.Authors.Add(author2);
            context.SaveChanges();
            Console.WriteLine("Yazar 2 ve Eserleri VeriTabanına eklendi...");

            var author3 = new Author()
            {
                FullName = "Naz Ece",
                BirthYear = 2028,
                Books = new List<Book>
            {
                  new Book {Title="Huzur", PageCount=160},
                  new Book {Title="Mutluluk", PageCount=180},
                  new Book {Title="Sevinç", PageCount=320}

            }
            };

            context.Authors.Add(author3);
            context.SaveChanges();
            Console.WriteLine("Yazar 3 ve Eserleri VeriTabanına eklendi...");
        }

        else
        {
            Console.WriteLine("⚠️ Yazarlar zaten mevcut, tekrar eklenmedi.");
        }

        #endregion

       #region Verileri Listeleme

        var booksWithAuthors = context.Books
                                      .Include(b => b.Author) //Join işlemi yaptık Author Bilgilerini Getirdik.
                                      .Select(b => new
                                      { 
                                          Title = b.Title,            // yeni tablodaki birleştirilme sonrasında Title Kolonu
                                          FullName = b.Author!.FullName  // yeni tablodaki birleştirilme sonrasında FullName kolonu
                                      })
                                      .ToList();  // Sorguları Listeye çevirdik

        foreach (var item in booksWithAuthors)
        {
            Console.WriteLine($"Kitap Ad: {item.Title} ---  Yazar: {item.FullName}");
        }
        #endregion

        #region Veri Güncelleme

        Console.Write("Lütfen Güncellemek İstediğiniz Kitabın Idsini Girin: ");
        int bookId = Convert.ToInt32(Console.ReadLine());

        var book = context.Books.FirstOrDefault(b => b.Id == bookId);

        if (book != null)
        {
            Console.Write($"Girilen Kitap: {book.Title} -- Mevcut Sayfa : {book.PageCount} Yeni Sayfa Numarası: ");
            int newPageCount = int.Parse(Console.ReadLine());

            book.PageCount = newPageCount;

            context.SaveChanges();
            Console.WriteLine("Kitap Sayfa Sayısı Başarılı ile Güncellendi");
        }
        else
        {
            Console.WriteLine("Bu Id'ye ait Bir Kitap Bulunamadı..");
        }
        
       #endregion
    }
}
