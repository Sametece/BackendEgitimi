namespace Project12_Debugging;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Sayı gir : ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine(number * 2);

        // Console.WriteLine("çıkmak için enter ..");
        // Console.ReadLine(); // terminalin açık kalmasını sağlar

        // dotnet build = run yapmadan derleme işlemi yapar.

        // Console.Write("Bölünen : ");
        // int number1 = Convert.ToInt32(Console.ReadLine());
        // Console.Write("bölen : ");
        // int number2 = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine($"{number1}/{number2} = {number1 / number2}");
        // Console.Write("çıkmak için enter");
        // Console.ReadLine();

        try
        {
            Console.Write("Bölünen : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("bölen : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{number1}/{number2} = {number1 / number2}");
            Console.Write("çıkmak için enter");
            Console.ReadLine();
        }
        // catch (System.Exception)  
        // {
        //     Console.WriteLine("Hatalı giriş");

        // }
        catch (DivideByZeroException)  //0 a bölünme 
        {
            Console.WriteLine("0 ' a bölünmez değer");

        }
        
    }
}

// try
//         {
//             // hata verme ihtimali olan kodlarımızı buraya yazarızz. eğer hata yoksa çalışır var catch bloğuna atar.
//         }
//         catch (Exception)
//         {
//             // try bloğunda herhangi bir hata meydana gelirse buradaki kodlar çalışır

//             throw;
//         }