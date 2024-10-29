

using Core.Repositories;
using MoviesAndCriticsTogetherSite.DataAccess.Abstracts;
using MoviesAndCriticsTogetherSite.DataAccess.Contexts;
using MoviesAndCriticsTogetherSite.Models.Entities;

namespace MoviesAndCriticsTogetherSite.DataAccess.Concretes;

public class EfUserRepository : EfRepositoryBase<BaseDbContext, User, Guid>, IUserRepository
{
    public EfUserRepository(BaseDbContext context) : base(context)
    {
    }
}
