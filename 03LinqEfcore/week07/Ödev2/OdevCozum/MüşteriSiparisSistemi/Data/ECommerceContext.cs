using System;
using Microsoft.EntityFrameworkCore;
using MüşteriSiparisSistemi.Entity;

namespace MüşteriSiparisSistemi.Data;

public class ECommerceContext:DbContext
{
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = Ecommerce.db"); 
    }
}
