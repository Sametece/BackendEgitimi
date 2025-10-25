using System.Drawing;

namespace Project09_Arrays;

class Program
{
    static void Main(string[] args)
    {
        // Dizi : Aynı tipteki elemanları ieren sabit boyutlu bir koleksiyon.
        // ilk elemanı 0 olarak kabul et.

        // string[] days = new string[7];
        // days[0] = "Pazartesi";
        // days[1] = "Salı";
        // days[2] = "Çarşamba";
        // days[3] = "Perşembe";
        // days[4] = "Cuma";
        // days[5] = "Cumartesi";
        // days[6] = "Pazar";

        // // Console.WriteLine(days[0]);
        // // Console.WriteLine(days[1]);
        // // Console.WriteLine(days[2]);

        // // döndülerden yararlanın.

        // //    for (int i = 0; i < 7; i++)
        // //    {
        // //     Console.WriteLine(days[i]);
        // //    }

        // // var ifadesi otomatik tip belirliyor(string)
        // foreach (string item in days) // yukarıdaki for öngüsüyle aynı işi yapıyor 
        // {
        //     Console.WriteLine(item);
        // }

        // int[] points = { 45, 67, 98, 48, 86 };
        int[] points = [45, 67, 98, 48, 86];
        // int[] numbers = [7]; // u tanımlamayuı içerisinde eleman yazmadan sadece eleman sayısını söylerek yapabilirmiyiz ? nasıl ?

        points[4] = 56;
        Console.WriteLine(points[4]); //56

        // int itemCount = points.Length;
        // Console.WriteLine("eleman sayısı : " + itemCount); // değişken sayısını bulma 

        for (int i = 0; i < points.Length; i++)
        {
            Console.WriteLine(points[i] * 2); // dizinin elemanlarını 2 ile çarp
        }
          
       

    }
}
