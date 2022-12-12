using Microsoft.EntityFrameworkCore;
using MM.DataAccess.Context;
using MM.Domain.Entities;
using MM.Domain.Repositories;

namespace MM.DataAccess.Implementation;

public class ActorRepository:GenericRepository<Actor>,IActorRepository
{
    private readonly MovieManagementDbContext _context;

    public ActorRepository(MovieManagementDbContext context) : base(context)
    {
        _context = context;
    }

    public IEnumerable<Actor> GetActorsWithMovies()
    {
        var actors = _context.Actors.Include(a => a.Movies).ToList();
        return actors;
    }
}