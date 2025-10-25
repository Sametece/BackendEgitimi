using Project15_inheritance.Models;

namespace Project15_inheritance;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        // Manager manager1 = new()
        // {
        //     RegNumber = 213,
        //     FirstName = "samet",
        //     LastName = "ece"
        // };
        // manager1.Departman = "satış";
        // manager1.ShowData();
        // manager1.SetMeeting();

        Developer developer1 = new()
        {
            FirstName = "samet",
            LastName = "ece",
            Langu = "sql",
            RegNumber = 123
        };
        developer1.ShowData();
        developer1.WriteCode();
    }
}
