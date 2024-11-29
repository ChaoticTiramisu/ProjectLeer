namespace ProjectLeer.Entity
{
    public class Leerling
{
    public int Id { get; set; }
    public string ?Naam { get; set; }
    public string? Klas { get; set; }
    public string? Graad { get; set; }

    public List<Vak> Vakken { get; set; } = new List<Vak>();
    }
}
