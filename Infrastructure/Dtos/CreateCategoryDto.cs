using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Dtos
{
    public class CreateCategoryDto
    {
        [Required(ErrorMessage = "{0} is required")]
        public string Name { get; set; }
    }
}