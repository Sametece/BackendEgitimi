using Project26_EFCore_Relationship_Data;
using Project28_Architecture_BestPractices.Data;
using Project28_Architecture_BestPractices.Data.Concrete.EFCore;
using Project28_Architecture_BestPractices.Data.Interfaces;

namespace Project28_Architecture_BestPractices;

class Program
{
    static void Main(string[] args)
    {
        // SeedData seedData = new SeedData();
        // seedData.CreateAuthors();
        // seedData.CreatePosts();
        var context = new BlogDbContext();
        IPostRepository postRepository = new PostRepository(context);

        Console.WriteLine("Tüm postlar getiriliyor...");
        var posts = postRepository.GetAll();
        foreach (var post in posts)
        {
            Console.WriteLine(post.Title);
        }

        // İlerde özellikle context nesnesinin her yapılan istekte yaratılıp, istek sona erdiğinde yok olmasını sağlayacağımız bir yöntem kullanacağız, buna da Dependency Injection diyeceğiz.
    }
}
