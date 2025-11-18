using System;
using Microsoft.EntityFrameworkCore;
using Project33_WebApiActionMethods.Data.Entities;

namespace Project33_WebApiActionMethods.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Apple iPhone 15", Description = "6.1 inç Super Retina XDR ekranlı, A16 Bionic çipli akıllı telefon", Price = 49999 },
            new Product { Id = 2, Name = "Samsung 55'' QLED TV", Description = "4K UHD çözünürlük, HDR10+ destekli 55 inç akıllı televizyon", Price = 29999 },
            new Product { Id = 3, Name = "Dyson V15 Detect", Description = "Lazerli kablosuz dik süpürge, güçlü emiş gücü ve toz algılama teknolojisi", Price = 25999 },
            new Product { Id = 4, Name = "Sony WH-1000XM5", Description = "Gürültü engelleyici kablosuz kulaklık, yüksek çözünürlüklü ses desteği", Price = 14999 },
            new Product { Id = 5, Name = "Asus ROG Zephyrus G14", Description = "14'' ekran, AMD Ryzen 9 işlemci, RTX 4060 ekran kartlı gaming laptop", Price = 64999 },
            new Product { Id = 6, Name = "Nike Air Max 270", Description = "Hava taban teknolojili spor ayakkabı, konfor ve stil bir arada", Price = 4999 },
            new Product { Id = 7, Name = "Philips Airfryer XXL", Description = "Yağsız fritöz, sıcak hava teknolojisiyle sağlıklı kızartmalar", Price = 8999 },
            new Product { Id = 8, Name = "Casio G-Shock GA-2100", Description = "Darbeye dayanıklı, su geçirmez analog-dijital kol saati", Price = 3999 },
            new Product { Id = 9, Name = "Logitech MX Master 3S", Description = "Ergonomik kablosuz mouse, sessiz tıklama ve hızlı şarj desteği", Price = 3299 },
            new Product { Id = 10, Name = "Kindle Paperwhite 11. Nesil", Description = "6.8 inç aydınlatmalı e-kitap okuyucu, suya dayanıklı tasarım", Price = 5999 }
        );

    }
}
