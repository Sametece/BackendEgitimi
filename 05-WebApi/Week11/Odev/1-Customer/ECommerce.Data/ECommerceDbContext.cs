using System;
using ECommerce.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data;

public class ECommerceDbContext:DbContext
{
   public DbSet<Customer> Customers { get; set; }

   public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
   {
    
   }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Customer Bilgileri

        List<Customer> customers = [

          new Customer {Id=1, FirstName="Samet", LastName="Ece", Email="sametece@developer.com", City="İstanbul"},
          new Customer {Id=2, FirstName="Ahmet", LastName="Yılmaz", Email="ahmet.yilmaz@example.com", City="Ankara"},
          new Customer {Id=3, FirstName="Mehmet", LastName="Demir", Email="mehmet.demir@example.com", City="İzmir"},
          new Customer {Id=4, FirstName="Ayşe", LastName="Kara", Email="ayse.kara@example.com", City="Bursa"},
          new Customer {Id=5, FirstName="Fatma", LastName="Çelik", Email="fatma.celik@example.com", City="Antalya"},
          new Customer {Id=6, FirstName="Can", LastName="Aydın", Email="can.aydin@example.com", City="Eskişehir"},
          new Customer {Id=7, FirstName="Merve", LastName="Şahin", Email="merve.sahin@example.com", City="Konya"},
          new Customer {Id=8, FirstName="Ali", LastName="Güneş", Email="ali.gunes@example.com", City="Samsun"},
          new Customer {Id=9, FirstName="Zeynep", LastName="Kurt", Email="zeynep.kurt@example.com", City="Gaziantep"},
          new Customer {Id=10, FirstName="Burak", LastName="Taş", Email="burak.tas@example.com", City="Trabzon"},
       

        ];

        modelBuilder.Entity<Customer>().HasData(customers);
            
        #endregion
    }
}
