using System;

namespace Proje_odev;

public class Order
{
 public int OrderId { get; set; } 
 public int CustomerId { get; set; }
  public int ProductId { get; set; } 
  public DateTime OrderDate { get; set; }
   public int Quantity { get; set; }


    public static  List<Order> orders = new List<Order> {
    new Order { OrderId = 101 , CustomerId = 1 , ProductId = 2 , OrderDate = new DateTime ( 2025 , 10 , 1 ), Quantity = 1 }, new Order { OrderId = 102 , CustomerId = 2 , ProductId = 4 , OrderDate = new DateTime ( 2025 , 10 , 5 ), Quantity = 3 }, new Order { OrderId = 103 , CustomerId = 1 , ProductId = 5 , OrderDate = new DateTime ( 2025 , 10 , 8 ), Quantity = 2 }, new Order { OrderId = 104 , CustomerId = 3 , ProductId = 1 , OrderDate = new DateTime ( 2025 , 10 , 10 ), Quantity = 1 }, new Order { OrderId = 105 , CustomerId = 4 , ProductId = 7 , OrderDate = new DateTime ( 2025 , 11 , 12 ), Quantity = 1 }, new Order { OrderId = 106 , CustomerId = 2 , ProductId = 2 , OrderDate = new DateTime ( 2025 , 11 , 15 ), Quantity = 1 }, new Order { OrderId = 107 , CustomerId = 1 , ProductId = 4 , OrderDate = new DateTime ( 2025 , 11 , 21 ), Quantity = 2 }, new Order { OrderId = 108 , CustomerId = 3 , ProductId = 5 , OrderDate = new DateTime ( 2025 , 12 , 1 ), Quantity = 1 }, new Order { OrderId = 109 , CustomerId = 2 , ProductId = 6 , OrderDate = new DateTime ( 2025 , 12 , 4 ), Quantity = 1 }, new Order { OrderId = 110 , CustomerId = 4 , ProductId = 2 , OrderDate = new DateTime ( 2025 , 12 , 8 ), Quantity = 1 }
   };
}
