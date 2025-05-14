using Application.Dtos;
using Application.Enums;
using Application.Repositories;

namespace Application.Services
{
    public class ProductService
    {   
        public void Add(ProductDto dto)//DTO - Data transfer object
        {
            switch (dto.Type)
            {
                case (int)ProductType.FRUITS:
                    ProductRepository.Instance.ProductList.Fruits.Add(dto);
                    break;
                case (int)ProductType.VEGETABLES:
                    ProductRepository.Instance.ProductList.Vegetables.Add(dto);
                    break;
                case (int)ProductType.DAIRY_PRODUCTS:
                    ProductRepository.Instance.ProductList.DairyProducts.Add(dto);
                    break;
                default:
                    ProductRepository.Instance.ProductList.Fruits.Add(dto);
                    break;
            }
        }

        public ProductListDto GetAll()
        {
           return ProductRepository.Instance.ProductList;
        }
    }
}
