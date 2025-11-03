using System;
using Microsoft.EntityFrameworkCore;
using soru3.Data.Concrete.interfaces;
using soru3.Dto;
using soru3.Entity;

namespace soru3.Data.Concrete.EFCore;

public class CustomerRepository : ICustomerRepository
{
    private readonly ECommerceContext _context;

    public CustomerRepository(ECommerceContext context )
    {
        _context = context;
    }
    public void Add(Customer customer)
    {
        _context.Customers.Add(customer);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var customer = GetById(id);
        if(customer !=null)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }

    public IEnumerable<Customer> GetAll()
    {
        var customers = _context.Customers.AsNoTracking().ToList();
        return customers;
    }

    public Customer GetById(int id)
    {
        var customer = _context.Customers.AsNoTracking()
                                          .Where(c => c.Id == id)
                                          .FirstOrDefault();
        return customer!;
    }

    public List<OrderDto> GetOrdersByCustomerId(int customerId)
    {
        return _context.Orders
            .AsNoTracking()
            .Where(o => o.CustomerId == customerId)
            .OrderByDescending(o => o.PublishedOn)
            .Select(o => new OrderDto
            {
                Id = o.Id,
                PublishedOn = o.PublishedOn,
                TotalAmount = o.TotalAmount
            })
            .ToList();
    }

    public void Update(Customer customer)
    {
        _context.Customers.Update(customer);
    }
}
