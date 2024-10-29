
namespace MoviesAndCriticsTogetherSite.Models.Dtos.Artists.Requests;

public sealed record UpdateArtistRequest(Guid Id,string FullName, string NickName, DateTime Birthday);
