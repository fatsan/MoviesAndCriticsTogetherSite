
using Core.Repositories;
using MoviesAndCriticsTogetherSite.DataAccess.Abstracts;
using MoviesAndCriticsTogetherSite.DataAccess.Contexts;
using MoviesAndCriticsTogetherSite.Models.Entities;

namespace MoviesAndCriticsTogetherSite.DataAccess.Concretes;

public class EfArtistRepository : EfRepositoryBase<BaseDbContext, Artist, Guid>, IArtistRepository
{
    public EfArtistRepository(BaseDbContext context) : base(context)
    {
    }
}
