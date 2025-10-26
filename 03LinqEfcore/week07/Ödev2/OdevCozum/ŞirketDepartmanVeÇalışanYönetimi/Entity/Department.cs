using System;

namespace ŞirketDepartmanVeÇalışanYönetimi.Entity;

public class Department
{
    public int Id { get; set; }
    public string DepartmentName { get; set; } = string.Empty;

    public List<Employee> Employees { get; set; } = []; // Departmanda 1 den fazla Çalışan olabilir

}
