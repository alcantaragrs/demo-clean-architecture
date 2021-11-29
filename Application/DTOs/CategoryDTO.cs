using System.ComponentModel.DataAnnotations;

namespace demo_clean_arc.Application.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The name is required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
