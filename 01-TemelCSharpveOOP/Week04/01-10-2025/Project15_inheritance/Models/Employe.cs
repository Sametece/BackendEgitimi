using System;

namespace Project15_inheritance.Models;

public class Employe
{
      public int RegNumber { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public void ShowData()
    {
        Console.WriteLine("*****************************************");
        Console.WriteLine($"Sicil No: {RegNumber}");
        Console.WriteLine($"Ad Soyad: {FirstName} {LastName}");
        Console.WriteLine("*****************************************");
    }
}
