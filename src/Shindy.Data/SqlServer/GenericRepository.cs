using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using Shindy.Data.Repository;

namespace Shindy.Data.SqlServer
{
    public class GenericRepository<TEntity> : IRepository<TEntity>  where TEntity : class
    {
        private readonly IShindyContext _context;
        private readonly IDbSet<TEntity> _dbSet; 
        
        public GenericRepository(IShindyContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            return _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}