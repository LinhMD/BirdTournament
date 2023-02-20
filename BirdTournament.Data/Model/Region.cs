namespace BirdTournament.Data.Model;

public class Region
{
    public int Id { get; set; }

    public string Name { get; set; }

    public IList<Place> Places { get; set; }


}