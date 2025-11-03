using System;
using Microsoft.EntityFrameworkCore;
using ödev.Data.Interfaces;
using ödev.Entity;

namespace ödev.Data.Concrete.EFCore;

public class BookRepository:IBookRepository
{
    //somut repository

     private readonly LibraryContext _context;// Sadece ilk yaratıldığında ya da constructor içinde değer verilebilir!

    public BookRepository(LibraryContext context)
    {
        _context = context;
    }

    public void Add(Book book)  // Yeni Bir Kitap Classına Kitap Nesnesi Ekler - Kaydeder
    {
        _context.Books.Add(book);
        _context.SaveChanges();
    }

    public void Delete(int id)    //Idyı Bull nul Değilse Kitapı sil - kaydet
    {
        var book = GetById(id);
        if (book != null)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }

    public IEnumerable<Book> GetAll() // Bütün Kitapları listele
    {
        var books = _context.Books
                              .AsNoTracking()
                              .ToList();
        return books;
    }

    public Book GetById(int id)     // İd ye ait olan Kitapı Bul Ve Getir Performans için AsnoTracking kullandık Hızlı çalışşın diye
    {
        var book = _context.Books
                             .AsNoTracking()
                             .Where(a => a.Id == id)
                             .FirstOrDefault();
        return book!;
    }
    
    public void Update(Book book) // yazarı Güncelle - kaydet
    {
        _context.Books.Update(book);
        _context.SaveChanges();
    }

}
