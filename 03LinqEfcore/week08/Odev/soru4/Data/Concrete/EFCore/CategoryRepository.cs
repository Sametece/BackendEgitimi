using System;
using Microsoft.EntityFrameworkCore;
using soru4.Data.Concrete.interfaces;
using soru4.Entity;

namespace soru4.Data.Concrete.EFCore;

public class CategoryRepository : ICategoryRepository
{
    // Miras Alındı

    private readonly MovieContext _context;  // readonlysi oluşturuldu

    public CategoryRepository(MovieContext context) //ctor oluşturuldu.
    {
        _context = context;
    }
    public void Add(Category category)   // Ekle Metotu
    {
        _context.Categories.Add(category);
        _context.SaveChanges();
    }

    public void Delete(int id)   // Sil Metotu
    {
        var category = GetById(id);
        if( category != null)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }

    public IEnumerable<Category> GetAll() //Tümünü Getir
    {
        var category = _context.Categories
                               .AsNoTracking()
                               .ToList();
        return category;
                            
    }

    public Category GetById(int id)  //Idye Göre Getir
    {
        var category = _context.Categories
                               .AsNoTracking()
                               .Where(c => c.Id == id)
                               .FirstOrDefault();
        return category!;
    }

    public void Update(Category category)  // Güncelle
    {
        _context.Categories.Update(category);
        _context.SaveChanges();
    }
}
