using MM.DataAccess.Context;
using MM.Domain.Entities;
using MM.Domain.Repositories;

namespace MM.DataAccess.Implementation;

public class ActorRepository:GenericRepository<Actor>,IActorRepository
{
    public ActorRepository(MovieManagementDbContext context) : base(context)
    {
    }
}