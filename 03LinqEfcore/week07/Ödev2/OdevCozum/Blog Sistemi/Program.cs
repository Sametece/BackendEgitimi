using Blog_Sistemi.Data;
using Blog_Sistemi.Entity;

namespace Blog_Sistemi;

class Program
{
    static void Main(string[] args)
    {
        var context = new BlogContext();

        #region Veri Ekleme

        if (!context.Categories.Any())
            {
                var tech = new Category { CategoryName = "Teknoloji" };
                var travel = new Category { CategoryName = "Seyahat" };

                var post1 = new Post
                {
                    Title = "Yapay Zeka Nedir?",
                    Content = "Yapay zeka insan zekasını taklit eden sistemlerdir.",
                    PublishedDate = DateTime.Now,
                    Category = tech
                };

                var post2 = new Post
                {
                    Title = "Paris Gezi Rehberi",
                    Content = "Paris'te gezilecek yerler ve öneriler...",
                    PublishedDate = DateTime.Now,
                    Category = travel
                };

                var comment1 = new Comment
                {
                    AuthorName = "Ali",
                    Message = "Harika bir yazı!",
                    Post = post1
                };

                var comment2 = new Comment
                {
                    AuthorName = "Ayşe",
                    Message = "Gitmeden önce mutlaka okuyun!",
                    Post = post2
                };

                context.AddRange(tech, travel, post1, post2, comment1, comment2);
            context.SaveChanges();
                Console.WriteLine("Veriler başarıyla eklendi!");
            }
        }

        


       
            
        #endregion
    }

