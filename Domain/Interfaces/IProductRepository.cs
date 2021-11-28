
using System.Collections.Generic;
using System.Threading.Tasks;
using demo_clean_arc.Domain.Entities;

namespace demo_clean_arc.Domain.Interfaces {
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
