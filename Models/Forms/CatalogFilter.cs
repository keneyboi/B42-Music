namespace Template.Models.Forms;

public class CatalogFilter
{
    public string? Query { get; set; }
    public ReleaseFormat? Format { get; set; }
    public ReleaseType? ReleaseType { get; set; }
    public int? ArtistId { get; set; }
    public CatalogSort Sort { get; set; } = CatalogSort.CatalogNo;
}