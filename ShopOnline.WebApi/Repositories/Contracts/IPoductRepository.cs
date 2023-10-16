using ShopOnline.WebApi.Entitities;

namespace ShopOnline.WebApi.Repositories.Contracts;

public interface IPoductRepository
{
    Task<IEnumerable<Product>> GetProducts();
    Task<IEnumerable<ProductCategory>> GetCategories();
    Task<Product> GetProduct(int id);
    Task<ProductCategory> GetProductCategory(int id);
}
