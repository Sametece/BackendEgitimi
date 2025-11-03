using ödev.Data;
using ödev.Data.Concrete.EFCore;
using ödev.Data.Interfaces;
using ödev.Entity;

namespace ödev;

class Program
{
    static void Main(string[] args)
    {
        var context = new LibraryContext(); // veri tabanını kullan

        IAuthorRepository authorRepository = new AuthorRepository(context);

        //Ben AuthorRepository sınıfından bir nesne oluşturuyorum ama onu IAuthorRepository türünde tutuyorum.
        //Ben sadece bu sözleşmeye bağlıyım, kim uygularsa uygulasın fark etmez.-- İnterface 

        IBookRepository bookRepository = new BookRepository(context);
        
        
        //Ben BookRepository sınıfından bir nesne oluşturuyorum ama onu IBookRepository türünde tutuyorum.
        //Ben sadece bu sözleşmeye bağlıyım, kim uygularsa uygulasın fark etmez.-- İnterface 
        
        // 1. Yazar
var author1 = new Author { FullName = "George Orwell" };
authorRepository.Add(author1); // Repository aracılığıyla ekliyoruz //Önceden context diyorduk direk veri tabanına gidiyordu 

bookRepository.Add(new Book { Title = "1984", AuthorId = author1.Id });
bookRepository.Add(new Book { Title = "Animal Farm", AuthorId = author1.Id });

// 2. Yazar
var author2 = new Author { FullName = "J.K. Rowling" };
authorRepository.Add(author2);

bookRepository.Add(new Book { Title = "Harry Potter and the Sorcerer's Stone", AuthorId = author2.Id });
bookRepository.Add(new Book { Title = "Harry Potter and the Chamber of Secrets", AuthorId = author2.Id });

// 3. Yazar
var author3 = new Author { FullName = "J.R.R. Tolkien" };
authorRepository.Add(author3);

bookRepository.Add(new Book { Title = "The Hobbit", AuthorId = author3.Id });
bookRepository.Add(new Book { Title = "The Lord of the Rings", AuthorId = author3.Id });

        
// 5 ' 1 de kaldık dto oluşturup bıraktık .
    }
}
