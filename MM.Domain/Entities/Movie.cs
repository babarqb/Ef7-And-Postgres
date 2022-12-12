namespace MM.Domain.Entities;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int ActorId { get; set; }
    public Actor? Actor { get; set; }
    public List<Genre>? Genres { get; set; }
}