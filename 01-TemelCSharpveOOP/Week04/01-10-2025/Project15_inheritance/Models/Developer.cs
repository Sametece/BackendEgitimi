using System;
using Project15_inheritance.Models;

namespace Project15_inheritance;

public class Developer : Employe
{

    public string Lang { get; set; } = string.Empty;

    public string Langu { get; set; } = "C#";
    public void WriteCode()
    {
        Console.WriteLine($"{FirstName} {LastName} {Langu} dili ile kod yazmaya başladı...");
    }
}
