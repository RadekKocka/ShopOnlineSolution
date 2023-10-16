using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ShopOnline.WebApi.Entitities;

public class CartItem
{
    public int Id { get; set; }
    public int CartId { get; set; }
    public int ProductId { get; set; }
    public int Qty { get; set; }

    [JsonIgnore]
    [ForeignKey(nameof(ProductId))]
    public virtual Product ProductLink { get; set; }

    [JsonIgnore]
    [ForeignKey(nameof(CartId))]
    public virtual Cart CartLink { get; set; }
}
