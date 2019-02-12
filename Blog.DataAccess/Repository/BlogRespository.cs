using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Blog.DataAccess.Data.Context;
using Blog.DataAccess.Models;

namespace Blog.DataAccess.Repository
{
    public sealed class BlogRespository<TEntity> : IBlogRepository<TEntity> where TEntity: Entity
    {
        internal BlogContext _blogContext;
        internal DbSet<TEntity> _dbSet;

        public BlogRespository(string connectionString)
        {
            _blogContext = new BlogContext(connectionString);
            _dbSet = _blogContext.Set<TEntity>();
        }
        public IEnumerable<TEntity> Get()
        {
            return _dbSet.ToList();
        }

        public TEntity Get(int id)
        {
            return _dbSet.Find(id);
        }
    }

    public interface IBlogRepository<TEntity> where TEntity : Entity
    {
        TEntity Get(int id);
        IEnumerable<TEntity> Get();
    }
}
