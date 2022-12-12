using System.ComponentModel;

namespace MM.Domain.Entities;

public class Actor
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public List<Movie>? Movies { get; set; }
    public Biography? Biography { get; set; }
}