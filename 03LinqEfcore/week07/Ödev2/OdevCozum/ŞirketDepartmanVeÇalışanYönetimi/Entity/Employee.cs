using System;

namespace ŞirketDepartmanVeÇalışanYönetimi.Entity;

public class Employee
{
   public int Id { get; set; }

    public string FullName { get; set; } = string.Empty;

    public string position { get; set; } = string.Empty;

    public int Salary { get; set; }

    public int DepartmentId { get; set; }  //Foreign Key
    public  Department? Department {get; set;} // Her çalışanın 1 tane Departmanı olur.
}
