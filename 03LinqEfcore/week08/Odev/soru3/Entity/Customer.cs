using System;

namespace soru3.Entity;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;


    //navi

    public List<Order> Orders { get; set; } = [];
    
}
