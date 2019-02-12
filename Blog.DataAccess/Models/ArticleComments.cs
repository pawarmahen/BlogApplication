namespace Blog.DataAccess.Models
{
    public class ArticleComments : Entity
    {
        public string UserName { get; set; }
        public string Comment { get; set; }
        public ArticlePage ArticlePage { get; set; }
    }
}
