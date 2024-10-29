

using Core.Entities;
using System.Reflection.Metadata;

namespace MoviesAndCriticsTogetherSite.Models.Entities;

public class Artist : Entity<Guid>
{

    public string FullName { get; set; }
    public string? NickName { get; set; }
    public DateTime Birthday { get; set; }

}
