using BirdTournament.Bussiness.DTO.FeedBack;
using BirdTournament.Bussiness.DTO.Participant;
using BirdTournament.Bussiness.DTO.Place;
using BirdTournament.Data.Model;
using CrudApiTemplate.Model;
using CrudApiTemplate.View;

namespace BirdTournament.Bussiness.DTO.Competition;

public class CompetitionView : IView<Data.Model.Competition>, IDto
{
    public int Id { get; set; }

    public PlaceView Place { get; set; }

    public int PlaceId { get; set; }

    public DateTime Date { get; set; }

    public CompetitionStatus competitionStatus { get; set; }

    public IList<ParticipantView> Participants { get; set; }

    public IList<FeedBackView> FeedBacks { get; set; }

}
