using System;

namespace Proje_odev;

public class Customer
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;


    public static  List<Customer> customers = new List<Customer> {
        new Customer { Id = 1, FullName = "Ali Veli", City = "İstanbul" },
        new Customer { Id = 2, FullName = "Ayşe Yılmaz", City = "Ankara" },
        new Customer { Id = 3, FullName = "Mehmet Kaya", City = "İzmir" },
        new Customer { Id = 4, FullName = "Zeynep Demir", City = "Ankara" },
        new Customer { Id = 5, FullName = "Fatma Öztürk", City = "Bursa" }
        // Siparişi olmayan müşteri }; List
    };
}
