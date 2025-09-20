namespace Proje_zaman_makinasi;

class Program
{
    static void Main(string[] args)
    {

       
        int  deger, kalan, saniye,dakika, saat;
         Console.WriteLine("**** Zaman Makinesi - Saniye Dönüştürücü ****");

        Console.Write("Toplam saniyeyi giriniz: ");
         deger = Convert.ToInt32(Console.ReadLine());

         
        // Saat hesabı
        saat = deger / 3600;     // 1 saat = 3600 saniye
         kalan = deger % 3600;  // saatlerden kalan saniye

        // Dakika hesabı
         dakika = kalan / 60;          // 1 dakika = 60 saniye
         saniye = kalan % 60;          // dakikadan kalan saniye

        Console.WriteLine();
        Console.WriteLine("Sonuç: " + saat + " saat, " + dakika + " dakika, " + saniye + " saniye");
        



    }
}
