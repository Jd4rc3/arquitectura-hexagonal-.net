using Application.UseCases.Categories;
using AutoMapper;
using Domain.models;
using Infrastructure.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Controllers
{
    [ApiController]
    [Route("api/v1/category")]
    public class CategoryController : ControllerBase
    {
        private readonly CreatecategoryUseCase createcategory;
        public readonly IMapper Mapper;

        public CategoryController(CreatecategoryUseCase createcategory, IMapper mapper)
        {
            this.Mapper = mapper;
            this.createcategory = createcategory;
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateCategoryDto categoryDto)
        {
            var category = await createcategory.apply(Mapper.Map<Category>(categoryDto));

            return Ok(category);
        }
    }
}