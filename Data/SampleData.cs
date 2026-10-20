using System.Text.RegularExpressions;
using Template.Models;
using Template.Models.Entities;

namespace Template.Data;

public static class SampleData
{
    public static readonly List<Artist> Artists = new()
    {
        new() { Id = 1, Name = "Olivia Dean", Genre = "Neo-Soul / Pop", Status = ArtistStatus.OnTour, CatalogCount = 2,
            AssociatedProject = "THE ART OF LOVING (2025)", Tags = { "Soul", "Vocals", "BRIT School" },
            Bio = "London-born singer-songwriter celebrated for her warm soul vocals, Motown-inspired arrangements, and intimate lyricism." },
        new() { Id = 2, Name = "The 1975", Genre = "Indie Pop / Art Rock", Status = ArtistStatus.Active, CatalogCount = 2,
            Tags = { "Synth-Pop", "Live", "Alternative" },
            Bio = "Four-piece band formed in Manchester known for blending pop hooks, ambient textures, and eclectic genre-hopping." },
        new() { Id = 3, Name = "Malcolm Todd", Genre = "Indie R&B / Bed Pop", Status = ArtistStatus.UpcomingRelease, CatalogCount = 2,
            AssociatedProject = "DO THAT AGAIN (2026)", Tags = { "Groove", "Guitar", "Lo-Fi" },
            Bio = "Los Angeles singer and multi-instrumentalist crafting smooth, bass-driven indie pop and laid-back alternative R&B." },
        new() { Id = 4, Name = "NIKI", Genre = "R&B / Indie Pop", Status = ArtistStatus.Active, CatalogCount = 1,
            Tags = { "88rising", "Acoustic", "Producer" },
            Bio = "Jakarta-born, LA-based singer-songwriter and producer known for nostalgia-infused acoustic folk and polished R&B." },
        new() { Id = 5, Name = "Dominic Fike", Genre = "Indie Rock / Alternative", Status = ArtistStatus.Active, CatalogCount = 2,
            AssociatedProject = "SUNBURN (2023)", Tags = { "Guitar", "Rap Rock", "Singer-Songwriter" },
            Bio = "Florida-born singer, rapper, and multi-instrumentalist blending energetic pop-punk chords with melodic hip-hop flows." },
        new() { Id = 6, Name = "Laufey", Genre = "Traditional Pop / Jazz", Status = ArtistStatus.OnTour, CatalogCount = 1,
            AssociatedProject = "BEWITCHED (2023)", Tags = { "Jazz", "Cello", "Orchestral" },
            Bio = "Icelandic-Chinese singer-songwriter modernizing classic jazz, bossa nova, and bedroom pop for young generations." },
        new() { Id = 7, Name = "Wallows", Genre = "Indie Rock / Alternative", Status = ArtistStatus.Active, CatalogCount = 1,
            AssociatedProject = "MODEL (2024)", Tags = { "Post-Punk", "Guitar", "Indie Pop" },
            Bio = "Los Angeles-based trio crafting breezy, post-punk influenced indie rock with catchy synth and double-guitar riffs." },
        new() { Id = 8, Name = "Clairo", Genre = "Bed Pop / Folk", Status = ArtistStatus.Active, CatalogCount = 1,
            AssociatedProject = "CHARM (2024)", Tags = { "Lo-Fi", "Acoustic", "Analog" },
            Bio = "American singer-songwriter who transitioned from bedroom pop virality to warm, vintage analog jazz-folk arrangements." },
        new() { Id = 9, Name = "Gracie Abrams", Genre = "Indie Pop / Singer-Songwriter", Status = ArtistStatus.OnTour, CatalogCount = 2,
            AssociatedProject = "THE SECRET OF US (2024)", Tags = { "Acoustic", "Bedroom Pop", "Lyrics" },
            Bio = "Grammy-nominated American singer-songwriter known for whisper-soft vocals, vulnerable songwriting, and acoustic introspections." },
        new() { Id = 10, Name = "Beabadoobee", Genre = "Indie Rock / Pop Rock", Status = ArtistStatus.Active, CatalogCount = 2,
            Tags = { "90s Alt", "Fuzz Guitar", "Dirty Hit" },
            Bio = "Filipino-British singer-songwriter weaving nostalgic 90s alt-rock fuzz, bedroom pop acoustic hooks, and soft vocals." },
        new() { Id = 11, Name = "Conan Gray", Genre = "Synth-Pop / Pop", Status = ArtistStatus.Active, CatalogCount = 1,
            AssociatedProject = "FOUND HEAVEN (2024)", Tags = { "80s Pop", "Glam Rock", "Falsetto" },
            Bio = "American singer-songwriter who evolved from bedroom acoustic pop to grand 80s glam synth-pop anthems." },
        new() { Id = 12, Name = "Sabrina Carpenter", Genre = "Pop / Dance-Pop", Status = ArtistStatus.OnTour, CatalogCount = 2,
            AssociatedProject = "SHORT N' SWEET (2024)", Tags = { "Chart-Topper", "Disco", "Witty" },
            Bio = "American singer and actress renowned for witty lyrical hooks, breezy pop melodies, and viral chart success." },
    };

    public static readonly List<MusicRelease> Releases = Build();

    static List<Track> Tr(params (string t, int s)[] x) =>
        x.Select((v, i) => new Track { Number = i + 1, Title = v.t, Duration = TimeSpan.FromSeconds(v.s), Side = i < (x.Length + 1) / 2 ? "A" : "B" }).ToList();

    static List<MusicRelease> Build()
    {
        var list = new List<MusicRelease>
        {
            new() { Id = 1, CatalogNumber = "CAP-OLV-001", CoverImage = "/images/covers/mus001.jpg", Title = "Messy", ArtistId = 1, ReleaseType = ReleaseType.StudioAlbum, Format = ReleaseFormat.Vinyl,
                ReleaseDate = new(2023, 6, 30), Price = 32.00m, IsFeatured = true, MatrixCode = "OLV001-A1/B1",
                Tracks = Tr(("Dive", 200), ("Messy", 223), ("The Hardest Part", 174), ("Carmen", 269)) },
            new() { Id = 2, CatalogNumber = "DH-1975-001", CoverImage = "/images/covers/mus002.jpg", Title = "Being Funny in a Foreign Language", ArtistId = 2, ReleaseType = ReleaseType.StudioAlbum, Format = ReleaseFormat.Vinyl,
                ReleaseDate = new(2022, 10, 14), Price = 35.00m, IsFeatured = true, MatrixCode = "DH00278-A1/B1",
                Tracks = Tr(("Happiness", 303), ("Part of the Band", 260), ("Oh Caroline", 212), ("About You", 326)) },
            new() { Id = 3, CatalogNumber = "COL-MTD-001", CoverImage = "/images/covers/mus003.jpg", Title = "Sweet Boy", ArtistId = 3, ReleaseType = ReleaseType.StudioAlbum, Format = ReleaseFormat.CD,
                ReleaseDate = new(2024, 4, 5), Price = 18.00m, IsFeatured = true, MatrixCode = "MTD001-D1",
                Tracks = Tr(("Roommates", 185), ("Sweet Boy", 192), ("Chest Pain (I Love)", 204), ("4Me 4Me", 178)) },
            new() { Id = 4, CatalogNumber = "88R-NKI-001", CoverImage = "/images/covers/mus004.jpg", Title = "Nicole", ArtistId = 4, ReleaseType = ReleaseType.StudioAlbum, Format = ReleaseFormat.CD,
                ReleaseDate = new(2022, 8, 12), Price = 16.00m, IsFeatured = false, MatrixCode = "NKI002-D1",
                Tracks = Tr(("Before", 234), ("Oceans & Engines", 338), ("High School in Jakarta", 219), ("Backburner", 236)) },
            new() { Id = 5, CatalogNumber = "COL-DFK-001", CoverImage = "/images/covers/mus005.jpg", Title = "Sunburn", ArtistId = 5, ReleaseType = ReleaseType.StudioAlbum, Format = ReleaseFormat.Vinyl,
                ReleaseDate = new(2023, 7, 7), Price = 30.00m, IsFeatured = true, MatrixCode = "DFK001-A1/B1",
                Tracks = Tr(("How Much Is Weed?", 148), ("Mona Lisa", 188), ("Dancing In The Courthouse", 157), ("Frisky", 179)) },
            new() { Id = 6, CatalogNumber = "AWAL-LAU-001", CoverImage = "/images/covers/mus006.jpg", Title = "Bewitched", ArtistId = 6, ReleaseType = ReleaseType.StudioAlbum, Format = ReleaseFormat.Vinyl,
                ReleaseDate = new(2023, 9, 8), Price = 34.00m, IsFeatured = true, MatrixCode = "LAU001-A1/B1",
                Tracks = Tr(("Dreamer", 211), ("From The Start", 169), ("Lovesick", 225), ("Bewitched", 246)) },
            new() { Id = 7, CatalogNumber = "ATL-WAL-001", CoverImage = "/images/covers/mus007.jpg", Title = "Model", ArtistId = 7, ReleaseType = ReleaseType.StudioAlbum, Format = ReleaseFormat.CD,
                ReleaseDate = new(2024, 5, 24), Price = 17.00m, IsFeatured = false, MatrixCode = "WAL001-D1",
                Tracks = Tr(("Your Apartment", 185), ("Calling After Me", 188), ("Bad Dream", 202), ("A Warning", 174)) },
            new() { Id = 8, CatalogNumber = "CLO-CLA-001", CoverImage = "/images/covers/mus008.jpg", Title = "Charm", ArtistId = 8, ReleaseType = ReleaseType.StudioAlbum, Format = ReleaseFormat.Vinyl,
                ReleaseDate = new(2024, 7, 12), Price = 33.00m, IsFeatured = true, MatrixCode = "CLA001-A1/B1",
                Tracks = Tr(("Nomad", 244), ("Sexy to Someone", 218), ("Add Up My Love", 214), ("Terrapin", 183)) },
            new() { Id = 9, CatalogNumber = "DH-1975-002", CoverImage = "/images/covers/mus009.jpg", Title = "Happiness / I'm In Love With You", ArtistId = 2, ReleaseType = ReleaseType.Single, Format = ReleaseFormat.Vinyl,
                ReleaseDate = new(2022, 8, 3), Price = 14.00m, IsFeatured = false, MatrixCode = "DH00279-A1/B1",
                Tracks = Tr(("Happiness (Edit)", 243), ("I'm In Love With You", 262)) },
            new() { Id = 10, CatalogNumber = "CAP-OLV-002", CoverImage = "/images/covers/mus010.jpg", Title = "The Art of Loving", ArtistId = 1, ReleaseType = ReleaseType.StudioAlbum, Format = ReleaseFormat.Vinyl,
                ReleaseDate = new(2025, 9, 26), Price = 36.00m, IsFeatured = true, MatrixCode = "OLV003-A1/B1",
                Tracks = Tr(("Nice To Each Other", 201), ("Lady Lady", 195), ("Man I Need", 214), ("So Easy (To Fall In Love)", 208)) },
            new() { Id = 11, CatalogNumber = "COL-MTD-002", CoverImage = "/images/covers/mus011.jpg", Title = "Do That Again", ArtistId = 3, ReleaseType = ReleaseType.StudioAlbum, Format = ReleaseFormat.DigitalCassette,
                ReleaseDate = new(2026, 6, 5), Price = 15.00m, IsFeatured = false, MatrixCode = "MTD002-C1",
                Tracks = Tr(("Breathe", 192), ("I Saw Your Face", 186), ("Difficult Love", 201), ("Jean Skirt", 175)) },
            new() { Id = 12, CatalogNumber = "COL-DFK-002", CoverImage = "/images/covers/mus012.jpg", Title = "15 Minutes", ArtistId = 5, ReleaseType = ReleaseType.Single, Format = ReleaseFormat.CD,
                ReleaseDate = new(2024, 5, 3), Price = 11.00m, IsFeatured = false, MatrixCode = "DFK002-D1",
                Tracks = Tr(("15 Minutes", 152), ("Coast2Coast", 164)) },
            new() { Id = 13, CatalogNumber = "INT-GRA-001", CoverImage = "/images/covers/mus013.jpg", Title = "The Secret of Us", ArtistId = 9, ReleaseType = ReleaseType.StudioAlbum, Format = ReleaseFormat.Vinyl,
                ReleaseDate = new(2024, 6, 21), Price = 34.00m, IsFeatured = true, MatrixCode = "GRA001-A1/B1",
                Tracks = Tr(("Felt Good About You", 271), ("Risk", 191), ("Blowing Smoke", 254), ("i love you, i'm sorry", 157), ("us. (feat. Taylor Swift)", 298)) },
            new() { Id = 14, CatalogNumber = "DH-BEA-001", CoverImage = "/images/covers/mus014.jpg", Title = "This Is How Tomorrow Moves", ArtistId = 10, ReleaseType = ReleaseType.StudioAlbum, Format = ReleaseFormat.Vinyl,
                ReleaseDate = new(2024, 8, 9), Price = 32.00m, IsFeatured = true, MatrixCode = "DH00312-A1/B1",
                Tracks = Tr(("Take A Bite", 158), ("California", 172), ("One Time", 185), ("Real Man", 159), ("Beaches", 230)) },
            new() { Id = 15, CatalogNumber = "REP-CNG-001", CoverImage = "/images/covers/mus015.jpg", Title = "Found Heaven", ArtistId = 11, ReleaseType = ReleaseType.StudioAlbum, Format = ReleaseFormat.CD,
                ReleaseDate = new(2024, 4, 5), Price = 18.00m, IsFeatured = true, MatrixCode = "CNG001-D1",
                Tracks = Tr(("Found Heaven", 177), ("Never Ending Song", 155), ("Lonely Dancers", 149), ("Alley Rose", 208), ("Bourgeoisieses", 151)) },
            new() { Id = 16, CatalogNumber = "ISL-SAB-001", CoverImage = "/images/covers/mus016.jpg", Title = "Short n' Sweet", ArtistId = 12, ReleaseType = ReleaseType.StudioAlbum, Format = ReleaseFormat.Vinyl,
                ReleaseDate = new(2024, 8, 23), Price = 35.00m, IsFeatured = true, MatrixCode = "SAB001-A1/B1",
                Tracks = Tr(("Taste", 157), ("Please Please Please", 186), ("Bed Chem", 171), ("Espresso", 175), ("Juno", 221)) },
            new() { Id = 17, CatalogNumber = "INT-GRA-002", CoverImage = "/images/covers/mus017.jpg", Title = "Risk / Close To You", ArtistId = 9, ReleaseType = ReleaseType.Single, Format = ReleaseFormat.DigitalCassette,
                ReleaseDate = new(2024, 5, 10), Price = 12.00m, IsFeatured = false, MatrixCode = "GRA002-C1",
                Tracks = Tr(("Risk", 191), ("Close to You", 225)) },
            new() { Id = 18, CatalogNumber = "ISL-SAB-002", CoverImage = "/images/covers/mus018.jpg", Title = "Espresso (Remixes)", ArtistId = 12, ReleaseType = ReleaseType.Single, Format = ReleaseFormat.CD,
                ReleaseDate = new(2024, 5, 17), Price = 10.00m, IsFeatured = false, MatrixCode = "SAB002-D1",
                Tracks = Tr(("Espresso", 175), ("Espresso (Mark Ronson x FNA Remix)", 184)) },
        };
        foreach (var r in list) r.Artist = Artists.First(a => a.Id == r.ArtistId);
        return list;
    }

    public static string Clock(TimeSpan t) => $"{(int)t.TotalMinutes:00}:{t.Seconds:00}";
    public static string Label(Enum e) => Regex.Replace(e.ToString(), "(?<=[a-z])(?=[A-Z])", " ");
}