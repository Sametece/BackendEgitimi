using System;

namespace Project24_efCore_Basic.Models;

public class Author
{
   public int Id { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;


  // Bu tür proppertyl'lere Navigation Property diyoruz.
    public List<Post> Posts { get; set; } = [];
}
