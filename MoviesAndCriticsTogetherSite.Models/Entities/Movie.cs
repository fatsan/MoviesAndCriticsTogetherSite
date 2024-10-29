

using Core.Entities;
using System.Reflection.Metadata;

namespace MoviesAndCriticsTogetherSite.Models.Entities;

public class Movie : Entity<Guid>
{

    public string? Title { get; set; }
    public TimeSpan Length { get; set; }
    public DateTime ReleaseYear { get; set; }
    public Artist? Director { get; set; }


}
