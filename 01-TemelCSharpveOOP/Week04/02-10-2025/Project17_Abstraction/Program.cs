using Project17_Abstraction.Models;

namespace Project17_Abstraction;

class Program
{
    static void Main(string[] args)
    {
        SqlServer sqlServer1 = new SqlServer();
        sqlServer1.Add();
        sqlServer1.Delete();

        Console.WriteLine("*********");

        MySql mySql1 = new MySql();
        mySql1.Add();
        mySql1.Delete();
        Console.WriteLine("*********");

        PostergreSql postergreSql1 = new PostergreSql();
        postergreSql1.Add();
        postergreSql1.Delete();
        Console.WriteLine("*********");

        Database database1 = new SqlServer();
        database1.Add();
        Database database2 = new MySql();
        database2.Add();
    }
}
