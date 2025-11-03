using System;
using Microsoft.EntityFrameworkCore;
using soru2.Data.Concrete.interfaces;
using soru2.Entity;

namespace soru2.Data.Concrete.EfCore;

public class DepartmenRepository : IDepartmentRepository
{
    private readonly CompanyContext _context;// Sadece ilk yaratıldığında ya da constructor içinde değer verilebilir!

    public DepartmenRepository(CompanyContext context)
    {
        _context = context;
    }

    public  void Add(Department department)
    {
        _context.Departments.Add(department);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var department = GetById(id);
        if(department != null)
        {
            _context.Departments.Remove(department);
            _context.SaveChanges();
        }
    }

    public IEnumerable<Department> GetAll()
    {
        var department = _context.Departments.AsNoTracking().ToList();

        return department;
    }

    public Department GetById(int id)
    {
        var department = _context.Departments.AsNoTracking()
                                 .Where(d => d.Id == id)
                                 .FirstOrDefault();
        return department!;
    }

    public void Update(Department department)
    {
        _context.Departments.Update(department);
        _context.SaveChanges();
    }
}
