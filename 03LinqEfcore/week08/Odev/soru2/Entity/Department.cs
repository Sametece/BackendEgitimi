using System;
using Microsoft.EntityFrameworkCore;

namespace soru2.Entity;

public class Department
{
   public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    //Navi Prop
    // Departmanda 1 den fazla çalışan olabilir
    public List<Employee> Employees { get; set; } = [];
}
