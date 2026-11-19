
using System.Text.Json.Serialization;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Template.Models.Entities;

[Table("music_releases")]
public class MusicRelease : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("catalog_number")]
    public string CatalogNumber { get; set; } = "";

    [Column("title")]
    public string Title { get; set; } = "";

    [Column("artist_id")]
    public long ArtistId { get; set; }

    [JsonIgnore]
    public Artist? Artist { get; set; }

    [Column("release_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ReleaseType ReleaseType { get; set; }

    [Column("format")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ReleaseFormat Format { get; set; }

    [Column("release_date")]
    public DateOnly ReleaseDate { get; set; }

    [Column("price")]
    public decimal Price { get; set; }

    [Column("is_featured")]
    public bool IsFeatured { get; set; }

    [Column("matrix_code")]
    public string MatrixCode { get; set; } = "";

    [Column("cover_image")]
    public string? CoverImage { get; set; }

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }

    [JsonIgnore]
    public List<Track> Tracks { get; set; } = new();

    [JsonIgnore]
    public int TrackCount => Tracks.Count;

    [JsonIgnore]
    public TimeSpan Duration => TimeSpan.FromSeconds(Tracks.Sum(t => t.Duration.TotalSeconds));
}