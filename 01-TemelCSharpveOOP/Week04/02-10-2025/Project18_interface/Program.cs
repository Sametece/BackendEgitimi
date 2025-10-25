namespace Project18_interface;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

//Polymorphissm : Bir base class(miras veren class) içerisindeki kimi metotların miras alan gövedsinin classlar da değiştirmesine izin vermek isteyebeilir. Bunu sağlayan yapı ilgili metodu base class içinde "virtual" ile işareledikten sonra , miras alan class içinde override etmektir.

//abstraction : bir bsae class içersindeki kimi metotlaın gövdesini yaazmayıp derived classlarda yazılmasını isteyebilir. Bunun için base class içinde iligili metodun sadece imzası yazılır. ve abstract sözcüğü ile işaretlenir.Derived classta ise ilgili metot override edilmek Zorundadır.

//Interface = ne Polymorphism de oldugu gibi bazı metotlara overridwe imkanı vermek ne de abstraction daki olduğu gibi kimi metotların override edilmesini zorunlu kılmak istiyorum.Bunun yerine tüm metotların gövdesini derived classlarda yazılmasını zorunlu kılmak istiyorum.