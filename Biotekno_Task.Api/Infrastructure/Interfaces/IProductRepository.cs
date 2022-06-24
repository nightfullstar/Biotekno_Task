using Biotekno_Task.Api.Entity;

namespace Biotekno_Task.Api.Infrastructure.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task AddProduct(Product product);
        Task DeleteProduct(Product product);
        Task EditProduct(Product product);
        Task<Product> GetProductByIdAsync(int id);
        Task<List<Product>> GetProductListByCategory(string category);
    }
}
