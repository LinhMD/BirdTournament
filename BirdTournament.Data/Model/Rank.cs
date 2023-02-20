using CrudApiTemplate.Model;

namespace BirdTournament.Data.Model;

public class Rank : BaseModel
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int MinElo { get; set; }


}