

namespace MoviesAndCriticsTogetherSite.Models.Dtos.Users.Responses;
public sealed record UserResponseDto(
    Guid Id,
    string Email,
    string UserName,
    string Password,
    DateTime CreatedDate
    );