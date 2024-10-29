

using MoviesAndCriticsTogetherSite.Models.Entities;

namespace MoviesAndCriticsTogetherSite.Models.Dtos.Comments.Requests;

public sealed record CreateCommentRequest(
    string? Title,
    string? Description,
    User? User
    );

