namespace ZamanMakinesi;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**** Zaman Makinesi - Saniye Dönüştürücü **** \n");

        int VerilenSaniye, Dakika, Saat, Saniye,Kalan;

        Console.Write("Lütfen Zaman Giriniz (Saniye Cinsinden) :");
        VerilenSaniye = Convert.ToInt32(Console.ReadLine());

        //Saat Hesabı

        Saat = VerilenSaniye / 3600;  //1 Saat 3600 saniye
        Kalan = VerilenSaniye % 3600;  //Saatlerden Kalan saniye


        //Dakika Hesabı
        Dakika = Kalan / 60;  // 1Dakika 60 Saniye
        Saniye = Kalan % 60;  // Dakikadan Kalan Saniye 
        

        Console.WriteLine($"Saat : {Saat} Dakika : {Dakika} Saniye : {Saniye}");
    }
}
