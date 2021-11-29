
using AutoMapper;
using demo_clean_arc.Application.DTOs;
using demo_clean_arc.Domain.Entities;

namespace demo_clean_arc.Application.Mapping
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
