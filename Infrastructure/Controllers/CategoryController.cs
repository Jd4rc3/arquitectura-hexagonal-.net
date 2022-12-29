using Application.UseCases.Categories;
using Domain.models;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Controllers
{
    [ApiController]
    [Route("api/v1/category")]
    public class CategoryController : ControllerBase
    {
        private readonly CreatecategoryUseCase createcategory;

        public CategoryController(CreatecategoryUseCase createcategory)
        {
            this.createcategory = createcategory;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Category categoryDto)
        {
            var category = await createcategory.apply(categoryDto);

            return Ok(category);
        }
    }
}