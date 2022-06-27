using Biotekno_Task.Api.Core.Entity;

namespace Biotekno_Task.Api.Core.Interfaces
{
    public interface IOrderDetailRepository : IGenericRepository<OrderDetail>
    {
        Task AddOrderDetail(OrderDetail orderdetail);
        Task DeleteOrder(OrderDetail orderdetail);
        Task EditOrder(OrderDetail orderdetail);
        Task<OrderDetail> GetOrderById(int id);
    }
}
