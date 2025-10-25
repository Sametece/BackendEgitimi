namespace Project11_Methods;

class Program
{
    static void Main(string[] args)
    {
        // ShowWelcome();
        // Console.WriteLine("Hello, World!");
        // ShowGoodBye();
        // ShowMessage("Hoş Geldiniz");
        // ShowMessage("Güle    Güle");
        // Message("Emir Can", "FULL STACK 2025");
        // Message("Murat", "BACKEND 2025");
        // Message(className: "11-C", name: "Sezin");
        // Message("11-C", "Sezin");
        // Message("Ahmet","10-A");
        // Sum1(40, 80);
        // Sum1(50, 40, 100);
        // Sum1(50, 40, 100, 400);

        // Sum2(10, 20);
        // Sum3(10, 20, 30);
        // Sum4(10, 20, 30, 40);
        // Sum5(10, 20, 30, 40, 50);

        // Sum(40, 80);
        // Sum(50, 40, 100);
        // Sum(50, 40, 100, 400);

        // double a = 45;
        // double b = 50;

        // Sum(a, b);

        // int c = 60;
        // int d = 70;
        // Sum(c, d);
        string resultMessage = GetMessage("Ali", "11-A");
        // string resultMessage = "Merhaba Ali, sen 11-A sınıfındasın. Başarılar!";
        Console.WriteLine(resultMessage);

        Console.WriteLine("Merhaba Ali, sen 11-A sınıfındasın. Başarılar!");

        

    }

    static string GetMessage(string name, string className)
    {
        string result = $"Merhaba {name}, sen {className} sınıfındasın. Başarılar!";
        return result;
    }





    // Method Overload
    static void Sum(double number1, double number2)
    {
        Console.WriteLine(number1 + number2);
    }

    static void Sum(int number1, int number2, int number3)
    {
        Console.WriteLine(number1 + number2 + number3);
    }

    static void Sum(int number1, int number2, int number3, int number4)
    {
        Console.WriteLine(number1 + number2 + number3 + number4);
    }

    static void Sum2(int number1, int number2)
    {
        Console.WriteLine(number1 + number2);
    }

    static void Sum3(int number1, int number2, int number3)
    {
        Console.WriteLine(number1 + number2 + number3);
    }

    static void Sum4(int number1, int number2, int number3, int number4)
    {
        Console.WriteLine(number1 + number2 + number3 + number4);
    }

    static void Sum5(int number1, int number2, int number3, int number4, int number5)
    {
        Console.WriteLine(number1 + number2 + number3 + number4 + number5);
    }

    static void Sum1(int number1, int number2, int number3 = 0, int number4 = 0)
    {
        Console.WriteLine(number1 + number2 + number3 + number4);
    }


    static void Message(string name, string className)
    {
        Console.WriteLine($"Merhaba {name}, {className} sınınıfına hoşgeldin");
    }

    static void ShowMessage(string message)
    {
        Console.WriteLine("************************************");
        Console.WriteLine($"**********  {message.ToUpper()}  **********");
        Console.WriteLine("************************************");
        Console.WriteLine();
        Console.WriteLine();
    }    

    static void ShowWelcome()
    {
        Console.WriteLine("************************************");
        Console.WriteLine("**********  HOŞ GELDİNİZ  **********");
        Console.WriteLine("************************************");
    }

    static void ShowGoodBye()
    {
        Console.WriteLine("************************************");
        Console.WriteLine("**********   GÜLE  GÜLE   **********");
        Console.WriteLine("************************************");
    }
}



// Metotların amacı nedir?
/*
    1) Tekrarı önlemek(Don't Repeat Yourself-DRY)
    2) Okunabilirlik
    3) Yönetilebilirlik
*/





