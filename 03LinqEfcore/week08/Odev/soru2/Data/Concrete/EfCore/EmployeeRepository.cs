using System;
using Microsoft.EntityFrameworkCore;
using soru2.Data.Concrete.interfaces;
using soru2.Dto;
using soru2.Entity;

namespace soru2.Data.Concrete.EfCore;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly CompanyContext _context;

    public EmployeeRepository(CompanyContext context)
    {
        _context = context;
    }

    

    public void Add(Employee employee)
    {
        _context.Employees.Add(employee);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var employee = GetById(id);
        if(employee !=null)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }
    }

    public IEnumerable<Employee> GetAll()
    {
        var employee = _context.Employees
                               .AsNoTracking()
                               .ToList();
        return employee;
    }

    public Employee GetById(int id)
    {
        var employee = _context.Employees
                               .AsNoTracking()
                               .Where(e => e.Id == id)
                               .FirstOrDefault();
        return employee!;
    }

    public List<EmployeeDto> GetHighSalarySoftwareEmployees(decimal minSalary)
    {
          return _context.Employees
                 .AsNoTracking()
                .Include(e => e.Departments)
                .Where(e => e.Departments.Name == "Software" && e.Salary > minSalary)
                .Select(e => new EmployeeDto
                {
                    Id = e.Id,
                    FullName = e.FullName,
                    Position = e.Position
                })
                .ToList();
    }

    public void Update(Employee employee)
    {
        _context.Employees.Update(employee);
        _context.SaveChanges();
    }

  
}
