using System;

namespace Proje_odev;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }



    public static List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Akıllı Telefon", Category = "Elektronik", Price = 4500.00m, StockQuantity = 50 },
        new Product { Id = 2, Name = "Dizüstü Bilgisayar", Category = "Elektronik", Price = 12000.00m, StockQuantity = 25 },
        new Product { Id = 3, Name = "Kahve Makinesi", Category = "Mutfak Eşyaları", Price = 1200.00m, StockQuantity = 10 },
        new Product { Id = 4, Name = "Roman Kitabı", Category = "Kitap", Price = 80.00m, StockQuantity = 200 },
        new Product { Id = 5, Name = "Kablosuz Kulaklık", Category = "Elektronik", Price = 950.00m, StockQuantity = 75 }, new Product { Id = 6, Name = "Tarih Ansiklopedisi", Category = "Kitap", Price = 250.00m, StockQuantity = 80 }, new Product { Id = 7, Name = "Blender Seti", Category = "Mutfak Eşyaları", Price = 1800.00m, StockQuantity = 40 }
    };
}
