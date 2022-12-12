using MM.DataAccess.Context;
using MM.Domain.Entities;
using MM.Domain.Repositories;

namespace MM.DataAccess.Implementation;

public class GenreRepository:GenericRepository<Genre>,IGenreRepository
{
    public GenreRepository(MovieManagementDbContext context) : base(context)
    {
    }
}