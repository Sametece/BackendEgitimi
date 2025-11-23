using System;
using ECommerce.Data.Models;

namespace ECommerce.Data.Abstract;

public interface ICustomerRepository :IRepository<Customer>
{
   Task<IEnumerable<Customer>> GetByEmailAsync(string email);
}
