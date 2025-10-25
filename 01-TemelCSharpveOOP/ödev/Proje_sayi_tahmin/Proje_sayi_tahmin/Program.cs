namespace Proje_sayi_tahmin;
/*
5. Sayı Tahmin Oyunu: Bilgisayarın 1-100 arasında rastgele bir sayı tutmasını sağlayın. (int rastgeleSayi = new Random().Next(1, 101);). Kullanıcıdan while döngüsü içinde tahminler alın. Girdiği sayı tutulan sayıdan küçükse "Daha Büyük!", büyükse "Daha Küçük!" diye ipucu verin. Doğru bildiğinde "Tebrikler, X denemede buldunuz!" yazdırıp döngüyü break ile kırın.

*/
class Program
{
    static void Main(string[] args)
    {
       int rastgeleSayi = new Random().Next(1, 101);

        int tahmin = 0;
        int denemeSayisi = 0;

        Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Bakalım kaç denemede bulabileceksin?");
        while (tahmin != rastgeleSayi)
        {
            Console.Write("Tahmininizi girin: ");
            tahmin = int.Parse(Console.ReadLine());
            denemeSayisi++;

            if (tahmin < rastgeleSayi)
            {
                Console.WriteLine("Daha Büyük!");
            }
            else if (tahmin > rastgeleSayi)
            {
                Console.WriteLine("Daha Küçük!");
            }
            else
            {
                Console.WriteLine($"Tebrikler, {denemeSayisi} denemede buldunuz!");
                break;
            }
        }
        }
    }

