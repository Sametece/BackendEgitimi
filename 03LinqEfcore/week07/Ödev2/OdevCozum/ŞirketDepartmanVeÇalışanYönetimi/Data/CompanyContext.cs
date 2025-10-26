using System;
using Microsoft.EntityFrameworkCore;
using ŞirketDepartmanVeÇalışanYönetimi.Entity;

namespace ŞirketDepartmanVeÇalışanYönetimi.Data;

public class CompanyContext : DbContext
{
   public DbSet<Department> Departments { get; set; } // oluşturduğumuz classları getirdik.
   public DbSet<Employee> Employees { get; set; }  

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Db yoksa üret.Varsa Kullan
    {
        optionsBuilder
                       .UseSqlite("Data Source = Company.db"); // Db name
    }

}
