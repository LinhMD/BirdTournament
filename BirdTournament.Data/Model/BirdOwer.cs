using CrudApiTemplate.Model;

namespace BirdTournament.Data.Model;

public class BirdOwner : BaseModel
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public string PhoneNumber { get; set; }

    public User User { get; set; }

    public int UserId { get; set; }

    public IList<FeedBack> FeedBacks { get; set; }

    public VipAccount? VipAccount { get; set; }

    public int? VipAccountId { get; set; }

}