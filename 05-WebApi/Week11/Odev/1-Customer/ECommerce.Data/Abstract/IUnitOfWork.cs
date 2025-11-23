using System;

namespace ECommerce.Data.Abstract;

public interface IUnitOfWork : IAsyncDisposable
{
   ICustomerRepository Customers {get ;} 
   //ilerde buralar category-order olabilir.

   Task<int> CompleteAsync();
}
