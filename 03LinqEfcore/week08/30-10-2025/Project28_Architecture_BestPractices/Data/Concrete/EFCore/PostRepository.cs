using System;
using Microsoft.EntityFrameworkCore;
using Project28_Architecture_BestPractices.Data.Interfaces;
using Project28_Architecture_BestPractices.Entities;

namespace Project28_Architecture_BestPractices.Data.Concrete.EFCore;

public class PostRepository : IPostRepository
{
    private readonly BlogDbContext _context;// Sadece ilk yaratıldığında ya da constructor içinde değer verilebilir!
    public PostRepository(BlogDbContext context)
    {
        _context = context;
    }
    public void Add(Post post)
    {
        _context.Posts.Add(post);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var post = GetById(id);
        if (post != null)
        {
            _context.Posts.Remove(post);
            _context.SaveChanges();
        }
    }

    public IEnumerable<Post> GetAll()
    {
        var posts = _context
            .Posts
            .AsNoTracking()
            .ToList();
        return posts;
    }

    public Post GetById(int id)
    {
        var post = _context
            .Posts
            .AsNoTracking()
            .Where(p => p.Id == id)
            .FirstOrDefault();
        return post!;
    }

    public void Update(Post post)
    {
        _context.Posts.Update(post);
        _context.SaveChanges();
    }
}

// Add, Update ve Delete işlemlerinde kullandığımız SaveChanges için de ilerde yeni bir Design Pattern öğreneceksiniz. (UnitOfWork Design Pattern)