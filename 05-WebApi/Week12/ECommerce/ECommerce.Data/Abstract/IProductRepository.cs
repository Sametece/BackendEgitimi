using System;
using ECommerce.Entity.Abstract;
using ECommerce.Entity.Concrete;

namespace ECommerce.Data.Abstract;

public interface IProductRepository: IRepository<Product>
{
    Task<IEnumerable<Product>> GetLowStockProductsAsync(int threshold);
}
