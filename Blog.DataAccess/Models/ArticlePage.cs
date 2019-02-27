using System;
using System.Collections.Generic;

namespace Blog.DataAccess.Models
{
    public class ArticlePage : Entity
    {
        public ArticlePage()
        {
            SimpleComment = new ArticleComments();
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        
        public Uri Image { get; set; }

        public ArticleComments SimpleComment { get; set; }

        public ICollection<ArticleComments> Comments { get; set; }
    }
}
