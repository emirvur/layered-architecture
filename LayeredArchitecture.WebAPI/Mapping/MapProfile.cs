using AutoMapper;
using LayeredArchitecture.Core.Models;
using LayeredArchitecture.WebAPI.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredArchitecture.WebAPI.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Category, CategoryWithProductDto>();
            CreateMap<CategoryWithProductDto, Category>();

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();

            CreateMap<Product, ProductWithCategoryDto>();

            CreateMap<ProductWithCategoryDto, Product>();
        }
    }
}
