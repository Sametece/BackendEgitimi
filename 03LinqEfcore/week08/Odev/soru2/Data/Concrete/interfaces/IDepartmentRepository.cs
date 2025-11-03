using System;
using soru2.Entity;

namespace soru2.Data.Concrete.interfaces;

public interface IDepartmentRepository
{

Department GetById(int id);
IEnumerable <Department> GetAll();
void Add(Department department);
void Update(Department department);
void Delete(int id);

}

