using System;
using soru3.Entity;

namespace soru3.Data.Concrete.interfaces;

public interface IOrderRepository
{
    Order GetById(int id);
    IEnumerable<Order> GetAll();

    void Add(Order order);
    void Update(Order order);

    void Delete(int id);
}
