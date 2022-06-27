using Biotekno_Task.Api.Core.Entity;

namespace Biotekno_Task.Api.Core.Interfaces
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
