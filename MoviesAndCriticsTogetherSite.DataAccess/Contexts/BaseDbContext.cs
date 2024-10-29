
using Microsoft.EntityFrameworkCore;
using MoviesAndCriticsTogetherSite.Models.Entities;

namespace MoviesAndCriticsTogetherSite.DataAccess.Contexts;

public class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions opt) : base(opt)
    {

    }

    public DbSet<Artist> Artists { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<User> Users { get; set; }

}
