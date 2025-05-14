namespace Application.ViewModels
{
    public class ProductListViewModel
    {
        public required List<ProductViewModel> Fruits { get; set; }
        public required List<ProductViewModel> Vegetables { get; set; }
        public required List<ProductViewModel> DairyProducts { get; set; }
    }
}
