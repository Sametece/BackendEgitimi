using System;

namespace MüşteriSiparisSistemi.Entity;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Mail { get; set; } = string.Empty;

    public List<Order> Orders { get; set; } = []; // Bir Müşterinin birden Fazla siparişi olabilir.
}
