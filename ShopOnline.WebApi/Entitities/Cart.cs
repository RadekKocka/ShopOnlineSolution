using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ShopOnline.WebApi.Entitities;

public class Cart
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    [Required]
    public virtual User UserLink { get; set; }

    [JsonIgnore]
    [InverseProperty(nameof(CartItem.CartLink))]
    public virtual IEnumerable<CartItem>? CartItems { get; set;}
}
