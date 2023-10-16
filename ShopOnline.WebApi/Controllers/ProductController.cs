using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopOnline.Models.Dtos;
using ShopOnline.WebApi.Entitities;
using ShopOnline.WebApi.Extensions;
using ShopOnline.WebApi.Repositories.Contracts;
using System.Linq;

namespace ShopOnline.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IPoductRepository products;
        public ProductController(IPoductRepository productRepository)
        {
            products = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            try
            {
                var productItems = await products.GetProducts();

                if (productItems == null)
                {
                    return NotFound();
                }

                var items = productItems.ConvertProducts();

                return Ok(items);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,"Error retrieving items from database");
            }
            
        }
    }
}
