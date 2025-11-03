using System;
using ödev.Entity;

namespace ödev.Data.Interfaces;

public interface IAuthorRepository
{
    

        Author GetById(int id); // verilen Id ye ait Author nesnesini getirir.

        IEnumerable<Author> GetAll(); // Bütün Yazarları Nesne Şeklinde Döndürür.

        void Add(Author author); // Yeni bir Yazar Ekler 

        void Update(Author author); // Var olan Yazarı günceller.

        void Delete(int id); // Verilen Id ye göre Yazarı siler.
    

}
