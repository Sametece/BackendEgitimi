using System;
using soru5.Entity;

namespace soru5.Data.Concrete.interfaces;

public interface IPostRepository
{
    Post GetById(int id);
    IEnumerable<Post> GetAll();

    void Add(Post post);
    void Update(Post post);

    void Delete(int id);
    
}
