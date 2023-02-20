using CrudApiTemplate.Model;

namespace BirdTournament.Data.Model;

public class Competition : BaseModel
{
    public int Id { get; set; }

    public Place Place { get; set; }

    public int PlaceId { get; set; }

    public DateTime Date { get; set; }

    public CompetitionStatus competitionStatus { get; set; }

    public IList<Participant> Participants { get; set; }

    public IList<FeedBack> FeedBacks { get; set; }

}

public enum CompetitionStatus
{
    PendingAproval,
    Waiting,
    Playing,
    End
}