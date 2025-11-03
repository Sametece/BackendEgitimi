using System;

namespace soru3.Entity;

public class Order
{
  public int Id { get; set; }
    public DateTime PublishedOn { get; set; } = DateTime.UtcNow;
    
    public decimal TotalAmount { get; set; }

    //navi

    public int CustomerId { get; set; }

    public Customer? Customer { get; set; }
}
