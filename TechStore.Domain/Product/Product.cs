using System.ComponentModel.DataAnnotations;

namespace TechStore.Domain.Product;

public class Product
{

    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    [MinLength(3)]
    public string Name { get; set; } = string.Empty;
    [Required]
    [MaxLength(500)]
    [MinLength(10)]
    public string Description { get; set; } = string.Empty;
    [Required]
    public decimal Price { get; set; }
    [Required]
    public string UserId { get; set; } = string.Empty;



}
