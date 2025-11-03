using soru4.Data;
using soru4.Data.Concrete.EFCore;
using soru4.Data.Concrete.interfaces;
using soru4.Entity;

namespace soru4;

class Program
{
    static void Main(string[] args)

    {

        var context = new MovieContext();

        ICategoryRepository categoryRepository = new CategoryRepository(context);
        IMovieRepository movieRepository = new MovieRepository(context);

        #region Veri Ekleme Operasyonu
         
        var category1 = new Category
        {
            Name = "Komedi",
            Movies = new List<Movie>
           {
               new Movie { Title="Recep ivedik", Director="Togan", ReleaseYear=2000},
               new Movie { Title="Recep ivedik 2", Director="Togan", ReleaseYear=2001},
               new Movie { Title="Recep ivedik 3", Director="Togan", ReleaseYear=2003}

           }
        };

        categoryRepository.Add(category1);
        Console.WriteLine("Komedi Türündeki Filmler Veritabanını Başarıyla Yüklenmiştir.");

        var category2 = new Category
        {
            Name = "Çizgi Filmler",
            Movies = new List<Movie>
            {
                new Movie {Title="Kral Şakir",Director="CNetwork",ReleaseYear=2010},
                new Movie {Title="Kral Şakir 2",Director="CNetwork",ReleaseYear=2011},
                new Movie {Title="Kral Şakir 3",Director="CNetwork",ReleaseYear=2012}

            }
        };

        categoryRepository.Add(category2);
        Console.WriteLine("Çizgi Fimler Veritabanını Başarıyla Yüklenmiştir.");

        var category3 = new Category
        {
            Name = "Aksiyon",
           Movies = new List<Movie>
           {
               new Movie {Title="Hızlı ve öfkeli",Director="abc",ReleaseYear=2005},
               new Movie {Title="Hızlı ve öfkeli 2",Director="abc",ReleaseYear=2006},
               new Movie {Title="Hızlı ve öfkeli 3",Director="abc",ReleaseYear=2007}

           }
        };
        categoryRepository.Add(category3);
        Console.WriteLine("Aksiyon Türündeki Filmler Veritabanına Başarıyla Eklenmiştir. ");
        #endregion

        #region Dto Sorgulama

        int istenilenmovieId = 1;

        var movie = movieRepository.GetAllMovieDetails();
        Console.WriteLine($"İstenilen Film {istenilenmovieId} Bilgileri : ");

        foreach (var x in movie)
        {
            Console.WriteLine($"Film Adı : {x.Title}, Filmin Yapımcısı: {x.Director}");
        }

        #endregion

        #region Veri Silme 

        int movieIdDelete = 2;

        var movie1 = movieRepository.GetById(movieIdDelete);

        if (movie1 != null)
        {
            movieRepository.Delete(movieIdDelete);
            Console.WriteLine("İstenilen Film Id 'si 2 olan silinmiştir. ");
        }
        else
        {
            Console.WriteLine("Bu idye ait film bulunamamıştır.");
        }
            
        #endregion
        
    }
}
