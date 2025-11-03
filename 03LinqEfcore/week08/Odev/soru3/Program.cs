using soru3.Data;
using soru3.Data.Concrete.EFCore;
using soru3.Entity;

namespace soru3;

class Program
{
    static void Main(string[] args)
    {
        var context = new ECommerceContext();

        // Repos oluştur
        var customerRepository = new CustomerRepository(context);
        var orderRepository = new OrderRepository(context);

        // Önce müşteri oluştur
        var customer1 = new Customer
        {
            FirstName = "Samet",
            LastName = "Ece",
            Email = "sametece@developer.com"
        };

        customerRepository.Add(customer1);

        // Şimdi sipariş oluştur ve müşteriyle ilişkilendir
        var order1 = new Order
        {
            TotalAmount = 100000,
            CustomerId = customer1.Id // doğru ilişki burada kurulur
        };

        orderRepository.Add(order1);


        Console.WriteLine("Müşteri 1 ve sipariş başarıyla eklendi!");

        var customer2 = new Customer
        {
            FirstName = "Selin",
            LastName = "Arslan",
            Email = "Selinars@developer.com"
        };

        customerRepository.Add(customer2);

        var order2 = new Order
        {
            TotalAmount = 50000,
            CustomerId = customer2.Id
        };

        orderRepository.Add(order2);

        Console.WriteLine("Müşteri 2 Ve siparişi başarıyla eklendi");

        var order3 = new Order
        {
            TotalAmount = 12000,
            CustomerId = customer1.Id
        };

        orderRepository.Add(order3);
        Console.WriteLine("1. Müşterinin 2. Siparişi Başarıyla Eklendi ");

        var order4 = new Order
        {
            TotalAmount = 400000,
            CustomerId = customer2.Id
        };

        orderRepository.Add(order4);
        Console.WriteLine("2.Müşterinin 2. Siparişi başarıyla Eklendi. ");

        //var context = new ECommerceContext();
        

        // Repos oluştur
        // var customerRepository = new CustomerRepository(context);
        // var orderRepository = new OrderRepository(context);

        int hedefMusteriId = 1; // örnek
        var orders = customerRepository.GetOrdersByCustomerId(hedefMusteriId);

        Console.WriteLine($"Müşteri {hedefMusteriId} siparişleri:");
        foreach (var o in orders)
        {
            Console.WriteLine($"Sipariş ID: {o.Id} | Tarih: {o.PublishedOn} | Tutar: {o.TotalAmount}₺");
        }


// var context = new ECommerceContext();

        // Repos oluştur
        // var customerRepository = new CustomerRepository(context);
        // var orderRepository = new OrderRepository(context);

// 1️ Güncellemek istediğin müşteriyi getir
var customer = customerRepository.GetById(1); // örnek olarak Id = 1

if (customer != null)
{
    //  Yeni e-posta adresini ata
    customer.Email = "samet.ece@updatedmail.com";

    //  Güncelleme işlemini bildir ve kaydet
    customerRepository.Update(customer);
    

    Console.WriteLine("Müşteri e-posta adresi başarıyla güncellendi!");
}
else
{
    Console.WriteLine("Müşteri bulunamadı.");
}

    }
}
