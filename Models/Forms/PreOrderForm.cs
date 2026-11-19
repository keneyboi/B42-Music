using System.ComponentModel.DataAnnotations;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Template.Models.Forms;

[Table("pre_orders")]
public class PreOrderForm : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("full_name")]
    [Required(ErrorMessage = "Recipient name is required.")]
    [StringLength(80, MinimumLength = 2, ErrorMessage = "Name must be 2 to 80 characters.")]
    public string FullName { get; set; } = "";

    [Column("email")]
    [Required(ErrorMessage = "Contact email is required.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = "";

    [Column("catalog_number")]
    [Required(ErrorMessage = "Select a catalog number.")]
    [RegularExpression(@"^A24-MUS-\d{3}$", ErrorMessage = "Catalog number must match A24-MUS-000.")]
    public string CatalogNumber { get; set; } = "";

    [Column("quantity")]
    [Range(1, 5, ErrorMessage = "Quantity must be between 1 and 5.")]
    public int Quantity { get; set; } = 1;

    [Column("shipping_address")]
    [Required(ErrorMessage = "Shipping address is required.")]
    [MinLength(10, ErrorMessage = "Address must be at least 10 characters.")]
    public string ShippingAddress { get; set; } = "";

    [Column("notes")]
    [MaxLength(300, ErrorMessage = "Notes are limited to 300 characters.")]
    public string? Notes { get; set; }

    [Column("accept_terms")]
    [Range(typeof(bool), "true", "true", ErrorMessage = "Acknowledge the pressing terms to proceed.")]
    public bool AcceptTerms { get; set; }

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }
}