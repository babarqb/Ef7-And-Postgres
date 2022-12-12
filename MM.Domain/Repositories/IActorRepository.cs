using MM.Domain.Entities;

namespace MM.Domain.Repositories;

public interface IActorRepository : IGenericRepository<Actor>
{
    IEnumerable<Actor> GetActorsWithMovies();

}