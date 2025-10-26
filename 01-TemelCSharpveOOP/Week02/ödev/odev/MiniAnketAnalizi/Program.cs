namespace MiniAnketAnalizi;

class Program
{
    static void Main(string[] args)
    {
        int[] puanlar = new int[5];  // 5 Elemanlık bir Dizi oluşturuldu.

        for (int i = 0; i < puanlar.Length; i++)
        {
            Console.Write($"Kişi {i + 1} için puan (1-10): ");
            puanlar[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0;
        int enYuksek = puanlar[0];
        int enDusuk = puanlar[0];

        for (int i = 0; i < puanlar.Length; i++)
        {
            toplam += puanlar[i];

            if (puanlar[i] > enYuksek)
                enYuksek = puanlar[i];

            if (puanlar[i] < enDusuk)
                enDusuk = puanlar[i];
        }

        double ortalama = (double)toplam / puanlar.Length;

        Console.WriteLine($"\nOrtalama: {ortalama}");
        Console.WriteLine($"En yüksek puan: {enYuksek}");
        Console.WriteLine($"En düşük puan: {enDusuk}");
    }

  }
    

