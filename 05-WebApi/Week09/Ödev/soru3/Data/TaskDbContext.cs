using System;
using Microsoft.EntityFrameworkCore;
using soru3.Data.Entites;

namespace soru3.Data;

public class TaskDbContext:DbContext
{


    public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) // ctor
    {

    }
    public DbSet<ToDoTask> ToDoTasks { get; set; }  // classı tanımla

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ToDoTask>().HasData(

         new ToDoTask { Id = 1, Title = "Alışveriş Yap", Description = "Market alışverişini tamamla", IsCompleted = false, DueDate = new DateTime(2025, 11, 5) },
    new ToDoTask { Id = 2, Title = "Faturaları Öde", Description = "Elektrik ve internet faturalarını öde", IsCompleted = false, DueDate = new DateTime(2025, 11, 6) },
    new ToDoTask { Id = 3, Title = "Toplantıya Katıl", Description = "Saat 14:00'te proje toplantısına katıl", IsCompleted = true, DueDate = new DateTime(2025, 11, 2) },
    new ToDoTask { Id = 4, Title = "Egzersiz Yap", Description = "30 dakika yürüyüş yap", IsCompleted = false, DueDate = new DateTime(2025, 11, 4) },
    new ToDoTask { Id = 5, Title = "Kitap Oku", Description = "Her gün 20 sayfa kitap oku", IsCompleted = true, DueDate = new DateTime(2025, 10, 31) },
    new ToDoTask { Id = 6, Title = "E-posta Kontrolü", Description = "Gelen kutusunu düzenle ve önemli mailleri yanıtla", IsCompleted = false, DueDate = new DateTime(2025, 11, 3) },
    new ToDoTask { Id = 7, Title = "Sunum Hazırla", Description = "Pazartesi toplantısı için PowerPoint sunumunu hazırla", IsCompleted = false, DueDate = new DateTime(2025, 11, 7) },
    new ToDoTask { Id = 8, Title = "Araç Bakımı", Description = "Yağ ve filtre değişimi yaptır", IsCompleted = false, DueDate = new DateTime(2025, 11, 10) },
    new ToDoTask { Id = 9, Title = "Arkadaşını Ara", Description = "Uzun zamandır konuşmadığın bir arkadaşını ara", IsCompleted = true, DueDate = new DateTime(2025, 10, 28) },
    new ToDoTask { Id = 10, Title = "Film İzle", Description = "Listendeki filmi izle ve notlarını al", IsCompleted = false, DueDate = new DateTime(2025, 11, 8) }

       );
    }
}
