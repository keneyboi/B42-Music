using System.Text.Json.Serialization;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Template.Models.Entities;

[Table("artists")]
public class Artist : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = "";

    [Column("bio")]
    public string Bio { get; set; } = "";

    [Column("genre")]
    public string Genre { get; set; } = "";

    [Column("status")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ArtistStatus Status { get; set; }

    [Column("catalog_count")]
    public int CatalogCount { get; set; }

    [Column("associated_project")]
    public string? AssociatedProject { get; set; }

    [Column("tags")]
    public List<string> Tags { get; set; } = new();

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }
}