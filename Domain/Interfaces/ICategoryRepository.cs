
using System.Collections.Generic;
using System.Threading.Tasks;
using demo_clean_arc.Domain.Entities;

namespace demo_clean_arc.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category> GetByIdAsync(int id);

        Task<IEnumerable<Category>> GetAllAsync();

        Task<Category> CreateAsync(Category category);

        Task<Category> UpdateAsync(Category category);

        Task<Category> RemoveAsync(Category category);

    }
}
