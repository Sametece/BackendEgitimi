using System;
using ECommerce.Data.Models;

namespace ECommerce.Data.Abstract;

public interface ICustomerRepository :IRepository<Customer>
{
   Task<Customer> GetByEmailAsync(string email);
}
