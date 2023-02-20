using BirdTournament.Bussiness.DTO.Participant;
using BirdTournament.Data.Model;
using CrudApiTemplate.Model;
using CrudApiTemplate.Request;

namespace BirdTournament.Bussiness.DTO.Competition;

public class CreateCompetition : CreateDto, ICreateRequest<Data.Model.Competition>
{
    public int PlaceId { get; set; }

    public DateTime Date { get; set; }

    public CompetitionStatus competitionStatus { get; set; }


    public IList<CreateParticipant> Participants { get; set; }
}
