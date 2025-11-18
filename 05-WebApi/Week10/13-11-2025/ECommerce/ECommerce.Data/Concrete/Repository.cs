using System;
using System.Linq.Expressions;
using ECommerce.Data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data.Concrete;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ECommerceDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(ECommerceDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        var result = await _dbSet.ToListAsync();
        return result;
    }

    public async Task<T> GetByIdAsync(int id)
    {
        var result = await _dbSet.FindAsync(id);
        return result!;
    }

    public void Remove(T entity)
    {
        _dbSet.Remove(entity);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }
}
