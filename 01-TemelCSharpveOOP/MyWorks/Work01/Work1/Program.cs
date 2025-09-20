namespace Work1;

class Program
{
    static void Main(string[] args)
    {
        // // Örnek 1 : Ekrana “Merhaba Dünya” yazdırın. 

        // #region  

        //  Console.Write("Merhaba Dünya");

        //  #endregion

        // Örnek 2 : Ekrana “Merhaba Dünya” yazdırın.İmleç Alt Satıra Geçsin.

        //  #region  

        //  Console.WriteLine("Merhaba Dünya");

        //  #endregion

        // sehir adında bir string tutun . sonra şehriniz istanbul olsun. ekrana yaz.

        //  #region  string ifadeler karekerler için

        //  string city = "İstanbul ";
        //  Console.WriteLine("Şehriniz : " + city);

        //  #endregion

        // yas adında bir int tutun . sonra yaşınız 51 olsun. ekrana yaz.

        // #region int ifadesel sayısal  tam değerler için kullanılır.

        // int age = 51;
        // Console.WriteLine("Yaşınız : " + age);

        // #endregion


        //number adında bir double tutunuz. Sonra değeriniz 5.58 olsun .  ekrana yaz

        // #region double ifadesi sayısal ondalıklı değeler için kullanılır.

        // double number = 5.58;
        // Console.WriteLine("Tutulan Sayı : " + number);

        //  #endregion

        //  symbol adında bir char fonksiyonunu tutunuz. Karekterimiz $ olsun. ekrana yaz.

        //  #region char tek harf aldığımız zaman kullanılır.

        //  char symbol = '$';
        //  Console.WriteLine("Karekterimiz : " + symbol);

        //   #endregion

        // klavyeden girilen sayı çift ise True Tek ise False Yaz.
        // #region bool fonksiyonun 2 tercih vardır aktif - pasif , doğru-yanlış gibi

        // int number;
        // Console.Write("Sayı Girin :");
        // number = int.Parse(Console.ReadLine());

        // bool sonuc = number % 2 == 0;

        // Console.WriteLine( sonuc);

        // #endregion

        //Klavyeden adınızı soyadınız girin ve bilgilerinizi ekrana yaz

        //  #region 

        //  string name, surname;
        //  Console.Write("Lütfen Adınızı Girin : ");
        //  name = Console.ReadLine();

        //  Console.Write("Lütfen Soyadınızı Girin : ");
        //  surname = Console.ReadLine();

        //  Console.WriteLine("Adınız : " + name + " " + "Soyadınız : " + surname);

        //    #endregion

        // Klavyeden girilen yas bilgilerini yaz

        //  #region 
        //  int age;
        //  Console.Write("Yaşınızı Girin :");
        //  age = int.Parse(Console.ReadLine());

        //  Console.WriteLine("Yaşınız : " + age);
        //  #endregion

        // 56 - 60 sayılarını stringe karektere çevir 

        // #region  Dönüşümler Stringe Dönüştürme 
        // int a = 56;
        // int b = 60;
        // string c = a.ToString() + b.ToString();
        // Console.WriteLine(c);  // sayıları karektere stringe çeviriyor

        //   #endregion

        // int türündeki a değişkenin değeri 255 olsun. bu değişkenin türünü byte yapın.
        // #region 

        // int a = 255;
        // byte b = Convert.ToByte(a);
        // Console.Write("Karakter : " + a);

        // #endregion


        //Bir sınıfta 2 tane sınav olmaktadır. sınav notları ondalıklıdır. klavyeden notları girerek ortalamasını hesaplattırınız.

        //  #region 

        //  double exam1, exam2, avg;
        //  Console.Write("1. Sınav : ");
        //  exam1 = double.Parse(Console.ReadLine());

        //  Console.Write("2. Sınav : ");
        //  exam2 = double.Parse(Console.ReadLine());

        //  avg = (exam1 + exam2) / 2;
        //  Console.WriteLine("Ortalamaniz : " + avg);

        // #endregion


        // Klavyeden Tek harf girerek cinsiyet belirleyen kodu yazın .
        // #region 

        // / char genser = 'E' ;
        //  Console.Write("Cinsiyeti Tek Harfle Belirtin : E/K ");
        //  gender = char.Parse(Console.ReadLine());

        //  Console.WriteLine("Girilen Cinsiyet : " + gender);


        //  #endregion

        // a = 101 b= 40  (c= a+b) (d = a - b) (e = a * b) (f=a-/b) (g= a%b) 
        //  şeklinde değerlerinizi tanımlayınız ve ekran çıktısını verin.
        //     #region 

        //     // Operatörler  Aritmetik Operatörler 
        //     // +, -, *, /, %, +=, -=, *=, /=

        //     int a = 101;
        //     int b = 40;
        //     int c = a + b;
        //     int d = a - b;
        //     int e = a * b;
        //     decimal f = Convert.ToDecimal(a) / b;
        //     int g = a % b;
        //     Console.WriteLine("Toplam: " + c);
        //     Console.WriteLine("Fark: " + d);
        //     Console.WriteLine("Çarpım: " + e);
        //     Console.WriteLine("Bölüm: " + f);
        //     Console.WriteLine("Mod: " + g);

        //    #endregion


        //     #region aritmetik operatörler 2

        //     int number1 = 10;
        //      number1 = number1 + 20;
        //     number1 += 20; // 30
        //      number1 *= 2;  // 60
        //      number1 -= 5;  // 55
        //      number1 /= 5;  // 11
        //     Console.WriteLine(number1);

        // #endregion

        /* a = 13 b = 12   sırasıyla 
            a == b   a != b
            a > b    a < b
           a >= b     a <= b  ekrana yazdırın */

        // #region  Karşılaştırma operatörleri 

        // int a = 13;
        // int b = 12;
        // Console.WriteLine(a == b);
        //  Console.WriteLine(a != b);
        //  Console.WriteLine(a > b);
        // Console.WriteLine(a < b);
        // Console.WriteLine(a >= b);
        // Console.WriteLine(a <= b);

        // #endregion

        // ehliyet kursu programı olsun . klavyeden kullanıcı yaşını girsin 18 yaşından küçükse ehliyet alamasın 

        //     #region karşılaştırma operatörüne örnek bir soru 

        //     Console.Write("Yaşınızı Giriniz: ");
        //     int age = Convert.ToInt32(Console.ReadLine());
        //     bool isStatus = age >= 18;
        //     Console.WriteLine("Bu kullanıcı ehliyet alabilir mi?: " + (isStatus ? "Evet" : "Hayır"));

        //   #endregion

        /*
            int türünde a ve b değişkenleri tanımla değerleri a= 10 b =12 olsun Sırasıyla : 
             a == 10 && a > b
              a < b && b == 12
             a < 5 || b == 12
             a < 5 || b == a || 5 == 4
             !(a == b)) ifadelerini ekrana yazdırsın .

        */

        // #region Mantık Operatörleri 

        // int a = 10;
        //  int b = 12;
        //  Console.WriteLine(a == 10 && a > b);  // True AND False = False
        //  Console.WriteLine(a < b && b == 12);  // True AND True = True
        //  Console.WriteLine(a < 5 || b == 12);  // False OR True = True
        //  Console.WriteLine(a < 5 || b == a || 5 == 4); // False OR False OR False
        //  Console.WriteLine(!(a == b));


        // #endregion


        // #region 

        // string text1 = "Nişantaşı";
        // string text2 = "Üniversitesi";
        // string oldLocation = "Bayrampaşa";
        // string currentLocation = "Sarıyer";
        // string date1 = "09.09.2009";
        // string date2 = "05.05.2018";

        // // Hedef: Nişantaşı Üniversitesi, 09.09.2009 tarihinde İstanbul'un Bayrampaşa ilçesinde faaliyetlerine başlamıştır. Ardından 05.05.2018 tarihinde yine İstanbul'un Sarıyer ilçesinde kurulan TechCampus'e taşınmıştır.

        // string result3 = $"{text1} {text2}, {date1} tarihinde İstanbul'un {oldLocation} ilçesinde faaliyetlerine başlamıştır. Ardından {date2} tarihinde yine İstanbul'un {currentLocation} ilçesinde kurulan TechCampus'e taşınmıştır.";
        // Console.WriteLine(result3);
        // #endregion


        //kullanıcı yaşını girsin. eğer yaşı 18 den büyük ise ehliyet alabilsin değilse ehliyet alamazsın yazsın ekranda.

        //     #region 

        //     int age,deger;
        //     Console.WriteLine("--- Ehliyet Alma Programı ---");

        //     Console.Write("Yaşınızı giriniz : ");
        //     age = int.Parse(Console.ReadLine());
        //     deger = 18 - age;
        //     if (age >= 18)
        //     {
        //         Console.WriteLine("Tebrikler Ehliyet Alabilirsiniz.");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Maalesef Ehliyet için " + deger + " yaş beklemelisiniz.");
        //     }

        //    #endregion

        /* kullanıcıdan 0–100 arası bir not girmesi istenmektedir. Girilen nota göre öğrencinin harf notu belirlenmektedir.
          studentPoint >= 80 A-Pekiyi
          studentPoint >= 60 B-İyi
          studentPoint >= 40 C-Orta
          studentPoint >= 20 D-Geçer
          E-Zayıf
          Şekilnde çıktı alabileceğimiz programın kodunu yazın. */

        // #region 

        // int studentPoint;

        // Console.WriteLine("*** Öğrenci Harf Not Sistemi ***");

        // Console.Write("Lütfen Puanınızı Girin : ");
        // studentPoint = int.Parse(Console.ReadLine());

        // if (studentPoint >= 80)
        // {
        //     Console.WriteLine("Harf Notunuz : A-Pekiyi " + studentPoint);
        // }
        // else if (studentPoint >= 60)
        // {
        //     Console.WriteLine("Harf Notunuz : B-İyi " + studentPoint);
        // }
        // else if (studentPoint >= 40)
        // {
        //     Console.WriteLine("Harf Notunuz : C-Orta " + studentPoint);
        // }
        // else
        // {
        //     Console.WriteLine("Harf Notunuz : D-Geçer " + studentPoint);
        // }

        //  #endregion


        /*  Kullanıcı Tek Harfle p-g-s harfiyele mağazadan statüsüne göre %kaç indirim kazanacağını görsün.
             P=%50   G=%30  S=%10 
              */

        // #region  Switch Case Break;

        // char customerType;
        // Console.WriteLine("E- Mağazamıza Hoşgeldiniz");

        // Console.Write("Lütfen Statünüzü Tek Haf İle Belirtiniz : ");
        // customerType = char.Parse(Console.ReadLine());

        // switch (customerType)
        // {
        //     case 'P':
        //         Console.WriteLine("Hoşgeldiniz Premium %50 İndirim.");
        //         break;
        //     case 'G':
        //         Console.WriteLine("Hoşgeldinizi Gold %30 İndirim.");
        //         break;
        //     default:
        //         Console.WriteLine("Hoşgeldinizi standart %10 İndirim ");
        //         break;    
        // }


        // #endregion

        // Ternary If
        // #region 

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

        //  #endregion

        // Ekrana 10 ‘na Kadar Artan sayıları Teker teker yazan programı kodunu yazın.

        // #region 

        // int i;
        // for (i = 1; i<10; i++)
        // {
        //     Console.WriteLine("Sayılar : " + i);
        // }

        // #endregion


        // 5000 TL'lik anaparayı yıllık %20 faizle yıl boyu işletelim, 5 yıllık durumu görelim

        //     #region for döngüsü
        //    decimal anaPara = 5000m;
        //     decimal faizOrani = 0.20m;

        //      Console.WriteLine($"Başlangıç Anapara = {anaPara} TL");

        //     for (int yil = 1; yil <= 5; yil++)
        //     {
        //          anaPara += anaPara * faizOrani;
        //          Console.WriteLine($"{yil}.Yıl Sonu Bakiye: {anaPara} TL");
        //          Console.WriteLine(yil + ".Yıl Sonu Bakiye: " + anaPara + " TL");
        //      }

        //    #endregion

    //     #region  While Döngüsü
    //  int bakiye = 1000;
    //     int cekilecekMiktar = 0;

    //     while (bakiye > 0)
    //     {
    //         Console.Write($"Mevcut Bakiyeniz: {bakiye} TL. Çekmek istediğiniz tutarı girin(Çıkmak için 0 girin): ");
    //         cekilecekMiktar = Convert.ToInt32(Console.ReadLine());
    //         if (cekilecekMiktar == 0)
    //         {
    //             Console.WriteLine("İşlem sonlandırıldı!");
    //             break; // döngüyü sonlandır, yani while bloğunun alt satırına geç
    //         }
            
    //         if (cekilecekMiktar > bakiye)
    //         {
    //             Console.WriteLine("Yetersiz bakiye! Daha küçük bir değer girin!");
    //             continue; // Döngüye devam et, yani while satırına geç
    //         }
    //         bakiye -= cekilecekMiktar;
    //         Console.WriteLine($"Para çekildi. Kalan Bakiye: {bakiye} TL");
    //     }

    //     Console.WriteLine("Uygulama sona erdi!");
    
    // #endregion




























    }
}
