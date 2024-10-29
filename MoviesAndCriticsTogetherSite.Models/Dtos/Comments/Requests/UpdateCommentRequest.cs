

using MoviesAndCriticsTogetherSite.Models.Entities;

namespace MoviesAndCriticsTogetherSite.Models.Dtos.Comments.Requests;

public sealed record UpdateCommentRequest(
    Guid Id,
    string? Title,
    string? Description,
    User? User
    );