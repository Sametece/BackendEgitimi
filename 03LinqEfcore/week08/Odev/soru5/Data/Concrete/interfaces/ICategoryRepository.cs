using System;
using soru5.Entity;

namespace soru5.Data.Concrete.interfaces;

public interface ICategoryRepository
{
    Category GetById(int id);
    IEnumerable<Category> GetAll();

    void Add(Category category);
    void Update(Category category);

    void Delete(int id);
}
