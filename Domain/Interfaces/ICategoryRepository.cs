
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
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
