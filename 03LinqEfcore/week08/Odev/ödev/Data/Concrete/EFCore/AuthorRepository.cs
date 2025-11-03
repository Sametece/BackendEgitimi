using System;
using Microsoft.EntityFrameworkCore;
using ödev.Data.Interfaces;
using ödev.Entity;

namespace ödev.Data.Concrete.EFCore;

public class AuthorRepository : IAuthorRepository
{
    // somut repository

    private readonly LibraryContext _context;// Sadece ilk yaratıldığında ya da constructor içinde değer verilebilir!

    public AuthorRepository(LibraryContext context)
    {
        _context = context;
    }

    public void Add(Author author)  // Yeni Bir Yazar Classına Yazar Nesnesi Ekler - Kaydeder
    {
        _context.Authors.Add(author);
        _context.SaveChanges();
    }

    public void Delete(int id)    //Idyı Bull nul Değilse Yazarı sil - kaydet
    {
        var author = GetById(id);
        if (author != null)
        {
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }
    }

    public IEnumerable<Author> GetAll() // Bütün yazarları listele
    {
        var authors = _context.Authors
                              .AsNoTracking()
                              .ToList();
        return authors;
    }

    public Author GetById(int id)     // İd ye ait olan Yazarı Bul Ve Getir Performans için AsnoTracking kullandık Hızlı çalışşın diye
    {
        var author = _context.Authors
                             .AsNoTracking()
                             .Where(a => a.Id == id)
                             .FirstOrDefault();
        return author!;
    }
    
    public void Update(Author author) // yazarı Güncelle - kaydet
    {
        _context.Authors.Update(author);
        _context.SaveChanges();
    }

}
