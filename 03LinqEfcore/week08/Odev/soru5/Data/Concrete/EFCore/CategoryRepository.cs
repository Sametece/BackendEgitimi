using System;
using Microsoft.EntityFrameworkCore;
using soru5.Data.Concrete.interfaces;
using soru5.Entity;

namespace soru5.Data.Concrete.EFCore;

public class CategoryRepository : ICategoryRepository
{
    private readonly BlogContext _context;

    public CategoryRepository(BlogContext context)
    {
        _context = context;
    }
    public void Add(Category category)
    {
        _context.Categories.Add(category);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var category = GetById(id);
        if(category != null)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }

    public IEnumerable<Category> GetAll()
    {
        var category = _context.Categories
                                .AsNoTracking()
                                .ToList();
        return category;
    }

    public Category GetById(int id)
    {
        var category = _context.Categories
                               .AsNoTracking()
                               .Where(c => c.Id == id)
                               .FirstOrDefault();
        return category!;
    }

    public void Update(Category category)
    {
        _context.Categories.Update(category);
        _context.SaveChanges();
    }
}
