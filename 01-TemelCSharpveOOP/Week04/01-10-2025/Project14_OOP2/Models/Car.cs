namespace Project14_OOP2.Models;

public class Car
{
    public string Brand { get; set; } = string.Empty;

    public string Models { get; set; } = string.Empty;

    public int YearOfProduction { get; set; }

    public double CurrentSpeed { get; set; }

    public void SpeedUp(double increase)
    {
        CurrentSpeed += increase;
        Console.WriteLine($"{Brand} {Models} Hızlanıyor. Yeni Hızı : {CurrentSpeed} km/h");
    }

    public void SlowDown(double decrease)
    {
        if (decrease > 0)
        {
            if ((CurrentSpeed - decrease) >= 0)

            {
                CurrentSpeed -= decrease;

            }
            else
            {
                CurrentSpeed = 0;
            }
            if (CurrentSpeed == 0)
            {
                Console.WriteLine($"{Brand} {Models} Durdu. ");
            }
            else
            {
                Console.WriteLine($"{Brand} {Models} Yavaşlıyor. Yeni Hızı : {CurrentSpeed} km/h");
            }

        }


    }
}