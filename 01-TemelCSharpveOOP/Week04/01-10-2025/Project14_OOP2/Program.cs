namespace Project14_OOP2;

using Project14_OOP2.Models;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //Project14_OOP2.Models.Car car1 = new();

        // Car car1 = new(); //Car car1 = new Car() aynı işi yapıyor.

        // car1.Brand = "Bmw";
        // car1.Models = "3.20i";
        // car1.CurrentSpeed = 198;
        // car1.YearOfProduction = 2014;

        Car car1 = new() // rahat format 
        {
            Brand = "Bmw",
            Models = "3.20i",
            CurrentSpeed = 198,
            YearOfProduction = 2014

        };

        car1.SpeedUp(24);
        car1.SlowDown(100);
         car1.SlowDown(50);
        car1.SlowDown(-5);
    }
}
