using Microsoft.EntityFrameworkCore;
using ShopOnline.Models.Dtos;
using ShopOnline.WebApi.Entitities;

namespace ShopOnline.WebApi.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDto> ConvertProducts(this IEnumerable<Product> products)
        {
            return products.Select(p => new ProductDto()
            {
                Name = p.Name,
                CategoryName = p.ProductCategoryLink.Name,
                Description = p.Description,
                ImageURL = p.ImageURL,
                Price = p.Price,
                Qty = p.Qty,
            });
        }
    }
}
