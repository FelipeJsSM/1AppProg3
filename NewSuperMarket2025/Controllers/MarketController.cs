using Application.Dtos;
using Application.Services;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace NewSuperMarket2025.Controllers
{
    public class MarketController : Controller
    {
        private readonly ProductService _productService;

        public MarketController()
        {
            _productService = new ProductService();
        }
        public IActionResult Index(string? message = null, string? messageType = null)
        {
            ProductListDto productListDto = _productService.GetAll();

            ProductListViewModel productListViewModel = new()
            {
                DairyProducts = productListDto.DairyProducts.Select(s =>
                new ProductViewModel
                {
                    Description = s.Description,
                    Name = s.Name,
                    Price = s.Price,
                    Type = s.Type,
                }).ToList(),
                Fruits = productListDto.Fruits.Select(s =>
                new ProductViewModel
                {
                    Description = s.Description,
                    Name = s.Name,
                    Price = s.Price,
                    Type = s.Type,
                }).ToList(),
                Vegetables = productListDto.Vegetables.Select(s =>
                new ProductViewModel
                {
                    Description = s.Description,
                    Name = s.Name,
                    Price = s.Price,
                    Type = s.Type,
                }).ToList()
            };

            ViewBag.Message = message;
            ViewBag.MessageType = messageType;

            return View(productListViewModel);
        }
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(NewProductViewModel vm)
        {
            try {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                _productService.Add(new ProductDto()
                {
                    Name = vm.Name,
                    Price = vm.Price,
                    Type = vm.Type,
                    Description = vm.Description,
                });

                return RedirectToRoute(new { controller = "Market", action = "Index", message = "Product created successfully", messageType="alert-success" });//dynamic
            }
            catch(Exception ex)
            {
                return RedirectToRoute(new { controller = "Market", action = "Index", message = "Product creation failed", messageType = "alert-danger" });//dynamic
            }
           
        }
    }
}
