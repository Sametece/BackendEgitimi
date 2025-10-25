using System;

namespace Project16_Polymorphism.Models;

public class Altıgen:Sekil
{
    public override void Ciz()
    {
        Console.WriteLine("************************");
        base.Ciz();
        Console.WriteLine("Bir altıgen çiziliyor...");
    }
}
