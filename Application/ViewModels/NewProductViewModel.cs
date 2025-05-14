using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class NewProductViewModel
    {
        [Required(ErrorMessage = "You must enter the name of the product")]
        public required string Name { get; set; }

        public string? Description { get; set; } //nullable

        [Required(ErrorMessage = "You must enter the price of the product")]
        public required double Price { get; set; }

        [Required(ErrorMessage = "You must enter the type of the product")]
        public required int Type { get; set; }
    }
}
