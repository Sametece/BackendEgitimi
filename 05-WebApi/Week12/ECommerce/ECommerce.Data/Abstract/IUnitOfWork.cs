using System;

namespace ECommerce.Data.Abstract;

public interface IUnitOfWork : IAsyncDisposable
{
    IProductRepository Products { get;}
    // İlerde bunlar da gelecek
    // ICategoryRepository Categories {get;}
    // IOrderRepository Orders {get;}

    Task<int> CompleteAsync();
}
