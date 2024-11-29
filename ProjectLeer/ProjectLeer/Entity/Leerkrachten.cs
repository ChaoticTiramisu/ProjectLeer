namespace ProjectLeer.Entity
{
    public class Leerkracht
{
    public int Id { get; set; }
    public string ?Naam { get; set; }
    public string? Klassen { get; set; }
    public List<Vak> Vakken { get; set; } = new List<Vak>();
    public List<Vak> Graden  { get; set; } = new List<Vak>();
    }
}
