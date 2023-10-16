﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ShopOnline.WebApi.Entitities;

public class Product
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }
    public decimal Price { get; set; }
    public int Qty { get; set; }
    public int CategoryId { get; set; }

    [JsonIgnore]
    [ForeignKey(nameof(CategoryId))]
    public virtual ProductCategory ProductCategoryLink { get; set; }
}
