

using MoviesAndCriticsTogetherSite.Models.Entities;

namespace MoviesAndCriticsTogetherSite.Models.Dtos.Comments.Responses;

public sealed record CommentResponseDto(
    Guid Id,
    string? Title,
    string? Description,
    User? User,
    DateTime CreatedDate
    );