using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using demo_clean_arc.Application.DTOs;
using demo_clean_arc.Application.Interfaces;
using demo_clean_arc.Domain.Entities;
using demo_clean_arc.Domain.Interfaces;

namespace demo_clean_arc.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;
        
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _mapper = mapper;
        }

        public async Task Add(ProductDTO productDTO)
        {
            var productEntity = _mapper.Map<Product>(productDTO);
            await _productRepository.CreateAsync(productEntity);
        }

        public async Task<ProductDTO> GetById(int id)
        {
            var productDTO = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductDTO>(productDTO);
        }

        public async Task<ProductDTO> GetProductCategory(int id)
        {
            var productEntity = await _productRepository.GetProductCategoryAsync(id);
            return _mapper.Map<ProductDTO>(productEntity);
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productEntities = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(productEntities);
        }

        public async Task Remove(int id)
        {
            var productEntity = _productRepository.GetByIdAsync(id).Result;
            await _productRepository.RemoveAsync(productEntity);
        }

        public async Task Update(ProductDTO productDTO)
        {
            var productEntity = _mapper.Map<Product>(productDTO);
            await _productRepository.UpdateAsync(productEntity);
        }
    }
}
