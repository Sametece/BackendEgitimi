using Microsoft.EntityFrameworkCore;
using MüşteriSiparisSistemi.Data;
using MüşteriSiparisSistemi.Entity;

namespace MüşteriSiparisSistemi;

class Program
{
    static void Main(string[] args)
    {
        var context = new ECommerceContext();

        #region Veri Ekleme : 2 müşteri ve her müşteriye 3 sipariş ekle


        if (!context.Customers.Any())  // Eğer Customers sınıfı boş ise ? Devam Et
        {
            Console.WriteLine("1.Müşteri Oluşturuluyor");
            var customer1 = new Customer //1. Müşteri oluşturuldu.
            {

                FirstName = "Samet",
                LastName = "Ece",
                Mail = "Sametece@c#.net.com",
                Orders = new List<Order>      //1. Müşteriye Ait siparişler oluşturuldu.
            {
               new Order {OrderDate = DateTime.Parse("2025-10-28"), TotalAmount= 100000},
               new Order {OrderDate = DateTime.Parse("2025-10-29"), TotalAmount= 150000},
               new Order {OrderDate = DateTime.Parse("2025-10-30"), TotalAmount= 200000},
            }
            };

            context.Customers.Add(customer1);
            context.SaveChanges();
            Console.WriteLine("1.Müşteri ve Müşteriye Ait Siparişler Oluşturuldu..");

            Console.WriteLine("2.Müşteri Oluşturuluyor");
            var customer2 = new Customer  //2. Müşteri
            {
                FirstName = "ikra",
                LastName = "Ece",
                Mail = "c#develeoper@.net.com",
                Orders = new List<Order>   //2.Müşteriye ait siparişler
                {
               new Order{OrderDate= DateTime.Parse("2025-10-28"), TotalAmount= 110000},
               new Order {OrderDate = DateTime.Parse("2025-10-29"), TotalAmount= 120000},
               new Order {OrderDate = DateTime.Parse("2025-10-30"), TotalAmount= 130000}
                }
            };
            context.Customers.Add(customer2);
            context.SaveChanges();
            Console.WriteLine("2.Müşteri ve Müşteriye Ait Siparişler Oluşturuldu..");

            Console.WriteLine("3.Müşteri Oluşturuluyor");
            var customer3 = new Customer  //3.Müşteri
            {
                FirstName = "Naz",
                LastName = "Ece",
                Mail = "back_endDeveloper@.net.com",
                Orders = new List<Order>     //3.Müşteriye ait siparişler
                {
               new Order{OrderDate= DateTime.Parse("2025-10-28"), TotalAmount= 160000},
               new Order {OrderDate = DateTime.Parse("2025-10-29"), TotalAmount= 180000},
               new Order {OrderDate = DateTime.Parse("2025-10-30"), TotalAmount= 190000}
                }
            };
            context.Customers.Add(customer3);
            context.SaveChanges();
            Console.WriteLine("3.Müşteri ve Müşteriye Ait Siparişler Oluşturuldu..");
        }
        else
        {
            Console.WriteLine("Müşteriler Zaten mevcut Tekrar eklenmedi");
        }
        #endregion

        #region İlişkili Veri Çekme 
         
        // Kullanıcıdan müşteri Id al
            Console.Write("Lütfen müşteri Id’sini girin: ");
            if (!int.TryParse(Console.ReadLine(), out int arananMusteriId))
            {
                Console.WriteLine("Geçersiz Id!");
                return;
            }

            // Müşteriyi ve siparişlerini çek
            var musteri = context.Customers
                                 .Include(c => c.Orders)
                                 .FirstOrDefault(c => c.Id == arananMusteriId);

            if (musteri == null)
            {
                Console.WriteLine("Bu Id'ye sahip müşteri bulunamadı.");
                return;
            }

            // Siparişleri en yeni -> en eski sırala ve projekte et
            var siraliSiparisler = musteri.Orders
                                          .OrderByDescending(o => o.OrderDate)
                                          .Select(o => new { o.OrderDate, o.TotalAmount })
                                          .ToList();

            // Sonuçları yazdır
            Console.WriteLine($"\nMüşteri: {musteri.FirstName} {musteri.LastName}");
            Console.WriteLine("Siparişler (En yeni -> En eski):");
        foreach (var sip in siraliSiparisler)
        {
            Console.WriteLine($"{sip.OrderDate:yyyy-MM-dd} - {sip.TotalAmount:C}");

        }

        #endregion

        #region Veri Güncelleme

        //Bir müşterinin e-posta (Email) adresini değiştirin ve SaveChanges() ile veritabanını güncelleyin

        Console.WriteLine("Lütfen Mail Adresini güncellemek istediğiniz kişinin IDsini Girin :  ");

        int MusteriId = Convert.ToInt32(Console.ReadLine());

        var result2 = context.Customers
                              .FirstOrDefault(c => c.Id == MusteriId); // girilen Değer ile Id 1-1 eşleşsin

        if (result2 != null)  // eğer sonuc null değil ise 
        {
            Console.WriteLine($"Girilen Id : {MusteriId} Bilgiler: {result2.FirstName} {result2.LastName} {result2.Mail}");

            Console.Write("Lütfen Yeni Mail Adresini Girin : ");
            string NewMail = Console.ReadLine();  // yeni maili girsin tipi string

            result2.Mail = NewMail!;

            context.SaveChanges();  // dbye kaydetsin
            Console.WriteLine($"{result2.FirstName} adlı kişinin mail adresi Güncellenmiştir.");
        }
        else
        {
            Console.WriteLine("Bu Id'ye ait Kişi Bulunamamıştır.");
        }
            
        #endregion
     }

          
         

 }

