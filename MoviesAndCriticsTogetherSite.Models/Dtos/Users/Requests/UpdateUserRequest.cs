

namespace MoviesAndCriticsTogetherSite.Models.Dtos.Users.Requests;

public sealed record UpdateUserRequest(Guid Id, string Email,string UserName,string Password);