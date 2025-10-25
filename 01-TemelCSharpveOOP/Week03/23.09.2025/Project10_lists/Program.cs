namespace Project10_lists;

class Program
{
    static void Main(string[] args)
    {
        //List<int> numbers = []; // listenin içindeint türleri barınıyor.

        List<int> numbers = [];

        numbers.Add(56); // ilk ekledğimiz eleman indexi 0 dır.
        numbers.Add(58); // indexi 1
        numbers.Add(99);
        numbers.Add(949);
        numbers.Add(298);
        numbers.Add(763);

        // for (int i = 0; i < numbers.Count; i++)
        // {
        //     Console.WriteLine(numbers[i]);

        // }

        foreach (int number in numbers)
        {
            Console.WriteLine($"{number} ====> {number}/2 ={number / 2}");
        }
        // numbers listesindeki sadece çift sayı olanları ekrana yazalım.
    }
}
