using System;
using soru5.Data.Concrete.interfaces;
using soru5.Entity;

namespace soru5.Data.Concrete.EFCore;

public class CommentRepository : ICommentRepository
{
    private readonly BlogContext _context;

    public CommentRepository(BlogContext context)
    {
        _context = context;
    }
    public void Add(Comment comment)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Comment> GetAll()
    {
        throw new NotImplementedException();
    }

    public Comment GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Comment comment)
    {
        throw new NotImplementedException();
    }
}
