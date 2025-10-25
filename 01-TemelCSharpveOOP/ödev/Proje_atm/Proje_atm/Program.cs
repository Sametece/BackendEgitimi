namespace Proje_atm;

class Program
{
    static void Main(string[] args)
    {
       int bakiye = 1000; // başlangıç bakiyesi

while (true)
{
    Console.WriteLine("\n--- ATM MENÜ ---");
    Console.WriteLine("1 - Bakiye Görüntüle");
    Console.WriteLine("2 - Para Yatır");
    Console.WriteLine("3 - Para Çek");
    Console.WriteLine("4 - Çıkış");
    Console.Write("Seçiminizi yapınız: ");

    string secim = Console.ReadLine();
    int yatirilicakMiktar, cekilecekMiktar;
    switch (secim)
    {
        case "1": // bakiye görüntüle
            Console.WriteLine($"Bakiye : {bakiye} "); 
            break;

        case "2": // para yatır
            Console.Write("Yatırmak istediğiniz tutar : ");
            yatirilicakMiktar = int.Parse(Console.ReadLine());
            bakiye += yatirilicakMiktar;
            Console.WriteLine($"Güncel Bakiye : {bakiye}");
            break;

        case "3": // para çek 
            Console.Write("Çekilecek Tutar : ");
            cekilecekMiktar = int.Parse(Console.ReadLine());
            if (cekilecekMiktar <= bakiye)
            {
                bakiye -= cekilecekMiktar;
                Console.WriteLine($"Güncel Bakiye : {bakiye}");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!");
            }
            break;

        case "4":  // çıkış
            Console.WriteLine("Çıkış yapılıyor...");
            return; // Programı tamamen sonlandırır
    }
}
    }
}
