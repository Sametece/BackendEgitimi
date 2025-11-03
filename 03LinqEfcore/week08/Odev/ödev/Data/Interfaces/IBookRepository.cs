using System;
using ödev.Dtos;
using ödev.Entity;

namespace ödev.Data.Interfaces;

public interface IBookRepository
{
        Book GetById(int id); // verilen Id ye ait Book nesnesini getirir.

        IEnumerable<Book> GetAll(); // Bütün Kitapları Nesne Şeklinde Döndürür.

        void Add(Book book); // Yeni bir Kitap Ekler 

        void Update(Book book); // Var olan kitabı günceller.

        void Delete(int id); // Verilen Id ye göre kitapı siler.

            List<BookWithAuthorNameDto> GetBookWithAuthorNameDtos(); //DTO

}
