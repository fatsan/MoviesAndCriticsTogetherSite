using MoviesAndCriticsTogetherSite.Models.Entities;

namespace MoviesAndCriticsTogetherSite.Models.Dtos.Movies.Request;

public sealed record UpdateMovieRequest(Guid Id, string Title, TimeSpan Length, DateTime ReleaseYear, Artist Director);
