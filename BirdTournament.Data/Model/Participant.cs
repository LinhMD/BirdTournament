using CrudApiTemplate.Model;

namespace BirdTournament.Data.Model;

public class Participant : BaseModel
{
    public int Id { get; set; }

    public Bird Bird { get; set; }

    public int BirdId { get; set; }

    public BirdOwner BirdOwner { get; set; }

    public int BirhOwnerId { get; set; }

    public Competition Competition { get; set; }

    public int CompetitionId { get; set; }

    public int EloGain { get; set; }

    public ParticipantStatus ParticipantStatus { get; set; } = ParticipantStatus.UnDetermined;
}

public enum ParticipantStatus
{
    Win, Lose, Draw, UnDetermined
}