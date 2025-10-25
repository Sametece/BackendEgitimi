namespace Project19_Constructor_Static;

class Program
{       //Nesne Oluşturulken çalışmasıını isrtediiğmiz kodlar oldugu zaman kullanılırız.//ctor
    static void Main(string[] args)
    {

        Islemci islemci1 = new Islemci();
        islemci1.Topla(5, 15);
        islemci1.Topla(5, 15);
        islemci1.Topla(5, 15);
        islemci1.Topla(5, 15);

        Islemci islemci2 = new Islemci();
        islemci2.Topla(1, 7);
        islemci2.Topla(1, 7);
        islemci2.Topla(1, 7);
        islemci2.Topla(1, 7);
        islemci2.Topla(1, 7);
        islemci2.Topla(1, 7);

        Console.WriteLine($"işlemci1 'in yatpığı işlem sayısı : {islemci1.YapilanIslemSayisi}");
        Console.WriteLine($"işlemci2 'in yatpığı işlem sayısı : {islemci2.YapilanIslemSayisi}");
        Console.WriteLine($"Toplam yatpığı işlem sayısı : {Islemci.ToplamYapilanIslemSayisi}");










        // Category category1 = new Category();

        // Console.WriteLine(category1.ProductCount);

        // Product product1 = new Product("İphone13");
        // Console.WriteLine(product1.Name);

        // Product product2 = new Product();

        // Product product3 = new Product("Galaxy", "Güzel Telefon");

        // Product product4 = new Product("Kalem", "Süper Kalem", 567);
    }
}
