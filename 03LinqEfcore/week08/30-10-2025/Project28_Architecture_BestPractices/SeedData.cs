using System;
using Project28_Architecture_BestPractices.Data;
using Project28_Architecture_BestPractices.Entities;

namespace Project26_EFCore_Relationship_Data;

public class SeedData
{
    BlogDbContext context = new BlogDbContext();
    public void CreateAuthors()
    {
        List<Author> authors = [
            new(){Id=1, FirstName="Ali", LastName="Veli"},
            new(){Id=2, FirstName="Canan", LastName="Güloğlu"},
            new(){Id=3, FirstName="Deren", LastName="Taşkesen"}
        ];
        context.Authors.AddRange(authors);
        context.SaveChanges();
    }

    public void CreatePosts()
    {
        List<Post> posts = [
            new(){Id=1, Title="Blog Title 1", Content="Content 1", AuthorId=1},
            new(){Id=2, Title="Blog Title 2", Content="Content 2", AuthorId=1},
            new(){Id=3, Title="Blog Title 3", Content="Content 3", AuthorId=1},
            new(){Id=4, Title="Blog Title 4", Content="Content 4", AuthorId=2},
            new(){Id=5, Title="Blog Title 5", Content="Content 5", AuthorId=2},
            new(){Id=6, Title="Blog Title 6", Content="Content 6", AuthorId=3},
            new(){Id=7, Title="Blog Title 7", Content="Content 7", AuthorId=3},
            new(){Id=8, Title="Blog Title 8", Content="Content 8", AuthorId=3},
            new(){Id=9, Title="Blog Title 9", Content="Content 9", AuthorId=3},
        ];
        context.Posts.AddRange(posts);
        context.SaveChanges();
    }
}
