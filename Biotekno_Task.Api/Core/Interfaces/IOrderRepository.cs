using Biotekno_Task.Api.Core.Entity;

namespace Biotekno_Task.Api.Core.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task AddOrder(Order order);
        Task DeleteOrder(Order order);
        Task EditOrder(Order order);
        Task<Order> GetOrderById(int id);
    }
}
