using System.Collections.Generic;

namespace Shindy.Data
{
    public interface IRepository<TEntity> where TEntity : class 
    {
        void Update(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Delete(TEntity entity);
    }
}
