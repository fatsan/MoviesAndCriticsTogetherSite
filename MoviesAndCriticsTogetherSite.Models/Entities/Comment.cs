

using Core.Entities;

namespace MoviesAndCriticsTogetherSite.Models.Entities;

public class Comment : Entity<Guid>
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public User? User { get; set; }
}
