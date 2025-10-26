namespace KargoÜcretiHesaplayici;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ------- Kargo Ücreti Hwsaplayıcı ------- ");

        double desi, agirlik, uzaklikKodu, fiyat;

        Console.Write("Ürünün Desisini Girin : ");
        desi = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ürün Ağırlığını Girin : ");
        agirlik = Convert.ToDouble(Console.ReadLine());

        Console.Write("Uzaklık Kodunu Girin : ");
        uzaklikKodu = Convert.ToDouble(Console.ReadLine());

        fiyat = 15.0 + (desi * 0.5) + (agirlik * 1.2) + (uzaklikKodu * 2.0);

        Console.WriteLine($"Bu ürün için ödenmesi gereken tutar : {fiyat} ₺. İyi Günler");

    }
}
