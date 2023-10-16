using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ShopOnline.WebApi.Entitities;

public class User
{
    [Key]
    public int Id { get; set; }
    public string UserName { get; set; }

    public virtual Cart? CartLink { get; set; }
}
