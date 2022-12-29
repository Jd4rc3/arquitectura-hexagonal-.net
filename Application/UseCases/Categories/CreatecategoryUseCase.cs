using Application.Gateways;
using Domain.models;

namespace Application.UseCases.Categories
{
    public class CreatecategoryUseCase
    {
        private readonly ICategoryGateway Gateway;

        public CreatecategoryUseCase(ICategoryGateway gateway)
        {
            Gateway = gateway;
        }

        public async Task<Category> apply(Category entity)
        {
            var category = await Gateway.Create(entity);
            return category;
        }
    }
}