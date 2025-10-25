using Project16_Polymorphism.Models;

namespace Project16_Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        Kare kare1 = new Kare();
        Kare kare2 = new Kare();
        Kare kare3 = new Kare();
        Kare kare4 = new Kare();
        daire daire1 = new daire();
        daire daire2 = new daire();
        ucgen ucgen1 = new ucgen();
        ucgen ucgen2 = new ucgen();
        ucgen ucgen3 = new ucgen();
        Altıgen altıgen1 = new Altıgen();

        List<Sekil> sekiller = [kare1, kare2, kare3, kare4, ucgen1, ucgen2, ucgen3, daire1, daire2, altıgen1];
        foreach (Sekil sekil in sekiller)
        {
            sekil.Ciz();
        }
    } 
}



// Console.WriteLine("Hello, World!");

        // Kare kare1 = new();

        // daire daire1 = new();

        // ucgen ucgen1 = new();

        // Altıgen altıgen1 = new();

        // kare1.ciz();
        // ucgen1.ciz();
        // daire1.ciz();
        // altıgen1.ciz();