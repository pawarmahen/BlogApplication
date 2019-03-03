using System.Data.Entity;
using Blog.DataAccess.Models;

namespace Blog.DataAccess.Data.Context
{
    internal class BlogContext : DbContext
    {
            internal BlogContext() : base(@"Data Source=ASEN-L-ANANDK\SQLEXPRESSDEV;Initial Catalog=BlogApplication;User ID=sa;Password=Abcd$123")
            {
                Database.SetInitializer(new BlogInitializer());
            }

        internal DbSet<ArticlePage> ArticlePage { get; set; }
        internal DbSet<ArticleComments> Comments { get; set; }
    }
}
