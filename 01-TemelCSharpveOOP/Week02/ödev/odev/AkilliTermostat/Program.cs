namespace AkilliTermostat;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("****** Akıllı Termostat Uygulaması ******");

        double MevcutSicaklik, HedefSicaklik;

        bool KlimaDurumu = false; // Klima Başta Kapalı

        Console.Write("Lütfen Oda Sıcaklığını Girin : ");
        MevcutSicaklik = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Lütfen Hedeflenen Sıcaklığını Girin : ");
        HedefSicaklik = Convert.ToDouble(Console.ReadLine());

        bool Klima = (MevcutSicaklik >= HedefSicaklik + 2) && (KlimaDurumu == false);

        Console.WriteLine($"Klima Çalışıyormu ? : {Klima}");
        
        
    }
}
