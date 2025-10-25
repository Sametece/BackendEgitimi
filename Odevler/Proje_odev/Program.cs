using System.Data.SqlTypes;
using System.IO.Compression;

namespace Proje_odev;

class Program
{
    static void Main(string[] args)
    {

        var result = Order.orders.Join(Product.products,
                                       o => o.ProductId,
                                       p => p.Id,
                                    (o, p) => new
                                    {
                                        o.CustomerId,
                                        ToplamHarcama = o.Quantity * p.Price
                                    })
                                    .GroupBy(g => g.CustomerId)
                                    .Select(g => g.Sum(x => x.ToplamHarcama))
                                    .OrderByDescending().First();
            foreach (var item in result)
            {
                Console.WriteLine($"{item.}")
            }
                                                        
                                       

        
                                        

      

                                 








        
     







    }


}

/* 1.Soru
        var result = Product.products.Where(p => p.Price < 1000 && p.StockQuantity > 50)
                                     .OrderByDescending(p => p.Price);
            foreach (var x in result)
            {
            Console.WriteLine($"Ürün Adı: {x.Name} fiyat: {x.Price} Stok:{x.StockQuantity}");
            }
            */


/*  2.Soru

        var result = Product.products.Select(p => new
        {
            ProductName = p.Name,
            StockStatus = p.StockQuantity < 20 ? "Kritik Stok" : "Yeterli Stok",
            PriceWithVat = p.Price * 1.18m
        });

          foreach (var x in result)
          {
            Console.WriteLine($"ProductName: {x.ProductName} Price vith vat: {x.PriceWithVat} ₺  Stok Status: {x.StockStatus}");
          }
*/

/* 3.Soru 

        var result = Product.products.GroupBy(g => g.Category)
                                     .Select(p => new
                                     {
                                         KategoriAd = p.Key,
                                         EnpahaliUrun = p.OrderByDescending(p => p.Price).First()
                                     });

        foreach (var sonuc in result)
        {
            Console.WriteLine($"Kategori: {sonuc.KategoriAd} En pahalı ürün: {sonuc.EnpahaliUrun.Price} ");
        }
            */

/*   // 4.Soru 

        var result = Order.orders.Join(Customer.customers,
                                       o => o.CustomerId,
                                       c => c.Id,
                                     (o, c) => new { o, c })
                                 .Join(Product.products,

                                      oc => oc.o.ProductId,
                                      p => p.Id,
                                      (oc, p) => new
                                      {
                                          MusteriAd = oc.c.FullName,
                                          Sehir = oc.c.City,
                                          UrunAd = p.Name,
                                          adet = oc.o.Quantity,
                                          Birimfiyat = p.Price,
                                          siparisTarihi = oc.o.OrderDate
                                      });

      foreach (var x in result)
      {
            Console.WriteLine($"Müşteri: {x.MusteriAd} {x.Sehir} ürün:{x.UrunAd}, Adet: {x.adet} Fiyat: {x.Birimfiyat} Tarih: {x.siparisTarihi} ");
      }
               
                */

/*  5.Soru 

        var result = Order.orders.Join(Customer.customers,
                                    o => o.CustomerId,
                                    c => c.Id,
                                    (o, c) => new { o.OrderId, c.City,o.OrderDate,c.FullName })
                                    .Where(c => c.City == "Ankara");

        foreach (var sonuc in result)
        {
            Console.WriteLine($"Sipariş ID:{sonuc.OrderId} Müşteri: {sonuc.FullName} Tarih: {sonuc.OrderDate}");
        }
            */

/*
*/