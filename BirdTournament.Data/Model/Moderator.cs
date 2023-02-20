using CrudApiTemplate.Model;

namespace BirdTournament.Data.Model;

public class Moderator : BaseModel
{
    public int Id { get; set; }

    public int Name { get; set; }

    public IList<Competition> ModerateCompetitions { get; set; }

    public User User { get; set; }

    public int UserId { get; set; }

}
