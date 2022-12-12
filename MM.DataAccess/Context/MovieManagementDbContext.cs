using Microsoft.EntityFrameworkCore;
using MM.Domain.Entities;

namespace MM.DataAccess.Context;

public class MovieManagementDbContext : DbContext
{
    public MovieManagementDbContext(DbContextOptions<MovieManagementDbContext> options):base(options){}
        

    public DbSet<Actor> Actors { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Biography> Biographies { get; set; }
    public DbSet<Genre> Genres { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>().HasData(
            new Actor{ Id = 1, FirstName = "Tom", LastName = "Cruise" },
            new Actor{ Id = 2, FirstName = "Jon", LastName = "Travolta" },
            new Actor{ Id = 3, FirstName = "Shah", LastName = "Khan" },
            new Actor{ Id = 4, FirstName = "Salman", LastName = "Khan" },
            new Actor{ Id = 5, FirstName = "Steel", LastName = "Sheet" }
        );
        modelBuilder.Entity<Movie>().HasData(
            new Movie(){ Id = 1, Title = "Mission Impossible", ActorId = 1},
            new Movie(){ Id = 2, Title = "Dil Data Hai", ActorId = 2},
            new Movie(){ Id = 3, Title = "Race", ActorId = 3},
            new Movie(){ Id = 4, Title = "Jeet", ActorId = 4}
        );
        modelBuilder.Entity<Genre>().HasData(
            new Genre(){ Id = 1, Name = "Action"},
            new Genre(){ Id = 2, Name = "Horror"},
            new Genre(){ Id = 3, Name = "Romantic"},
            new Genre(){ Id = 4, Name = "Comedy"}
        );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=postgres;Database=MovieManagement;port=5432");

    
}