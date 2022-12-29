using Domain.Enums;

namespace Infrastructure.Dtos
{
    public class CategoryDto
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public Status Status { get; init; }
    }
}