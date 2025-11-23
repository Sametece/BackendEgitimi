using System;
using System.Linq.Expressions;

namespace ECommerce.Data.Abstract;

public interface IRepository<T> where T:class
{
    /// <summary>
    /// Id 'ye Göre tek bir nesne getirme imzası
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<T> GetByIdAsync(int id);
     
     /// <summary>
     /// Tüm nesneleri getir imzası
     /// </summary>
     /// <returns></returns>
    Task<IEnumerable<T>> GetAllAsync();

    /// <summary>
    /// Belirli bir koşula uyan nesneleri getirme imzası
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    Task<IEnumerable<T>> FindAsync(Expression<Func<T,bool>> predicate);  
     
     /// <summary>
     /// Yeni bir nesne ekleme imzası
     /// </summary>
     /// <returns></returns>
    Task AddAsync(T entity);
    
    /// <summary>
    /// Bir nesneyi Güncelleme imzası
    /// </summary>
    void Update(T entity);
     
     /// <summary>
     /// Bir nesneyi silme imzası
     /// </summary>
    void Remove(T entity);




}
