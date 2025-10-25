using System;

namespace Project17_Abstraction.Models;

public class SqlServer : Database
{
    public override void Add()
    {
        Console.WriteLine("SQL Server ile Kayıt Ekleme işlemi tamamlandı.");
    }

    public override void Delete()
    {
        Console.WriteLine("SQL Server ile Kayıt Başarılı Şekilde silindi");
    }
}
