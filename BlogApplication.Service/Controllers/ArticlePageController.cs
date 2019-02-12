using System.Web.Http;
using Blog.DataAccess.Models;
using Blog.DataAccess.Repository;
using Unity;

namespace BlogApplication.Service.Controllers
{
    public class ArticlePageController : ApiController
    {
        private IBlogRepository<ArticlePage> _repository;

        public ArticlePageController(IBlogRepository<ArticlePage> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ArticlePage Get(int id)
        {
            return _repository.Get(id);
        }
    }
}
