using System;

namespace soru3.Dto;

public class OrderDto
{
    public int Id { get; set; }
    public DateTime PublishedOn { get; set; } = DateTime.UtcNow;
 public decimal TotalAmount { get; set; }
}
