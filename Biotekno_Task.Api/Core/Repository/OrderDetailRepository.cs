using Biotekno_Task.Api.Core.Entity;
using Biotekno_Task.Api.Repository;

namespace Biotekno_Task.Api.Core.Repository
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>
    {
        private DataContext _context;
        public OrderDetailRepository(DataContext context)
        {
            _context = context;
        }

    }
}
