
using System.Collections.Generic;
using System.Threading.Tasks;
using demo_clean_arc.Application.DTOs;

namespace demo_clean_arc.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategories();

        Task<CategoryDTO> GetById(int id);

        Task Add(CategoryDTO categoryDTO);

        Task Update(CategoryDTO categoryDTO);
        Task Remove(int id);
    }
}
