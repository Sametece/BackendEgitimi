using System;
using soru2.Dto;
using soru2.Entity;

namespace soru2.Data.Concrete.interfaces;

public interface IEmployeeRepository
{
    Employee GetById(int id);
    IEnumerable<Employee> GetAll();

    void Add(Employee employee);

    void Update(Employee employee);

    void Delete(int id);

    List<EmployeeDto> GetHighSalarySoftwareEmployees(decimal minSalary); // Dto işlemi yapabilmemiz için
}
