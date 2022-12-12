using MM.DataAccess.Context;
using MM.Domain.Entities;
using MM.Domain.Repositories;

namespace MM.DataAccess.Implementation;

public class MovieRepository:GenericRepository<Movie>,IMovieRepository
{
    public MovieRepository(MovieManagementDbContext context) : base(context)
    {
    }
}