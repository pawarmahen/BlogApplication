using System.Data.Entity;
using Blog.DataAccess.Models;

namespace Blog.DataAccess.Data.Context
{
    internal class BlogContext : DbContext
    {
        internal BlogContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer(new BlogInitializer());
        }

        internal DbSet<ArticlePage> ArticlePage { get; set; }
        internal DbSet<ArticleComments> Comments { get; set; }
    }
}
