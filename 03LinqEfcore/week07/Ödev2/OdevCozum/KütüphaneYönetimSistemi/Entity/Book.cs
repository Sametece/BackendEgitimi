using System;

namespace OdevCozum.Entity;

public class Book
{
       public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public int PageCount { get; set; }


     // içinde bulunduğumuz class hariç olmak üzere herhangi bir entiy classımızı adı+ıd şeklinde gördüğü propler => Foreign key olarak algılar
    //1 kitabın sadece 1 tane yazarı olabilir.Navigation Property
    public int AuthorId { get; set; }
    
    public Author? Author { get; set; } 

}
