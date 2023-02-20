using CrudApiTemplate.Model;

namespace BirdTournament.Data.Model;

public class Bird : BaseModel
{
    public int Id { get; set; }

    public string Name { get; set; }

    public Rank Rank { get; set; }

    public int RankId { get; set; }


    public int Elo { get; set; }

    public BirdOwner Owner { get; set; }

    public int OwnerId { get; set; }

    public string Image { get; set; }

    public IList<Participant> Games { get; set; }


    public BirdType BirdType { get; set; }

    public int BirdTypeId { get; set; }

}