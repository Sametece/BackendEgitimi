using System;

namespace MüşteriSiparisSistemi.Entity;

public class Order
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }

    // Foreign key
    public int CustomerId { get; set; }

    // Navigation property
    public Customer? Customer { get; set; }

}
