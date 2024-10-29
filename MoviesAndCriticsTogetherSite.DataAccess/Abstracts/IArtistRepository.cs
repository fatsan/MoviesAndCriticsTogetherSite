
using Core.Repositories;
using MoviesAndCriticsTogetherSite.Models.Entities;

namespace MoviesAndCriticsTogetherSite.DataAccess.Abstracts;

public interface IArtistRepository : IRepository<Artist,Guid>
{
}
