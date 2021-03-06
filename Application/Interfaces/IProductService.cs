using System.Collections.Generic;
using System.Threading.Tasks;
using demo_clean_arc.Application.DTOs;

namespace demo_clean_arc.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProducts();

        Task<ProductDTO> GetById(int id);

        Task<ProductDTO> GetProductCategory(int id);

        Task Add(ProductDTO productDTO);
        Task Update(ProductDTO productDTO);
        Task Remove(int id);
    }
}
