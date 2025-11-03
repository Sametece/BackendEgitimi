using System;
using soru3.Dto;
using soru3.Entity;

namespace soru3.Data.Concrete.interfaces;

public interface ICustomerRepository
{
    Customer GetById(int id); //Görevi, verilen id değerine sahip müşteriyi (Customer) bulup geri döndürmektir.
    IEnumerable<Customer> GetAll(); //Bu metot, veritabanındaki tüm Customer (müşteri) kayıtlarını döndürür.
    void Add(Customer customer);// Customer clasına customer nesnesi ekler
    void Update(Customer customer);// customer claasına customer nesnesini günceller

    void Delete(int id);// id ye göre silme silme işlemi yapar 

    List<OrderDto> GetOrdersByCustomerId(int customerId);  // Dto işlemi yapabilmemiz için
}
