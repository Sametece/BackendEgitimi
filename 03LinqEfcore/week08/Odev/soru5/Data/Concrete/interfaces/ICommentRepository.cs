using System;
using soru5.Entity;

namespace soru5.Data.Concrete.interfaces;

public interface ICommentRepository
{
    Comment GetById(int id);

    IEnumerable<Comment> GetAll();

    void Add(Comment comment);
    void Update(Comment comment);

    void Delete(int id);
    
}
