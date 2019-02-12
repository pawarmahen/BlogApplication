using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Blog.DataAccess.Data.Context;
using Blog.DataAccess.Models;

namespace Blog.DataAccess.Repository
{
    public sealed class BlogRespository<TEntity> : 
        IBlogRepository<TEntity> where TEntity : Entity
    {
        internal BlogContext _blogContext;
        internal DbSet<TEntity> _dbSet;

        public BlogRespository(string connectionString)
        {
            _blogContext = new BlogContext(connectionString);
            _dbSet = _blogContext.Set<TEntity>();
        }

        public void Delete(int id)
        {
            TEntity entityToDelete = Get(id);
            Delete(entityToDelete);
        }

        public IEnumerable<TEntity> Get()
        {
            return _dbSet.ToList();
        }

        public TEntity Get(int id)
        {
            return _dbSet.Find(id);
        }

        public void Insert(TEntity entity)
        {
            if (entity == null)
                throw new InvalidOperationException("Entity can not be empty");
            try
            {
                _dbSet.Add(entity);
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
        public void Delete(TEntity entityToDelete)
        {
            try
            {
                if (_blogContext.Entry(entityToDelete).State == EntityState.Detached)
                {
                    _dbSet.Attach(entityToDelete);
                }
                _dbSet.Remove(entityToDelete);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Update(TEntity entityToUpdate)
        {
            try
            {
                _dbSet.Attach(entityToUpdate);
                _blogContext.Entry(entityToUpdate).State = EntityState.Modified;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void SaveChanges()
        {
            try
            {
                _blogContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
