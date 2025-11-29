using System;
using ECommerce.Entity.Abstract;

namespace ECommerce.Entity.Concrete;

public class Order:BaseClass
{
   //normalde siparişin kimin verdiğinide tutmalıyız onu identity görücez

public int UserId { get; set; } =1;
public string UserName { get; set; } = "Default User";
   public string? Address { get; set; } //adresi sürekili girmemesi için operasyon yapılabilir

   public string? City { get; set; }

   public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending; //sheerıd katmanı oluşabilir

   public ICollection<OrderItem> OrderItems { get; set; } = [];
}

public enum OrderStatus //Sipariş Aşamaları
{
    Pending=0,
    Proccesing=1,
    Shipped=2,
    Delivered=3,
    Cancelled=4
}