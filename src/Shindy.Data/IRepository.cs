namespace Shindy.Data
{
    public interface IRepository<TEntity> where TEntity : class 
    {
        void Update(TEntity entity);
        TEntity GetById(int id);
        void Save();
        void Delete(TEntity entity);
    }
}
