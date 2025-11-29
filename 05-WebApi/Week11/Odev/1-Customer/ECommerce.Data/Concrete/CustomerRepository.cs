using System;
using ECommerce.Data.Abstract;
using ECommerce.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data.Concrete;

public class CustomerRepository : Repository<Customer>, ICustomerRepository
{
    public CustomerRepository(ECommerceDbContext context) : base(context)
    {
    }

    public async Task<Customer> GetByEmailAsync(string email)
    {
        return await _dbset.FirstOrDefaultAsync(c => c.Email == email);
    }

   
}
