using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.models
{
    public record Category
    {
        [Key]
        public int Id { get; init; }
        [Required]
        public string Name { get; init; }
        [Required]
        public Status Status { get; init; }
    }
}