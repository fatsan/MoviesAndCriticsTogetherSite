

using MoviesAndCriticsTogetherSite.Models.Entities;

namespace MoviesAndCriticsTogetherSite.Models.Dtos.Movies.Responses;

public sealed record MovieResponseDto(
    Guid Id,
    string? Title,
    TimeSpan Length,     
    DateTime ReleaseYear,
    Artist? Director ,   
    DateTime CreatedDate
    );