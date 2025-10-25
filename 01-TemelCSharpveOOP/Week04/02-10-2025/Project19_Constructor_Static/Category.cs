using System;

namespace Project19_Constructor_Static;

public class Category
{
    public Category()
    {

    }
    public Category(int productCount)//Constructor (İnşa Edici )Metot
    {
        Name = string.Empty;
        Description = string.Empty;
        ProductCount = productCount;
    }
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int ProductCount { get; set; }
    

}
/*
 Her class varsayılan olarak boş bir constuctor metot içerir. Bu implicit(örütülü gizli) haldedir . Eğer Biz bu metodun içine bir şeyler yazmak istersek ya da gerekli olursa bu metodu kendimiz elimizle yazmalıyız.

 Ancak bir class'ın içinde herhangi bir parametre alan constructor yazıldıysa artık o gizli constructor yani boş parametresiz olmuştur. eğer Yine de bir boş constructor ' a ihtiyaç varsa bu kez elle o boş constructor yazılmalıdır.
*/