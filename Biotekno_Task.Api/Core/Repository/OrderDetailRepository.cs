using Biotekno_Task.Api.Core.Entity;
using Biotekno_Task.Api.Core.Interfaces;
using Biotekno_Task.Api.Repository;

namespace Biotekno_Task.Api.Core.Repository
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>,IOrderDetailRepository
    {
        private DataContext _context;
        public OrderDetailRepository(DataContext context)
        {
            _context = context;
        }

        public Task AddOrderDetail(OrderDetail orderdetail)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrder(OrderDetail orderdetail)
        {
            throw new NotImplementedException();
        }

        public Task EditOrder(OrderDetail orderdetail)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetail> GetOrderById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
