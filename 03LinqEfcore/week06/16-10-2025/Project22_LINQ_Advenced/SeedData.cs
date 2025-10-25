using Project22_LINQ_Advenced;

namespace Project21_LINQ_Operators;

public static class SeedData
{
    public static List<Product> Products { get; set; } = [
        new Product{Id=1, Name="Laptop", Price=45000, Category="Elektronik"},
        new Product{Id=2, Name="Klavye", Price=500, Category="Elektronik"},
        new Product{Id=3, Name="Kadınlar Ülkesi", Price=220, Category="Kitap"},
        new Product{Id=4, Name="Kahve Makinesi", Price=4500, Category="Mutfak"},
        new Product{Id=5, Name="Fare", Price=800, Category="Elektronik"},
        new Product{Id=6, Name="1984", Price=200, Category="Kitap"}
    ];

    public static List<Order> Orders { get; set; } = [
     new Order {Id=1001, ProductId =1, Quantity=1},
      new Order {Id=1002, ProductId =3, Quantity=5 },
       new Order {Id=1003, ProductId =1, Quantity=2}
    ];
}
