using CrudApiTemplate.Model;

namespace BirdTournament.Data.Model;

public class BirdType : BaseModel
{
    public int Id { get; set; }

    public string Name { get; set; }

    public IList<Bird> Birds { get; set; }


}