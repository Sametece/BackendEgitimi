namespace Project07_Conditions;

class Program
{
    static void Main(string[] args)
    {
         // Console.Write("Yaşınızı giriniz: ");
        // int age = Convert.ToInt32(Console.ReadLine());

        // if (age >= 18)
        // {
        //     Console.WriteLine("Tebrikler! Ehliyet alabilirsiniz!");
        // }
        // else
        // {
        //     int resultYear = 18 - age;
        //     Console.WriteLine($"Üzgünüz! Ehliyet almak için yaşınız uygun değil! {resultYear} sonra ehliyet alabilirsiniz!");
        // }

        // Console.Write("Bir not giriniz(0-100): ");
        // int studentPoint = Convert.ToInt32(Console.ReadLine());

        // if (studentPoint >= 80)
        // {
        //     Console.WriteLine("Harf Notu: A-Pekiyi");
        // }
        // else if (studentPoint >= 60)
        // {
        //     Console.WriteLine("Harf Notu: B-İyi");
        // }
        // else if (studentPoint >= 40)
        // {
        //     Console.WriteLine("Harf Notu: C-Orta");
        // }
        // else if (studentPoint >= 20)
        // {
        //     Console.WriteLine("Harf Notu: D-Geçer");
        // }
        // else
        // {
        //     Console.WriteLine("Harf Notu: E-Zayıf");
        // }

        // char customerType = 'P'; // P: Premium G: Gold S: Standart
        // switch (customerType)
        // {
        //     case 'P':
        //         Console.WriteLine("Hoş geldiniz, Premium Müşterimiz! Size özel %50 indiriminiz var!");
        //         break;
        //     case 'G':
        //         Console.WriteLine("Hoş geldiniz, Gold Müşterimiz! Size özel %30 indiriminiz var!");
        //         break;
        //     default:
        //         Console.WriteLine("Hoş geldiniz, Standart Müşterimiz! Size özel %10 indiriminiz var!");
        //         break;
        // }


        // if (customerType == 'P')
        // {
        //     Console.WriteLine("Hoş geldiniz, Premium Müşteirmiz. Size özel %50 indiriminiz var!");
        // }
        // else if (customerType == 'G')
        // {
        //     Console.WriteLine("Hoş geldiniz, Gold Müşteirmiz. Size özel %30 indiriminiz var!");
        // }
        // else
        // {
        //     Console.WriteLine("Hoş geldiniz, Standart Müşteirmiz. Size özel %10 indiriminiz var!");
        // }

        // Ternary If
        // string password = "Qwe123";
        // Console.Write("Şifrenizi giriniz: ");
        // string inputPassword = Console.ReadLine();
        // string message = inputPassword == password ? "Başarılı giriş!" : "Başarısız giriş!";
        // /*  Eğer inputPassword==pasword true ise 
        //         string message = "Başarılı giriş"; yazmış sayılırsınız.
        //     Eğer inputPassword==pasword false ise 
        //         string message = "Başarısız giriş"; yazmış sayılırsınız.
        // */
        // Console.WriteLine(message);

        char customerType = 'S'; // P: Premium G: Gold S: Standart
        // string message = customerType == 'P' ? "Premium, %50" : customerType == 'G' ? "Gold, %30" : "Standart, %10";
        string message =
            customerType == 'P' ?
                "Premium, %50" :
                customerType == 'G' ?
                    "Gold, %30" :
                    "Standart, %10";
        Console.WriteLine(message);






        
    }
}
/*  NOT

        if (inputPassword == password)
        {
            message ="Başarılı Giriş";

        }
        else
        {
            message ="giriş başarısız";
        }*/