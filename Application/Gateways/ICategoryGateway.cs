using Domain.models;

namespace Application.Gateways
{
    public interface ICategoryGateway
    {
        Task<Category> Create(Category entity);
    }
}