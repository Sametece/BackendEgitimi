namespace Project05_Exersice;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("_____Ürün Kayıt Ekranı_____");

        Console.Write("Ürün Adı: ");
        string productName = Console.ReadLine();
        Console.Write("Stok Adedi: ");
        int stockAmount = Convert.ToInt32(Console.ReadLine());
        Console.Write("KDV'siz Fiyat: ");
        decimal price = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Ürün Kampanyada mı? (true/false) ");
        bool isCamp = Convert.ToBoolean(Console.ReadLine());
        decimal withTaxPrice = price * 1.2m;


        Console.WriteLine();
        Console.WriteLine("Ürün Bilgileri");
        Console.WriteLine("--------------");

        Console.WriteLine("ÜRÜN ADI: " + productName);
        Console.WriteLine("STOK MİKTARI: " + stockAmount + " adet");
        Console.WriteLine("KDV'li Fiyat: " + withTaxPrice);
        Console.WriteLine("ÜRÜN KAMPANYADA MI? " + (isCamp ? "Kampanyada" : "Kampanyada Değil"));

        Console.WriteLine("Uygulamayı durdurmak için enter tuşuna basınız...");
        Console.ReadLine();


        
        
            }
}
