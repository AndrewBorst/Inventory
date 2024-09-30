using System.ComponentModel.DataAnnotations;

namespace Inventory.Data;

public class InventoryItem
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Location { get; set; }
    public int Quantity { get; set; }
    public decimal Value { get; set; }
    public string? ImageUrl { get; set; }
    public string? Comments { get; set; }

}

