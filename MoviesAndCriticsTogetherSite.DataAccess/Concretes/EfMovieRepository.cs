
using Core.Repositories;
using MoviesAndCriticsTogetherSite.DataAccess.Abstracts;
using MoviesAndCriticsTogetherSite.DataAccess.Contexts;
using MoviesAndCriticsTogetherSite.Models.Entities;

namespace MoviesAndCriticsTogetherSite.DataAccess.Concretes;

public class EfMovieRepository : EfRepositoryBase<BaseDbContext, Movie, Guid>, IMovieRepository
{
    public EfMovieRepository(BaseDbContext context) : base(context)
    {
    }
}
