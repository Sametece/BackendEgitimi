using System;

namespace Project17_Abstraction.Models;

public abstract class Database
{
    public void Connect()
    {
        Console.WriteLine("Veritabanı bağlantısı sağlandı.");
    }

    public abstract void Add();
    public abstract void Delete();
  

}
