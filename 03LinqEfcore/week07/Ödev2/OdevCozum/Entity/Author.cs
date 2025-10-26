using System;

namespace OdevCozum.Entity;

public class Author
{
   public int Id { get; set; }

    public string FullName { get; set; } = string.Empty;

    public int BirthYear { get; set; }

    // 1 yazar 1 den fazla kitap yazabilir.Bu tür proppertyl'lere Navigation Property diyoruz.
      public List<Book> Books { get; set; } = [];
}
