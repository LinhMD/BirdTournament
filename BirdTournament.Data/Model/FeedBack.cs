using CrudApiTemplate.Model;

namespace BirdTournament.Data.Model;

public class FeedBack : BaseModel
{

    public int Id { get; set; }

    public string Content { get; set; }


    public User User { get; set; }

    public int UserId { get; set; }


    public Competition Competition { get; set; }

    public int CompetitionID { get; set; }


}
