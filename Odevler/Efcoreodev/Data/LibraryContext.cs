using System;
using Efcoreodev.Entity;
using Microsoft.EntityFrameworkCore;

namespace Efcoreodev;

public class LibraryContext : DbContext // bu mirası alabilmek için paketleri yükle
{
 
   public DbSet<Author> Authors { get; set; }
   public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=Libraryapp.db");
    }

  
}
