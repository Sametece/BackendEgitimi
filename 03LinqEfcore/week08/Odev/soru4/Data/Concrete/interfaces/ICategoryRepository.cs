using System;
using soru4.Entity;

namespace soru4.Data.Concrete.interfaces;

public interface ICategoryRepository
{

    //Çalışılan interface Baz alarak ona göre Class isimlerini verin 
    Category GetById(int id);
    IEnumerable<Category> GetAll();

    void Add(Category category);
    void Update(Category category);

    void Delete(int id);
}
