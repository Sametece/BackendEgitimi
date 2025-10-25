using Project21_LINQ_Operators;

namespace Project22_LINQ_Advenced;

class Program
{

    static void Main(string[] args)
    {


        var products = SeedData.Products;
        var Orders = SeedData.Orders;
        var orderDetails = Orders.Join(
            products,
            o => o.ProductId,
            p => p.Id,
            (o, p) => new
            {
                SiparisNo = o.Id,
                UrunAdi = p.Name,
                SiparisAdedi = o.Quantity,
                BirimFiat = p.Price,
                ToplamFiat = o.Quantity * p.Price
            }

        );

        foreach (var orderDetail in orderDetails)
        {
            Console.WriteLine($"{orderDetail.SiparisNo}-{orderDetail.UrunAdi}-{orderDetail.SiparisAdedi}-{orderDetail.ToplamFiat}");
        }

        Console.WriteLine("Siparis Toplamı : "+orderDetails.Sum(od => od.BirimFiat * od.SiparisAdedi));
        


        //    var products = SeedData.Products;

        //     var id2Product = products
        //                                 .Where(p => p.Id == 2)
        //                              // .First(); koşulu sağlayan ilk elemanı döndürür bulamazsa hata fırlatır.
        //                              // .FirstOrDefault(); // koşulu sağlayan ilk elemanı döndürür, ulamazsa null döndürür.
        //                              // .Single();// koşulu salayan tek bir eleman oldupunu varsayar ve bunu döndürür, bulamazsa ya da birden fazla eleman döndürürse hata fırlatır.
        //                              .SingleOrDefault();//koşulu sağlayan ilk elemanı döndürür, bulamazsa yada birden fazla eleman varsa null döndürür.



        //     Console.WriteLine("Id sı 2 olan ürün  " + id2Product?.Name);



        // var products = SeedData.Products;

        // var totalElectronicValue = products
        //                             .Where(p => p.Category == "Elektronik")
        //                             .Sum(p => p.Price);




        // Console.WriteLine("Elektronik kategorisindeki ürünlerin toplam değerleri " + totalElectronicValue);



        // sum
        // var products = SeedData.Products;
        // var totalElectronicValue = products
        //                             .Where(p => p.Category == "Elektronik")
        //                             .Sum(p => p.Price);




        // Console.WriteLine("Elektronik kategorisindeki ürünlerin toplam değerleri " + totalElectronicValue);




        // static void Main(string[] args)
        // {
        //     // Group By 
        //     var products = SeedData.Products;
        //     var productsCountByCategory = products
        //                                 .GroupBy(p => p.Category)
        //                                 .Select(group => new
        //                                 {
        //                                     CategoryName = group.Key,
        //                                     ProductCount = group.Count()
        //                                 });



        //     Console.WriteLine("Kategoriye göre Ürün Adetleri ");
        //     foreach (var groupItem in productsCountByCategory)
        //     {
        //         Console.WriteLine($"Kategori : {groupItem.CategoryName} :  {groupItem.ProductCount}");


        //     }
    }
    



//     static void Main(string[] args)
//     {
//         // Group By 
//         var products = SeedData.Products;
//         var categoryGroups = products.GroupBy(p => p.Category);
// // Elde edilen IEnumerable<IGrouping<>> Collectionın içindeki her bir elemanbir key (kateogir aı), o key e ait ürünlerin listesini içerir.
//         Console.WriteLine("Kategoriye göre Grup ");
//         foreach (var group in categoryGroups)
//         {
//             Console.WriteLine($"Kategori : {group.Key}");
//             foreach (var p in group)
//             {
//                 Console.WriteLine($"****** {p.Name}");
//             }
//         }
//     }
}
