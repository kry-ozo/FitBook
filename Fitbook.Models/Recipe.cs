using System.ComponentModel.DataAnnotations;

namespace FitBook.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Steps { get; set; }
        [Required]
        public int Protein { get; set; }
        [Required]
        public int Fats { get; set; }
        [Required]
        public int Carbs { get; set; }
    }
}
