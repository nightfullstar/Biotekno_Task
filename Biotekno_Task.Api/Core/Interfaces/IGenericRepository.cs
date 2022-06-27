using Biotekno_Task.Api.Core.Entity;

namespace Biotekno_Task.Api.Core.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(int id);
    }
}
