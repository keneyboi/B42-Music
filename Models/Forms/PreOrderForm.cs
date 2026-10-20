using System.ComponentModel.DataAnnotations;

namespace Template.Models.Forms;

public class PreOrderForm
{
    [Required(ErrorMessage = "Recipient name is required.")]
    [StringLength(80, MinimumLength = 2, ErrorMessage = "Name must be 2 to 80 characters.")]
    public string FullName { get; set; } = "";

    [Required(ErrorMessage = "Contact email is required.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Select a catalog number.")]
    [RegularExpression(@"^A24-MUS-\d{3}$", ErrorMessage = "Catalog number must match A24-MUS-000.")]
    public string CatalogNumber { get; set; } = "";

    [Range(1, 5, ErrorMessage = "Quantity must be between 1 and 5.")]
    public int Quantity { get; set; } = 1;

    [Required(ErrorMessage = "Shipping address is required.")]
    [MinLength(10, ErrorMessage = "Address must be at least 10 characters.")]
    public string ShippingAddress { get; set; } = "";

    [MaxLength(300, ErrorMessage = "Notes are limited to 300 characters.")]
    public string? Notes { get; set; }

    [Range(typeof(bool), "true", "true", ErrorMessage = "Acknowledge the pressing terms to proceed.")]
    public bool AcceptTerms { get; set; }
}