using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blog.DataAccess.Models;
using Blog.DataAccess.Repository;

namespace BlogApplication.Tests.DataAccess.Test
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void check_repository_is_initalizing()
        {
            IBlogRepository<ArticlePage> repository = new BlogRespository<ArticlePage>();
            var entity = repository.Get(2);
            Assert.AreEqual(entity.Id,2);
        }
    }
}
