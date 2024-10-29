
using Core.Repositories;
using MoviesAndCriticsTogetherSite.Models.Entities;

namespace MoviesAndCriticsTogetherSite.DataAccess.Abstracts;

public interface ICommentRepository : IRepository<Comment,Guid>
{
}
