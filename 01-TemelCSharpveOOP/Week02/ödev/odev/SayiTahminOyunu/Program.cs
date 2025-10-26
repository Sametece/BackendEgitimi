namespace SayiTahminOyunu;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("****** Basit Sayı Tahmin Oyununa Hoşgeldiniz ******");

        // Random Kütüphanesinden 1-101 arası rastgeleSayi nesnesi ürettik.
        int RastgeleSayi = new Random().Next(1, 101);

        int Tahmin=0;
        int DenemeSayisi = 0;

        while (Tahmin != RastgeleSayi)   // While 'n şartı sağladığı sürece çalışsın.
        {
            Console.Write("Lütfen Bir Tahminde Bulununuz : ");
            Tahmin = Convert.ToInt32(Console.ReadLine());
            DenemeSayisi  ++;

            if (RastgeleSayi < Tahmin)
            {
                Console.WriteLine("Lütfen Daha Küçük Bir Sayı Girin!!");
            }
            else if (RastgeleSayi > Tahmin)
            {
                Console.WriteLine("Lütfen Daha Büyük Bir Sayı Girin!!");
            }
            else
            {
                Console.WriteLine($"Tebrikler Doğru Sayıyı {DenemeSayisi}. Denemede Tahmin ettiniz");
                break;
            }

        }
        
    }
}
