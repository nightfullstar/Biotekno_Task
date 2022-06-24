using Biotekno_Task.Api.Entity;
using Biotekno_Task.Api.Infrastructure.Interfaces;

namespace Biotekno_Task.Api.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public DataContext _context;
        public OrderRepository(DataContext context) : base(context)
        {
            _context = context;
        }
        public async Task AddOrder(Order order)
        {
            await Create(order);
           
        }

        public async Task DeleteOrder(Order order)
        {
            await Delete(order.Id);
          
        }

        public async Task EditOrder(Order order)
        {
            await Update(order);
           
        }

        public async Task<Order> GetOrderById(int id)
        {
           return await GetById(id);
        }

       
    }
}
