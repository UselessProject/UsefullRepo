using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dreamlines.DAL
{
  public  class BloggingContext: DbContext
    {
        public BloggingContext()
        { }
        public BloggingContext(DbContextOptions<BloggingContext> options)
        : base(options)
        { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

             //=> optionsBuilder.UseSqlite("Data Source=D:\\Projects\\Dreamlines\\Dreamlines.DAL\\blogging.db");
            // => optionsBuilder.UseSqlite("Data Source=blogging.db");
       => optionsBuilder.UseInMemoryDatabase(databaseName: "Test");

    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; } = new List<Post>();
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
