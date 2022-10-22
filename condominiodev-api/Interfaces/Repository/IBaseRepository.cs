using System;
namespace condominiodev_api.Interfaces.Repository
{
    public interface IBaseRepository<TEntity, Tkey> where TEntity : class
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        IQueryable<TEntity> ListAll();
        TEntity GetById(Tkey id);
        int GetTotal();
    }
}