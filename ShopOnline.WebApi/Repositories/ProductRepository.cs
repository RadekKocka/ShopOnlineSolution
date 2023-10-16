using Microsoft.EntityFrameworkCore;
using ShopOnline.WebApi.Data;
using ShopOnline.WebApi.Entitities;
using ShopOnline.WebApi.Repositories.Contracts;

namespace ShopOnline.WebApi.Repositories;

public class ProductRepository : IPoductRepository
{
    private readonly ShopOnlineDBContext dbContext;

    public ProductRepository(ShopOnlineDBContext context)
    {
        dbContext = context;
    }
    public async Task<IEnumerable<ProductCategory>> GetCategories()
    {
        return await dbContext.ProductCategories.ToListAsync();
    }

    public async Task<Product> GetProduct(int id)
    {
        var product = await dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        return product ?? throw new Exception();
    }

    public async Task<ProductCategory> GetProductCategory(int id)
    {
        var category = await dbContext.ProductCategories.FirstOrDefaultAsync(x => x.Id == id);
        return category ?? throw new Exception();
    }

    public async Task<IEnumerable<Product>> GetProducts()
    {
        return await dbContext.Products.Include(x => x.ProductCategoryLink).ToListAsync();
    }
}
