using System.Collections.Generic;
using System.Threading.Tasks;
using demo_clean_arc.Domain.Entities;
using demo_clean_arc.Domain.Interfaces;
using demo_clean_arc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace demo_clean_arc.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        ApplicationDbContext _productContext;
        public ProductRepository(ApplicationDbContext context)
        {
            _productContext = context;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            _productContext.Add(product);
            await _productContext.SaveChangesAsync();
            return product;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _productContext.Product.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _productContext.Product.FindAsync(id);
        }

        public async Task<Product> GetProductCategoryAsync(int id)
        {
            return await _productContext.Product
                .Include(x => x.Category)
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Product> RemoveAsync(Product product)
        {
            _productContext.Remove(product);
            await _productContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            _productContext.Update(product);
            await _productContext.SaveChangesAsync();
            return product;
        }
    }
}
