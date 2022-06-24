using Biotekno_Task.Api.Entity;

namespace Biotekno_Task.Api.Infrastructure.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task AddOrder(Order product);
        Task DeleteOrder(Order product);
        Task EditOrder(Order product);
        Task<Order> GetOrderById(int id);
    }
}
