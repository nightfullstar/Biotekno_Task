using Biotekno_Task.Api.Entity;
using Microsoft.EntityFrameworkCore;

namespace Biotekno_Task.Api
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }


    }
}
