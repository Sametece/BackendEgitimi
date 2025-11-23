using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ECommerce.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace ECommerce.Data.Concrete;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly ECommerceDbContext _context;

    public Repository(ECommerceDbContext context)
    {
        _context = context;
        _dbset = _context.Set<T>();
    }

    protected readonly DbSet<T> _dbset;


    public async Task AddAsync(T entity)
    {
        await _dbset.AddAsync(entity);
    }

    public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    {
        var result = await _dbset.Where(predicate).ToListAsync();
        return result;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        var result = await _dbset.ToListAsync();
        return result;
    }

    public async Task<T> GetByIdAsync(int id)
    {
        var result = await _dbset.FindAsync(id);
        return result! ;
    }

   public void Remove(T entity)
{
    _dbset.Remove(entity);
}

    public void Update(T entity)
    {
        _dbset.Update(entity);
    }

   
}
