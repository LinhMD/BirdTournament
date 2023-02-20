using CrudApiTemplate.Model;

namespace BirdTournament.Data.Model;

public class Place : BaseModel
{
    public int Id { get; set; }

    public string Address { get; set; }

    public Region Location { get; set; }

}
