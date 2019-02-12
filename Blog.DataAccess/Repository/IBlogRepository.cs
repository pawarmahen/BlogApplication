using Blog.DataAccess.Models;
using System.Collections.Generic;

namespace Blog.DataAccess.Repository
{
    public interface IBlogRepository<TEntity> where TEntity : Entity
    {
        TEntity Get(int id);
        IEnumerable<TEntity> Get();
        void Insert(TEntity entity);
        void Delete(int id);
        void Delete(TEntity entityToDelete);
        void Update(TEntity entityToUpdate);
        void SaveChanges();
    }
}
