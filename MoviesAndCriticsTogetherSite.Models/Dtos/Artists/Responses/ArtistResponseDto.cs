

namespace MoviesAndCriticsTogetherSite.Models.Dtos.Artists.Responses;

public sealed record ArtistResponseDto(
    Guid Id,
    string FullName,
    string? NickName,
    DateTime Birthday,
    DateTime CreatedDate
    );