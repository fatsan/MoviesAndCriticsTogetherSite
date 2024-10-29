

using Core.Repositories;
using MoviesAndCriticsTogetherSite.DataAccess.Abstracts;
using MoviesAndCriticsTogetherSite.DataAccess.Contexts;
using MoviesAndCriticsTogetherSite.Models.Entities;

namespace MoviesAndCriticsTogetherSite.DataAccess.Concretes;

public class EfCommentRepository : EfRepositoryBase<BaseDbContext, Comment, Guid>, ICommentRepository
{
    public EfCommentRepository(BaseDbContext context) : base(context)
    {
    }
}
