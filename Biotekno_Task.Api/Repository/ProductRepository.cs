using Biotekno_Task.Api.Entity;
using Biotekno_Task.Api.Infrastructure.Interfaces;

namespace Biotekno_Task.Api.Repository
{
    public class ProductRepository : GenericRepository<Product>,IProductRepository
    {
        public DataContext _context;
        private ICacheService _cacheService;
        public ProductRepository(DataContext context, ICacheService cacheService) : base(context)
        {
            _context = context;
            _cacheService = cacheService;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await GetById(id);
        }

        public async Task AddProduct(Product product)
        {
           await Create(product);
            
        }

        public async Task DeleteProduct(Product product)
        {
           await Delete(product.Id);
            
        }

        public async Task EditProduct(Product product)
        {
           await Update(product);
           
        }

        public async Task<IQueryable<Product>> GetProductListByCategory(string category)
        {
            var key = "getproducts" + category;
            var result = _cacheService.Get<IQueryable<Product>>(key);
            if(result == null)
            {
                var query = GetAll().Where(x => x.Category == category);
                _cacheService.Set(key, query);
                result = query;
            }
            return result;
        }
    }
}
