using System;
using Blog_Sistemi.Entity;
using Microsoft.EntityFrameworkCore;

namespace Blog_Sistemi.Data;

public class BlogContext : DbContext
{

    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
   public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = Blog.db");
    }

}
