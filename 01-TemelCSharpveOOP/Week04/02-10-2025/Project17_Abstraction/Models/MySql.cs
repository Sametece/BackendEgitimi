using System;

namespace Project17_Abstraction.Models;

public class MySql : Database
{
     public override void Add()
    {
        Console.WriteLine("MY-SQL Server ile Kayıt Ekleme işlemi tamamlandı.");
    }

    public override void Delete()
    {
        Console.WriteLine("My-SQL Server ile Kayıt Başarılı Şekilde silindi");
    }
}
