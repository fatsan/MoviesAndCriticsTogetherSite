using MoviesAndCriticsTogetherSite.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAndCriticsTogetherSite.Models.Dtos.Movies.Request;

public sealed record CreateMovieRequest(string Title, TimeSpan Length,DateTime ReleaseYear, Artist Director);
