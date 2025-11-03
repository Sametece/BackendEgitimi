using System;
using Microsoft.EntityFrameworkCore;
using Project28_Architecture_BestPractices.Entities;

namespace Project28_Architecture_BestPractices.Data;

public class BlogDbContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Post> Posts { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=blogapp.db");
    }
}
