using System;

namespace soru2.Entity;

public class Employee
{
  public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;

    public string Position { get; set; } = string.Empty;

    public decimal Salary { get; set; }

    //Navi
    // 1 çalışanın 1 derpartmanı olabilir 

    public int DepartmentId { get; set; } // foreign key

    public Department? Departments { get; set; }

}
