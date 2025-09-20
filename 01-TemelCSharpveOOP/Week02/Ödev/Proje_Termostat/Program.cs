namespace Proje_Termostat;
 // mevcut sıcaklık - hedef sıcaklık -klima durumu tutan değişenkler 
class Program
{
    static void Main(string[] args)
    {

         int Mevcut_Sicaklik, Hedef_Sicaklik;
         bool Klima;                  // klima açık mı kapalı mı iki seçenek verdik.

        Console.Write("Mevcut Sıcaklık : ");
        Mevcut_Sicaklik = int.Parse(Console.ReadLine()); // Klavyeden Mevcut Sıcaklığı istedik.

        Console.Write("Hedeflenen Sıcaklık : ");
        Hedef_Sicaklik = Convert.ToInt32(Console.ReadLine()); // Klavyeden Hedeflenen Sıcaklığı istedik.

        Klima = false;                               // klimanın  başlangıçta kapalı olduğunu gösterdik.

        bool Klima_Durumu = (Mevcut_Sicaklik >= Hedef_Sicaklik + 2) && (Klima == false); // şartımız.

        Console.WriteLine("Klima açılmalı mı? " + Klima_Durumu);
        

    }
}
