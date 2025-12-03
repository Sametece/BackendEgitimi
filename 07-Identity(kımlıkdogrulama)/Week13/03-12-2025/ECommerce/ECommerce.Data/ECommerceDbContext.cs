using System;
using ECommerce.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data;

public class ECommerceDbContext : DbContext
{
    public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasQueryFilter(x => !x.IsDeleted);
        modelBuilder.Entity<Category>().HasQueryFilter(x => !x.IsDeleted);

        modelBuilder.Entity<ProductCategory>().HasKey(x => new { x.ProductId, x.CategoryId });

        #region Kategori Bilgileri
        List<Category> categories =
        [
            new Category
            {
                Id = 1,
                Name = "Akıllı Telefonlar",
                Description = "Güncel akıllı telefon modelleri",
                CreatedAt = new DateTime(2025,11,10),
                ModifiedAt = new DateTime(2025,11,10)
            },
            new Category
            {
                Id = 2,
                Name = "Aksesuarlar",
                Description = "Telefon aksesuarları ve tamamlayıcı ürünler",
                CreatedAt = new DateTime(2025,11,11),
                ModifiedAt = new DateTime(2025,11,11)
            },
            new Category
            {
                Id = 3,
                Name = "Elektronik",
                Description = "Genel elektronik ürünler",
                CreatedAt = new DateTime(2025,11,12),
                ModifiedAt = new DateTime(2025,11,12)
            }
        ];

        modelBuilder.Entity<Category>().HasData(categories);
        #endregion

        #region Ürün Bilgileri
        List<Product> products =
        [
            new Product { Id=1, Name="iPhone 16 Pro", Price=72000, StockQuantity=12, CreatedAt=new DateTime(2025,11,19), ModifiedAt=new DateTime(2025,11,19) },
            new Product { Id=2, Name="iPhone 16", Price=64000, StockQuantity=20, CreatedAt=new DateTime(2025,11,19), ModifiedAt=new DateTime(2025,11,19) },
            new Product { Id=3, Name="Samsung Galaxy S25 Ultra", Price=68000, StockQuantity=15, CreatedAt=new DateTime(2025,11,18), ModifiedAt=new DateTime(2025,11,18) },
            new Product { Id=4, Name="Xiaomi 14 Ultra", Price=52000, StockQuantity=30, CreatedAt=new DateTime(2025,11,17), ModifiedAt=new DateTime(2025,11,17) },
            new Product { Id=5, Name="Google Pixel 9 Pro", Price=58000, StockQuantity=18, CreatedAt=new DateTime(2025,11,16), ModifiedAt=new DateTime(2025,11,16) },

            new Product { Id=6, Name="Apple AirPods Pro 3", Price=12000, StockQuantity=50, CreatedAt=new DateTime(2025,11,15), ModifiedAt=new DateTime(2025,11,15) },
            new Product { Id=7, Name="Samsung Galaxy Buds 3 Pro", Price=9000, StockQuantity=60, CreatedAt=new DateTime(2025,11,14), ModifiedAt=new DateTime(2025,11,14) },
            new Product { Id=8, Name="Anker PowerCore 30000 mAh", Price=3500, StockQuantity=100, CreatedAt=new DateTime(2025,11,13), ModifiedAt=new DateTime(2025,11,13) },
            new Product { Id=9, Name="Baseus GaN 65W Şarj Cihazı", Price=2500, StockQuantity=80, CreatedAt=new DateTime(2025,11,11), ModifiedAt=new DateTime(2025,11,11) },
            new Product { Id=10, Name="Logitech MX Master 4", Price=6000, StockQuantity=40, CreatedAt=new DateTime(2025,11,10), ModifiedAt=new DateTime(2025,11,10) }
        ];

        modelBuilder.Entity<Product>().HasData(products);
        #endregion

        #region Ürün-Kategori Bağlantıları
        List<ProductCategory> productCategories =
        [
            // İlk 5 ürün (Id 1-5) -> Kategori 1 ve 3
            new ProductCategory { ProductId = 1, CategoryId = 1 },
            new ProductCategory { ProductId = 1, CategoryId = 3 },

            new ProductCategory { ProductId = 2, CategoryId = 1 },
            new ProductCategory { ProductId = 2, CategoryId = 3 },

            new ProductCategory { ProductId = 3, CategoryId = 1 },
            new ProductCategory { ProductId = 3, CategoryId = 3 },

            new ProductCategory { ProductId = 4, CategoryId = 1 },
            new ProductCategory { ProductId = 4, CategoryId = 3 },

            new ProductCategory { ProductId = 5, CategoryId = 1 },
            new ProductCategory { ProductId = 5, CategoryId = 3 },

            // Sonraki 5 ürün (Id 6-10) -> Kategori 1, 2 ve 3
            new ProductCategory { ProductId = 6, CategoryId = 1 },
            new ProductCategory { ProductId = 6, CategoryId = 2 },
            new ProductCategory { ProductId = 6, CategoryId = 3 },

            new ProductCategory { ProductId = 7, CategoryId = 1 },
            new ProductCategory { ProductId = 7, CategoryId = 2 },
            new ProductCategory { ProductId = 7, CategoryId = 3 },

            new ProductCategory { ProductId = 8, CategoryId = 1 },
            new ProductCategory { ProductId = 8, CategoryId = 2 },
            new ProductCategory { ProductId = 8, CategoryId = 3 },

            new ProductCategory { ProductId = 9, CategoryId = 1 },
            new ProductCategory { ProductId = 9, CategoryId = 2 },
            new ProductCategory { ProductId = 9, CategoryId = 3 },

            new ProductCategory { ProductId = 10, CategoryId = 1 },
            new ProductCategory { ProductId = 10, CategoryId = 2 },
            new ProductCategory { ProductId = 10, CategoryId = 3 }
                ];

        modelBuilder.Entity<ProductCategory>().HasData(productCategories);
        #endregion


    }
}
