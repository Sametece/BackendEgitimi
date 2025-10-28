using FilmveKategoriSistemi.Data;
using FilmveKategoriSistemi.Entity;
using Microsoft.EntityFrameworkCore;

namespace FilmveKategoriSistemi;

class Program
{
    static void Main(string[] args)
    {
        var context = new MovieContext();

        #region 3 Kategori oluştur ve her katoriye ait 2 film Ekle

        if (!context.Categories.Any()) // eğer Categories Listesinde komedi türü yoksa 
        {
            var category1 = new Category
            {
                CategoryName = "Komedi",
                Movies = new List<Movie>
        {
            new Movie { Title = "Recep İvedik", Director = "Recep", Year = 2010 },
            new Movie { Title = "Recep İvedik 2", Director = "Recep", Year = 2011 }
        }
            };

            context.Categories.Add(category1);
            context.SaveChanges();

            Console.WriteLine("Komedi türündeki filmler eklendi.");


            var category2 = new Category
            {
                CategoryName = "Korku",
                Movies = new List<Movie>
                {
                    new Movie {Title="Çığlık 1",Director="Yabancı",Year=2005},
                    new Movie {Title="Çığlık 2",Director="Yabancı",Year=2006},

                }
            };

            context.Categories.Add(category2);
            context.SaveChanges();
            Console.WriteLine("Korku türündeki Filmle Dbye Kaydedilmiştir.");

            var category3 = new Category
            {
                CategoryName = "Aksiyon",
                Movies = new List<Movie>
            {
                new Movie {Title="Taşıyıcı",Director="asdfggh",Year=2004},
                new Movie {Title="Taşıyıcı2",Director="asdfggh",Year=2008}

            }
            };
            context.Categories.Add(category3);
            context.SaveChanges();
            Console.WriteLine("Aksiyon Türündeki Filmler Dbye Kaydedildi.");

        }
        else
        {
            Console.WriteLine("Bu tür Film Veritabanımızda Zaten Mevcut ");
        }

        #endregion

        #region Veri Listeleme (Projeksiyon): 

        var result = context.Movies
                            .Include(m => m.Category)
                            .Select(m => new
                            {
                                Title = m.Title,
                                Direkctor = m.Director,
                                CategoryName = m.Category.CategoryName
                            })
                            .ToList();
        foreach (var x in result)
        {
            Console.WriteLine($"Kategori : {x.CategoryName} Film: {x.Title} Dikretör: {x.Direkctor}");
        }

        #endregion

        #region Veri Silme

        Console.WriteLine("Lütfen Silmek İstediğiniz Veri Kategorisini girin:(Komedi/Korku/Aksiyon)");
        string filmAd = Console.ReadLine();

        //  Filmi Adına göre  bul
        var MovieTitle = context.Movies.FirstOrDefault(m => m.Title == filmAd);

        if (MovieTitle != null)
        {
            context.Movies.Remove(MovieTitle);

            context.SaveChanges();
            Console.WriteLine($"{MovieTitle.Title} adlı Film Ve kategorisi veritabanından silinmiştir.");
        }
        else
        {
            Console.WriteLine("Böyle Bir Film Bulunamamıştır.");
        }

        #endregion
    }
}
