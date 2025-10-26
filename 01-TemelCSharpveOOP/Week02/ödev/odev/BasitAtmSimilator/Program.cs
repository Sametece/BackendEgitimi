using System.Diagnostics;

namespace BasitAtmSimilator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**** Basit Atm Menüsü **** ");

        int Bakiye = 10000;

        while (true)
        {
            Console.WriteLine("1-Bakiye Görüntüle");
            Console.WriteLine("2-Para Yatır");
            Console.WriteLine("3-Para Çek");
            Console.WriteLine("4-Çıkış\n");


          Console.Write("Hoşgeldeniz Öncelikle Yapmak İStediğiniz İşlemi Seçin : ");
            string secim = Console.ReadLine();  // string tuttuğum için case 1 değilde "1" dedik.

            int YatiricakTutar, CekilicekTutar;

            switch (secim)
            {
                case "1": //Bakiye Görüntüle
                    Console.WriteLine($"Mevcut Bakiyeniz : {Bakiye}₺");
                    break;

                case "2": // Para Yatır
                    Console.Write("Yatırılıcak Tutar : ");
                    YatiricakTutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Mevcut Yeni Bakiyeniz : {Bakiye + YatiricakTutar}₺");
                    break;

                case "3": // Para çek
                    Console.Write("Cekim Yapmak İstediğiniz Tutar : ");
                    CekilicekTutar = Convert.ToInt32(Console.ReadLine());

                    if (CekilicekTutar > Bakiye)
                    {
                        Console.WriteLine("Bakiyeniz Yetersiz!!!");
                    }
                    else
                    {
                        Console.WriteLine($"Çekim İşlemi Başarılı. Mevcut Bakiye : {Bakiye - CekilicekTutar}₺");
                    }
                    break;

                case "4":
                    Console.WriteLine("Çıkış Yapılıyor... İyi Günler...");
                    return;


                        default: Console.WriteLine("Hatalı seçim Yaptınız.....");
                    break;
            }
            
        }
        



    }
}
