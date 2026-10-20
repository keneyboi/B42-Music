namespace Template.Models.Entities;

public class MusicRelease
{
    public int Id { get; set; }
    public string CatalogNumber { get; set; } = "";
    public string Title { get; set; } = "";
    public int ArtistId { get; set; }
    public Artist? Artist { get; set; }
    public ReleaseType ReleaseType { get; set; }
    public ReleaseFormat Format { get; set; }
    public DateOnly ReleaseDate { get; set; }
    public decimal Price { get; set; }
    public bool IsFeatured { get; set; }
    public string MatrixCode { get; set; } = "";
    public List<Track> Tracks { get; set; } = new();
    public int TrackCount => Tracks.Count;
    public TimeSpan Duration => TimeSpan.FromSeconds(Tracks.Sum(t => t.Duration.TotalSeconds));
    public string? CoverImage { get; set; }
}