using System;
using Microsoft.EntityFrameworkCore;
using ödev.Entity;

namespace ödev.Data;

public class LibraryContext : DbContext
{
    //Çalışılıcak 2 class prop şeklinde tanımlandı
    public DbSet<Author> Authors { get; set; }

    public DbSet<Book> Books { get; set; }

    // veri tabanı yoksa yarat, varsa devam et

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = Library.db");
    }

}
