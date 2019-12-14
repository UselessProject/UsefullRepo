using System;
using Dreamlines.DAL;
using System.Linq;

namespace Dreamlines.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                // Create
                Console.WriteLine("Inserting a new blog");
                db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a blog");
                var blog = db.Blogs
                    .OrderBy(b => b.BlogId)
                    .First();

                // Update
                Console.WriteLine("Updating the blog and adding a post");
                blog.Url = "https://devblogs.microsoft.com/dotnet";
                blog.Posts.Add(
                    new Post
                    {
                        Title = "Hello World",
                        Content = "I wrote an app using EF Core!"
                    });
                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete the blog");
                db.Remove(blog);
                db.SaveChanges();
            }
            //*
            ////////using (var db = new SalesUnitngContext())
            ////////{
            ////////    // Create
            ////////    Console.WriteLine("Inserting a new SalesUnit");
            ////////    db.Add(new SalesUnit { Id = 2, Name = "Mona" ,Country="Iran",Currency="$"});
            ////////    db.SaveChanges();

            ////////    // Read
            ////////    Console.WriteLine("Querying for a SalesUnit");
            ////////    var SalesUnit = db.SalesUnits
            ////////        .OrderBy(b => b.Id)
            ////////        .First();

            ////////    // Update
            ////////    Console.WriteLine("Updating the salesUnit and adding a ship");
            ////////    //blog.Url = "https://devblogs.microsoft.com/dotnet";
            ////////    SalesUnit.Ships.Add(
            ////////        new Ship
            ////////        {
            ////////            Id = 1,
            ////////            Name = "I wrote an app using EF Core!"

            ////////        });
            ////////    db.SaveChanges();

            ////////    // Delete
            ////////    //Console.WriteLine("Delete the blog");
            ////////    //db.Remove(SalesUnit);
            ////////    //db.SaveChanges();
            ////////}
        }
    }
}