using MM.DataAccess.Context;
using MM.Domain.Repositories;

namespace MM.DataAccess.Implementation;

public class UnitOfWork : IUnitOfWork
{
    private readonly MovieManagementDbContext _context;

    public UnitOfWork(MovieManagementDbContext context)
    {
        _context = context;
        Actors = new ActorRepository(_context);
        Movies = new MovieRepository(_context);
        Biographies = new BiographyRepository(_context);
        Genres = new GenreRepository(_context);
    }

    public IActorRepository Actors { get; private set; }
    public IMovieRepository Movies { get; private set; }
    public IBiographyRepository Biographies { get; private set; }
    public IGenreRepository Genres { get; private set; }

    public int Save()
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}