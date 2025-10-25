namespace Project13_OOP_Basic;

class Program
{
    static void Main(string[] args)
    {
   //int a = 5; // camelCase sosyalGuvenlikNumarasi
        //Console.WriteLine("Hello, World!");
        Araba araba1 = new Araba();
        araba1.Marka = "BMW";
        araba1.ModelYili = 2015;
        Console.WriteLine(araba1.Marka);
        Console.WriteLine(araba1.ModelYili);


        // araba1.MarkayaDegerAta("Opel");
        // Console.WriteLine(araba1.MarkayiGetir());
        // araba1.ModelYilinaDegerAta(-34);
        // Console.WriteLine(araba1.ModelYiliniGetir());

        // araba1.marka = "Opel";
        // araba1.modelYili = 1999;
        // Console.WriteLine(araba1.marka);
        // Console.WriteLine(araba1.modelYili);
    }
}

class Araba
{
    public string? Marka { get; set; }
    public int ModelYili { get; set; }
}

// class Araba
// {
//     //propfull snippet
//     private string marka;
//     public string Marka
//     {
//         get { return marka; }
//         set { marka = value; }
//     }
    

//     private int modelYili;
//     public int ModelYili
//     {
//         get { return modelYili; }
//         set { modelYili = value; }
//     }
    
// }


// class Araba
// {
//     private string marka = string.Empty; // Field-Alan
//     public string Marka // Property-Özellik
//     {
//         get
//         {
//             return marka[0] == 'A' ? marka : "HATA";
//         }
//         set
//         {
//             marka = value.ToUpper();
//         }
//     }


//     private int modelYili;
//     public int ModelYili
//     {
//         get
//         {
//             return modelYili;
//         }
//         set
//         {
//             if (value >= 1900)
//             {
//                 modelYili = value;
//             }
//             else
//             {
//                 modelYili = 2000;
//             }

//         }
//     }

// }


// Nesne Yönelimli Programlama-NYP-NOP
// Object Oriented Programming-OOP
// Class(Sınıf) - Object(Nesne)


