using Microsoft.EntityFrameworkCore;
using Project26_efCore_relationship_data.DTos;
using Project26_efCore_relationship_data.Entites;

namespace Project26_efCore_relationship_data;

class Program
{
    static void Main(string[] args)
    {

        #region Projection Yöntemi ile Sadece Gerekli veriyi çekmek
        // Postların Idleri ve başlıkları yazar bilgilerini içeren bir liste oluşturalım.

        var context = new BlogDbContext();
        var posts = context
                    .Posts
                    .Include(p => p.Author)
                    .Select(p => new PostDto
                    {
                        PostId = p.Id,
                        PostTitle = p.Title,
                        AuthorName = $"{p.Author!.FirstName} {p.Author.LastName}"
                    })
                    
                    .ToList();
        foreach (var post in posts)
        {
            Console.WriteLine($"{post.PostId} - {post.PostTitle } - {post.AuthorName} ");
        }
            
        #endregion

        
    }
}
