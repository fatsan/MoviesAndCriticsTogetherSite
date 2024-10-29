

using Core.Entities;

namespace MoviesAndCriticsTogetherSite.Models.Entities;

public class User : Entity<Guid>
{

    public string Email { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}
