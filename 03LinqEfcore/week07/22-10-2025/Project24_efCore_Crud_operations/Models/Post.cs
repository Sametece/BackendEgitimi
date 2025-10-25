using System;

namespace Project24_efCore_Basic.Models;

public class Post
{
    /*Eğer bir sınıfta Id veya ClassAdı + Id isminde bir özellik (property) varsa,
onu otomatik olarak Primary Key (anahtar) kabul eder
*/
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    
    public DateTime PublishedOn { get; set; }

    public int AuthorId { get; set; }
    // içinde bulunduğumuz class hariç olmak üzere herhangi bir entiy classımızı adı+ıd şeklinde gördüğü propler => Foreign key olarak algılar
    
    //Navigation Property
    public Author? Author { get; set; } 

}
