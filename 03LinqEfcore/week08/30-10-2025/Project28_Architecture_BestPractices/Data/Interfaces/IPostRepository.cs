using System;
using Project28_Architecture_BestPractices.Entities;

namespace Project28_Architecture_BestPractices.Data.Interfaces;

public interface IPostRepository
{
    Post GetById(int id);
    IEnumerable<Post> GetAll();
    void Add(Post post);
    void Update(Post post);
    void Delete(int id);
}
