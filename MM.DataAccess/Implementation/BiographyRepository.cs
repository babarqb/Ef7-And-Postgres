using MM.DataAccess.Context;
using MM.Domain.Entities;
using MM.Domain.Repositories;

namespace MM.DataAccess.Implementation;

public class BiographyRepository:GenericRepository<Biography>,IBiographyRepository
{
    public BiographyRepository(MovieManagementDbContext context) : base(context)
    {
    }
}