using System.ComponentModel.DataAnnotations;

namespace ShopOnline.WebApi.Entitities
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
