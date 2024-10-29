

namespace MoviesAndCriticsTogetherSite.Models.Dtos.Users.Requests;

public sealed record CreateUserRequest(string Email,
                                string UserName,
                                string Password);
