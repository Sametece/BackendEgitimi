using System;
using Microsoft.EntityFrameworkCore;
using soru3.Entity;

namespace soru3.Data;

public class ECommerceContext:DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }

    //Method

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = ECommerce.db");
    }

}
