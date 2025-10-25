using System;

namespace Project15_inheritance.Models;

/*
    - Manager sınıfı, Employe sınıfından miras alıyor.
    - Employe sınıfı, Manager sınıfına tüm özellik ve davranışlarını devrediyor, miras veriyor.
    - Manager sınıfı, Employe sınıfndan türetilmiştir.
    - Her Manager, aynı zamanda bir Employe'dur.
*/
public class Manager : Employe
{
    public string Department { get; set; } = string.Empty;
    public void SetMeeting()
    {
        Console.WriteLine($"{FirstName} {LastName} adlı {Department} departmanının yöneticisi bir toplantı düzenliyor...");
    }

}
