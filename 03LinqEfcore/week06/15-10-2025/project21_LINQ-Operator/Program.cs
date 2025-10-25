namespace project21_LINQ_Operator;

class Program
{
    static void Main(string[] args)
    {
          // Where
        // Koleksiyon içindeki her bir eleman için bir koşul belirtmemizi sağlayıp, koşulu sağlayan(true olan) elemanlar için yeni bir koleksiyon döner. Tıpkı SQL'deki Where gibidir.

        // Fiyatı 1000 üzerinde olan Productları yeni bir koleksyion içine atalım.
        // List<Product> products = SeedData.Products;
        // var resultProducts = products
        //     .Where(p => p.Price > 1000);
        // Console.WriteLine("Fiyatı 1000'den yüksek olan ürünler");
        // Console.WriteLine("-----------------------------------");
        // foreach (Product product in resultProducts)
        // {
        //     Console.WriteLine($"Ürün: {product.Name} - Fiyat: {product.Price}");
        // }
        // Console.WriteLine("*************************************");
        // Console.WriteLine("*************************************");

        // // Elektronik kategorisindeki ürünleri electronics adındaki bir listeye atalım.
        // var electronics = products
        //     .Where(p => p.Category == "Elektronik");
        // Console.WriteLine("Elektronik kategorisindeki ürünler");
        // Console.WriteLine("-----------------------------------");
        // foreach (Product product in electronics)
        // {
        //     Console.WriteLine($"Id: {product.Id}, Ürün: {product.Name} - Fiyat: {product.Price} - Kategori: {product.Category}");
        // }
        // Console.WriteLine("*************************************");
        // Console.WriteLine("*************************************");

        // // Ürünlerin adlarını productNames adındaki bir listeye atalım.
        // var productNames = products
        //     .Select(p => p.Name);
        // Console.WriteLine("Ürünlerin adları");
        // Console.WriteLine("-------------------------------------------");
        // foreach (string productName in productNames)
        // {
        //     Console.WriteLine($"{productName}");
        // }
        // Console.WriteLine("*************************************");
        // Console.WriteLine("*************************************");

        // // Ürünlerin adlarıyla birlikte fiyatlarını da taşıyacak productsData adındaki bir listeye atalım.
        // var productsData = products
        //     .Select(p => new { p.Name, p.Price });
        // Console.WriteLine("Ürünlerin adları");
        // Console.WriteLine("-------------------------------------------");
        // foreach (var p in productsData)
        // {
        //     Console.WriteLine($"Ürün: {p.Name} - Fiyat: {p.Price}");
        // }
        // Console.WriteLine("*************************************");
        // Console.WriteLine("*************************************");

        // // Ürünlerin kategoriye göre sıralanmış halini orderedProducts adlı listeye atalım.
        // var orderedProducts = products
        //     .OrderBy(p => p.Category);
        // Console.WriteLine("Kategoriye Göre Sıralanmış Ürünler");
        // Console.WriteLine("---------------------------");
        // foreach (var p in orderedProducts)
        // {
        //     Console.WriteLine($"Ürün: {p.Name}, Kategori: {p.Category}, Fiyat: {p.Price}");
        // }
        // Console.WriteLine("*************************************");
        // Console.WriteLine("*************************************");
        // // Ürünlerin kategoriye ve fiyata göre sıralanmış halini orderedProducts2 adlı listeye atalım.
        // var orderedProducts2 = products
        //     .OrderBy(p => p.Category)
        //     .ThenBy(p => p.Price);
        // Console.WriteLine("Kategori ve Fiyata Göre Sıralanmış Ürünler");
        // Console.WriteLine("---------------------------");
        // foreach (var p in orderedProducts2)
        // {
        //     Console.WriteLine($"Ürün: {p.Name}, Kategori: {p.Category}, Fiyat: {p.Price}");
        // }

        List<Product> products = SeedData.Products;
        var result = products
            .Where(p => p.Category == "Elektronik" && p.Price > 600)
            .OrderByDescending(p => p.Price)
            .Select(p => new { p.Name, p.Price });
        Console.WriteLine("600'den pahalı olan elektronik ürünlerin fiyata göre büyükten küçüğe sıralanmış hali");
        Console.WriteLine("---------------------------");
        foreach (var p in result)
        {
            Console.WriteLine($"Ürün: {p.Name},  Fiyat: {p.Price}");
        }

    }
}
