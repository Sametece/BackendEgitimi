using System;
using System.Linq.Expressions;

namespace ECommerce.Data.Abstract;

public interface IRepository<T> where T:class
{
    /// <summary>
    /// ID'ye göre tek bir nesne getirme
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<T> GetAsync(int id);



/// <summary>
/// Filtreleyerek nesne getirme
/// </summary>
/// <param name="predicate"></param>
/// <param name="showIsDeleted"></param>
/// <param name="asExpanded"></param>
/// <param name="includes"></param>
/// <returns></returns>
 Task<T> GetAsync(

    Expression<Func<T, bool>> predicate,
    bool showIsDeleted = false,
    bool asExpanded=false,
    params Expression<Func<T, object>>[] includes
 );
 /*
 GetAsync(x=>c.Name="Iphone14 gibi)
 */



    /// <summary>
    /// Tüm nesneleri getirme
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<T>> GetAllAsync();


    Task<IEnumerable<T>> GetAllAsync(
        Expression<Func<T,bool>> predicate = null!,
        Func<IQueryable<T> , IOrderedQueryable<T>> orderBy = null!,
        bool showIsDeleted =false,
        bool asExpanded=false,
        params Func<IQueryable<T>,IQueryable<T>> [] includes 
    );



    /// <summary>
    /// Belirli bir koşula uyan nesneleri getirme
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    Task<IEnumerable<T>> FindAsync(Expression<Func<T,bool>> predicate);



    /// <summary>
    /// Yeni bir nesne ekleme
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task AddAsync(T entity);



    /// <summary>
    /// Bir nesneyi güncelleme
    /// </summary>
    /// <param name="entity"></param>
    void Update(T entity);


    /// <summary>
    /// Bir nesneyi silme
    /// </summary>
    /// <param name="entity"></param>
    void Remove(T entity);
}










/*
var p = await GetByIdAsync(5);
Console.Write(p.Name);


Where(p=>p.Category=="Telefon")
*/