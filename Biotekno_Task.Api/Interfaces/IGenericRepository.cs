using Biotekno_Task.Api.Entity;

namespace Biotekno_Task.Api.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        List<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(int id);
    }
}
