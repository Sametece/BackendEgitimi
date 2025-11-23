using System;
using ECommerce.Data.Abstract;
using ECommerce.Data.Models;

namespace ECommerce.Data.Concrete;

public class UnitOfWork : IUnitOfWork
{

    private readonly ECommerceDbContext _context;
    public ICustomerRepository Customers { get; private set;  }

    public UnitOfWork(ECommerceDbContext context)
    {
        _context = context;
        Customers = new CustomerRepository(_context);
       
    }


    public async Task<int> CompleteAsync()
    {
        var result = await  _context.SaveChangesAsync();
        return result;
    }

    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }

    
}
