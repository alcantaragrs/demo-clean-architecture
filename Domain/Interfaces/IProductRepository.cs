
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces {
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);
        
        Task<IEnumerable<Product>> GetAllAsync();

        Task<Product> GetProductCategoryAsync(int id);

        Task<Product> CreateAsync(Product product);

        Task<Product> UpdateAsync(Product product);

        Task<Product> RemoveAsync(Product product);
    }
}
