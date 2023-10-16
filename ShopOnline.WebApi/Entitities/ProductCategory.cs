
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ShopOnline.WebApi.Entitities;

public class ProductCategory
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string IconCSS { get; set; }

    [JsonIgnore]
    [InverseProperty(nameof(Product.ProductCategoryLink))]
    public virtual ICollection<Product>? Products { get; set; }
}
