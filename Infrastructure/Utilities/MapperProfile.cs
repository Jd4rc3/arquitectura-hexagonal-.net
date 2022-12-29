using AutoMapper;
using Domain.models;
using Infrastructure.Dtos;

namespace Infrastructure.Utilities
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CreateCategoryDto, Category>();
            CreateMap<Category, CategoryDto>();
        }

    }
}