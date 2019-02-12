using System.Collections.Generic;
using System.Data.Entity;
using Blog.DataAccess.Models;

namespace Blog.DataAccess.Data.Context
{
    internal class BlogInitializer : CreateDatabaseIfNotExists<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            //context.ArticlePage.Add(new ArticlePage
            //{
            //    Author = "test",
            //    Body = "<h1>Article Body</h1>",
            //    Title = "test article",
            //    Description = "test description",
            //    Comments = new List<ArticleComments>
            //    {
            //        new ArticleComments {UserName = "test user",Comment = "test comment"}
            //    }
            //});
            //context.SaveChanges();
            base.Seed(context);
        }
    }
}
