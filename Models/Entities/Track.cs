using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Template.Models.Entities;

[Table("tracks")]
public class Track : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("music_release_id")]
    public long MusicReleaseId { get; set; }

    [Column("number")]
    public int Number { get; set; }

    [Column("title")]
    public string Title { get; set; } = "";

    [Column("duration")]
    public TimeSpan Duration { get; set; }

    [Column("side")]
    public string Side { get; set; } = "A";

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }
}