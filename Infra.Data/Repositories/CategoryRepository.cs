using System.Collections.Generic;
using System.Threading.Tasks;
using demo_clean_arc.Domain.Entities;
using demo_clean_arc.Domain.Interfaces;
using demo_clean_arc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace demo_clean_arc.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        ApplicationDbContext _categoryContext;

        public CategoryRepository(ApplicationDbContext context)
        {
            _categoryContext = context;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            _categoryContext.Add(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _categoryContext.Category.ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _categoryContext.Category.FindAsync(id);
        }

        public async Task<Category> RemoveAsync(Category category)
        {
            _categoryContext.Remove(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            _categoryContext.Update(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }
    }
}
