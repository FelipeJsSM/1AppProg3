using Application.Dtos;

namespace Application.Repositories
{
    public sealed class ProductRepository
    {
        private ProductRepository() { }

        public static ProductRepository Instance { get; } = new();

        public ProductListDto ProductList { get; set; } = new() { DairyProducts = new(), Fruits = new(), Vegetables = new() };
    }
}
