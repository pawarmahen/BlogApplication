using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blog.DataAccess.Models;
using Blog.DataAccess.Repository;

namespace BlogApplication.Tests.DataAccess.Test
{
    [TestClass]
    public class RepositoryTest
    {
        private string connectionString = @"Data Source=ASEN-L-ANANDK\SQLEXPRESSDEV;Initial Catalog=BlogApplication;User ID=sa;Password=Abcd$123";

        [TestMethod]
        public void check_repository_is_initalizing()
        {
            IBlogRepository<ArticlePage> repository = new BlogRespository<ArticlePage>(connectionString);
            var entity = repository.Get(2);
            Assert.AreEqual(entity.Id,2);
        }
    }
}
