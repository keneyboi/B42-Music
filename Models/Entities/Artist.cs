namespace Template.Models.Entities;

public class Artist
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Bio { get; set; } = "";
    public string Genre { get; set; } = "";
    public ArtistStatus Status { get; set; }
    public int CatalogCount { get; set; }
    public string? AssociatedProject { get; set; }
    public List<string> Tags { get; set; } = new();
}