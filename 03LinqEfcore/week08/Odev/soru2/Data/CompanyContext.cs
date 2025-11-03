using System;
using Microsoft.EntityFrameworkCore;
using soru2.Entity;

namespace soru2.Data;

public class CompanyContext:DbContext
{
   public DbSet<Department> Departments { get; set; }
   public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = Company.db");
    }
}
