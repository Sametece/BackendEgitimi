using System;
using Microsoft.EntityFrameworkCore;
using soru5.Entity;

namespace soru5.Data;

public class BlogContext:DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }

    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = Blog.db");
    }

}
