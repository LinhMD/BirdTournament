using BirdTournament.Bussiness.DTO.BirdOwner;
using BirdTournament.Bussiness.DTO.BirdType;
using BirdTournament.Bussiness.DTO.Participant;
using BirdTournament.Bussiness.DTO.Rank;
using CrudApiTemplate.Model;
using CrudApiTemplate.View;

namespace BirdTournament.Bussiness.DTO.Bird;

public class BirdView : IView<Data.Model.Bird>, IDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public RankView Rank { get; set; }

    public int RankId { get; set; }


    public int Elo { get; set; }

    public BirdOwnerView Owner { get; set; }

    public int OwnerId { get; set; }

    public string Image { get; set; }

    public IList<ParticipantView> Games { get; set; }


    public BirdTypeView BirdType { get; set; }

    public int BirdTypeId { get; set; }

}