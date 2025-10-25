using System;

namespace Project17_Abstraction.Models;

public class PostergreSql : Database
{
    public override void Add()
    {
        Console.WriteLine("Postegre-SQL Server ile Kayıt Ekleme işlemi tamamlandı.");
    }

    public override void Delete()
    {
        Console.WriteLine("Postegre -SQL Server ile Kayıt Başarılı Şekilde silindi");
    }
}
