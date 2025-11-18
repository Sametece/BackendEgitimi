using System;
using chat.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace chat.Data;

public class BookDbContext:DbContext
{
    public DbSet<Book> Books { get; set; }

    public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
         new Book { Id = 1, Title = "1984", Author = "George Orwell", Genre = "Dystopian", PublishedYear = 1949 },
new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Classic", PublishedYear = 1960 },
new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Novel", PublishedYear = 1925 },
new Book { Id = 4, Title = "Moby-Dick", Author = "Herman Melville", Genre = "Adventure", PublishedYear = 1851 },
new Book { Id = 5, Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance", PublishedYear = 1813 },
new Book { Id = 6, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Fiction", PublishedYear = 1951 },
new Book { Id = 7, Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = "Fantasy", PublishedYear = 1937 },
new Book { Id = 8, Title = "Brave New World", Author = "Aldous Huxley", Genre = "Science Fiction", PublishedYear = 1932 },
new Book { Id = 9, Title = "The Alchemist", Author = "Paulo Coelho", Genre = "Philosophical", PublishedYear = 1988 },
new Book { Id = 10, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", Genre = "Psychological", PublishedYear = 1866 }

        );

    }

}
