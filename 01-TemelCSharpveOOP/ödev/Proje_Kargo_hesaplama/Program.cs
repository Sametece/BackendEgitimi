namespace Proje_Kargo_hesaplama;

class Program
{
    static void Main(string[] args)
    {
        double desi, agirlik, ucret;
        int uzaklik_kodu;

        Console.WriteLine("**** Kargo Ücreti Hesaplayıcı ****");

        Console.Write("Ürün Desisini Girin : ");
        desi = double.Parse(Console.ReadLine());          

        Console.Write("Ürün Ağırlığını Girin (KG) : ");
        agirlik = double.Parse(Console.ReadLine());

        Console.Write("Uzaklık Kodunu Girin : ");
        uzaklik_kodu = int.Parse(Console.ReadLine());


        ucret = 15 + (desi * 0.5) + (agirlik * 1.2) + (uzaklik_kodu * 2.0);

        Console.WriteLine("Toplam Ödeyeceğiniz Tutar : " + ucret + "TL");



    }
}
