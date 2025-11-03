using System;
using Microsoft.EntityFrameworkCore;
using soru3.Data.Concrete.interfaces;
using soru3.Entity;

namespace soru3.Data.Concrete.EFCore;

public class OrderRepository : IOrderRepository
{

    private readonly ECommerceContext _context;
    public OrderRepository(ECommerceContext context)
    {
        _context = context;
    }
    public void Add(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var order = GetById(id);
        if(order != null)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
    }

    public IEnumerable<Order> GetAll()
    {
        var order = _context.Orders.AsNoTracking().ToList();

        return order;
    }

    public Order GetById(int id)
    {
        var order = _context.Orders
                             .AsNoTracking()
                             .Where(o => o.Id == id)
                             .FirstOrDefault();
        return order!;
        
    }

    public void Update(Order order)
    {
        _context.Orders.Update(order);
        _context.SaveChanges();
    }
}
