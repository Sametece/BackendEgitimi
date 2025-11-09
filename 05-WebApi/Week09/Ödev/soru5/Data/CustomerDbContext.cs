using System;
using Microsoft.EntityFrameworkCore;
using soru5.Data.Entities;

namespace soru5.Data;

public class CustomerDbContext:DbContext
{
    public DbSet<Customer> Customers { get; set; } // clasımız

    public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options) // ctor
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(

        new Customer { Id = 1, FirstName = "Ahmet", LastName = "Yılmaz", Email = "ahmet.yilmaz@example.com", PhoneNumber = "0532 111 2233" },
        new Customer { Id = 2, FirstName = "Ayşe", LastName = "Demir", Email = "ayse.demir@example.com", PhoneNumber = "0543 222 3344" },
        new Customer { Id = 3, FirstName = "Mehmet", LastName = "Kaya", Email = "mehmet.kaya@example.com", PhoneNumber = "0551 333 4455" },
        new Customer { Id = 4, FirstName = "Fatma", LastName = "Şahin", Email = "fatma.sahin@example.com", PhoneNumber = "0505 444 5566" },
        new Customer { Id = 5, FirstName = "Ali", LastName = "Çelik", Email = "ali.celik@example.com", PhoneNumber = "0530 555 6677" },
        new Customer { Id = 6, FirstName = "Zeynep", LastName = "Aydın", Email = "zeynep.aydin@example.com", PhoneNumber = "0544 666 7788" },
        new Customer { Id = 7, FirstName = "Emre", LastName = "Koç", Email = "emre.koc@example.com", PhoneNumber = "0522 777 8899" },
        new Customer { Id = 8, FirstName = "Elif", LastName = "Arslan", Email = "elif.arslan@example.com", PhoneNumber = "0555 888 9900" },
        new Customer { Id = 9, FirstName = "Hasan", LastName = "Doğan", Email = "hasan.dogan@example.com", PhoneNumber = "0531 999 0011" },
        new Customer { Id = 10, FirstName = "Merve", LastName = "Kurt", Email = "merve.kurt@example.com", PhoneNumber = "0506 101 1122" }
        );
    }

}
