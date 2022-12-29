using Application.Gateways;
using Domain;
using Domain.models;

namespace Infrastructure.Adapters
{
    public class CategoryAdapter : ICategoryGateway
    {
        private readonly Context context;

        public CategoryAdapter(Context context)
        {
            this.context = context;
        }

        public async Task<Category> Create(Category entity)
        {
            var category = context.Categories.Add(entity);

            await context.SaveChangesAsync();

            return category.Entity;
        }
    }
}