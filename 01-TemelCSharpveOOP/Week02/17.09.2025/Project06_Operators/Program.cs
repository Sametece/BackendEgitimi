namespace Project06_Operators;

class Program
{
    static void Main(string[] args)
    {
        // Aritmetik Operatörler
        // +, -, *, /, %, +=, -=, *=, /=
        // int a = 101;
        // int b = 40;
        // int c = a + b;
        // int d = a - b;
        // int e = a * b;
        // decimal f = Convert.ToDecimal(a) / b;
        // int g = a % b;
        // Console.WriteLine("Toplam: " + c); // Shift+Option+Aşağı Ok / Shift+Alt+Aşağı Ok
        // Console.WriteLine("Fark: " + d);
        // Console.WriteLine("Çarpım: " + e);
        // Console.WriteLine("Bölüm: " + f);
        // Console.WriteLine("Mod: " + g);


        // int number1 = 10;
        // // number1 = number1 + 20;
        // number1 += 20; // 30
        // number1 *= 2;  // 60
        // number1 -= 5;  // 55
        // number1 /= 5;  // 11
        // Console.WriteLine(number1);

        // int i = 10;
        // i = i + 1;
        // i += 1;
        // i++; // i = i + 1
        //      // Eğer ++ operatörü bir değişkenin sağında yazıyorsa bu "Önce kullan, sonra arttır" demektir.
        //      // Solunda yazıyorsa bu "Önce arttrır, sonra kullan" demektir.
        // Console.WriteLine(i++);
        // Console.WriteLine(i);
        // Console.WriteLine(++i);
        // a--


        // int a = 20;
        // // int b = a++ - 15 + a + a++ - a++ - 3 + ++a - 12;
        // int b = a++;
        // Console.WriteLine(a + "-" + b);
        // b -= 15;
        // Console.WriteLine(a + "-" + b);
        // b += a;
        // Console.WriteLine(a + "-" + b);
        // b += a++;
        // Console.WriteLine(a + "-" + b);
        // b -= a++;
        // Console.WriteLine(a + "-" + b);
        // b -= 3;
        // Console.WriteLine(a + "-" + b);
        // b += ++a;
        // Console.WriteLine(a + "-" + b);
        // b -= 12;
        // Console.WriteLine(a + "-" + b);
        // /*
        //     T: 5.   a:21
        //     T: 26.  a:21
        //     T: 47.  a:22
        //     T: 25.  a:23
        //     T: 22.  a:23
        //     T: 46.  a:24
        //     T: 34.  a:24
        // */
        // Console.WriteLine(b);
        // Console.WriteLine(a);

        // Karşılaştırma Operatörleri
        // Eşitlik      : ==
        // Büyüktür     : >
        // Küçüktür     : <
        // Büyük Eşittir: >=
        // Küçük Eşittir: <=
        // Farklı(Eşit Değildir) : !=
        // int a = 13;
        // int b = 12;
        // Console.WriteLine(a == b);
        // Console.WriteLine(a != b);
        // Console.WriteLine(a > b);
        // Console.WriteLine(a < b);
        // Console.WriteLine(a >= b);
        // Console.WriteLine(a <= b);

        // Console.Write("Yaşınızı Giriniz: ");
        // int age = Convert.ToInt32(Console.ReadLine());
        // bool isStatus = age >= 18;
        // Console.WriteLine("Bu kullanıcı ehliyet alabilir mi?: " + (isStatus ? "Evet" : "Hayır" ));

        // Mantıksal Operatörler
        // AND  : &&
        // OR   : ||
        // DEĞİL: !

        // int a = 10;
        // int b = 12;
        // // Console.WriteLine(a == 10 && a > b);  // True AND False = False
        // // Console.WriteLine(a < b && b == 12);  // True AND True = True
        // // Console.WriteLine(a < 5 || b == 12);  // False OR True = True
        // // Console.WriteLine(a < 5 || b == a || 5 == 4); // False OR False OR False
        // Console.WriteLine(!(a == b));


        // // String Interpolation
        // string text1 = "Nişantaşı";
        // string text2 = "Üniversitesi";
        // string oldLocation = "Bayrampaşa";
        // string currentLocation = "Sarıyer";
        // string date1 = "09.09.2009";
        // string date2 = "05.05.2018";
        // // Hedef: Nişantaşı Üniversitesi, 09.09.2009 tarihinde İstanbul'un Bayrampaşa ilçesinde faaliyetlerine başlamıştır. Ardından 05.05.2018 tarihinde yine İstanbul'un Sarıyer ilçesinde kurulan TechCampus'e taşınmıştır.

        // // Çözüm1:
        // string result = text1 + " " + text2 + ", " + date1 + " tarihinde İstanbul'un " + oldLocation + " ilçesinde faaliyetlerine başlamıştır. Ardından " + date2 + " tarihinde yine İstanbul'un " + currentLocation + " ilçesinde kurulan TechCampus'e taşınmıştır.";

        // // Çözüm2: 
        // string result2 = String.Concat(text1, " ", text2, ", ", date1, " tarihinde İstanbul'un ", oldLocation, " ilçesinde faaliyetlerine başlamıştır. Ardından ", date2, " tarihinde yine İstanbul'un ", currentLocation, " ilçesinde kurulan TechCampus'e taşınmıştır.");

        // // Çözüm3:  String Interpolation
        // string result3 = $"{text1} {text2}, {date1} tarihinde İstanbul'un {oldLocation} ilçesinde faaliyetlerine başlamıştır. Ardından {date2} tarihinde yine İstanbul'un {currentLocation} ilçesinde kurulan TechCampus'e taşınmıştır.";

        // int a = 532;
        // int b = 2136;
        // string result4 = $"a + b = {a+b}";

        // // Console.WriteLine(result);
        // // Console.WriteLine(result2);
        // // Console.WriteLine(result3);
        // Console.WriteLine(result4);


        
     }
    }
