namespace Project08_loops;

class Program
{
    static void Main(string[] args)
    {
       // for (int sayac = 1; sayac < 6; sayac++)
        // {
        //     Console.WriteLine("Hello, World!");
        // }

        // 5000 TL'lik anaparayı yıllık %20 faizle yıl boyu işletelim, 5 yıllık durumu görelim
        // decimal anaPara = 5000m;
        // decimal faizOrani = 0.20m;

        // Console.WriteLine($"Başlangıç Anapara = {anaPara} TL");

        // for (int yil = 1; yil <= 5; yil++)
        // {
        //     anaPara += anaPara * faizOrani;
        //     Console.WriteLine($"{yil}.Yıl Sonu Bakiye: {anaPara} TL");
        //     // Console.WriteLine(yil + ".Yıl Sonu Bakiye: " + anaPara + " TL");
        // }

        int bakiye = 1000;
        int cekilecekMiktar = 0;

        while (bakiye > 0)
        {
            Console.Write($"Mevcut Bakiyeniz: {bakiye} TL. Çekmek istediğiniz tutarı girin(Çıkmak için 0 girin): ");
            cekilecekMiktar = Convert.ToInt32(Console.ReadLine());
            if (cekilecekMiktar == 0)
            {
                Console.WriteLine("İşlem sonlandırıldı!");
                break; // döngüyü sonlandır, yani while bloğunun alt satırına geç
            }
            
            if (cekilecekMiktar > bakiye)
            {
                Console.WriteLine("Yetersiz bakiye! Daha küçük bir değer girin!");
                continue; // Döngüye devam et, yani while satırına geç
            }
            bakiye -= cekilecekMiktar;
            Console.WriteLine($"Para çekildi. Kalan Bakiye: {bakiye} TL");
        }

        Console.WriteLine("Uygulama sona erdi!");

    }
}
