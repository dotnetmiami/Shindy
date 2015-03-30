using System.Collections.Generic;

namespace Shindy.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Delete(TEntity entity);
        void Save();
    }
}
