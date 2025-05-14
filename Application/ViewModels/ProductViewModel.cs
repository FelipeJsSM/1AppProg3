namespace Application.ViewModels
{
    public class ProductViewModel
    {
        public required string Name { get; set; }

        public string? Description { get; set; } //nullable

        public required double Price { get; set; }

        public required int Type { get; set; }
    }
}
