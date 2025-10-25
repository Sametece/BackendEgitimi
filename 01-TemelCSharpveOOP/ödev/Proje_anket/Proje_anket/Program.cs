namespace Proje_anket;
/*
6. Mini Anket Analizi: 5 kişilik bir anketin "Memnuniyet" puanlarını (1-10 arası) bir int dizisinde saklayın. Bir for döngüsü kullanarak bu dizideki puanların ortalamasını, en yüksek puanı ve en düşük puanı bulun ve ekrana yazdırın.
*/
class Program
{
    static void Main(string[] args)
    {
       using System;

class Program
{
    static void Main()
    {
        int[] puanlar = new int[5]; // 5 kişilik anket
        int toplam = 0;

        // Kullanıcıdan puanları al
        for (int i = 0; i < puanlar.Length; i++)
        {
            Console.Write($"{i + 1}. kişinin memnuniyet puanını giriniz (1-10): ");
            int puan = Convert.ToInt32(Console.ReadLine());

            // Geçersiz değer kontrolü
            while (puan < 1 || puan > 10)
            {
                Console.WriteLine("Geçersiz değer! Lütfen 1 ile 10 arasında bir sayı giriniz.");
                Console.Write($"{i + 1}. kişinin memnuniyet puanını giriniz (1-10): ");
                puan = Convert.ToInt32(Console.ReadLine());
            }

            puanlar[i] = puan;
            toplam += puan;
        }

        // Ortalama, minimum ve maksimum bulma
        double ortalama = (double)toplam / puanlar.Length;
        int enDusuk = puanlar[0];
        int enYuksek = puanlar[0];

        for (int i = 1; i < puanlar.Length; i++)
        {
            if (puanlar[i] < enDusuk)
                enDusuk = puanlar[i];

            if (puanlar[i] > enYuksek)
                enYuksek = puanlar[i];
        }

        // Sonuçları yazdır
        Console.WriteLine("\n--- Anket Analizi ---");
        Console.WriteLine($"Ortalama: {ortalama}");
        Console.WriteLine($"En Düşük Puan: {enDusuk}");
        Console.WriteLine($"En Yüksek Puan: {enYuksek}");
    }
}

    }
}
