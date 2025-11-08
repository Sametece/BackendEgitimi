using System;
using soru5.Data.Concrete.interfaces;
using soru5.Entity;

namespace soru5.Data.Concrete.EFCore;

public class PostRepository : IPostRepository
{
    private readonly BlogContext _context;

    public PostRepository(BlogContext context)
    {
        _context = context;
    }
    public void Add(Post post)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Post> GetAll()
    {
        throw new NotImplementedException();
    }

    public Post GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Post post)
    {
        throw new NotImplementedException();
    }
}
