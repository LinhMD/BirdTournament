using BirdTournament.Bussiness.DTO.VipAccount;
using BirdTournament.Bussiness.Service.DTO;
using CrudApiTemplate.Model;
using CrudApiTemplate.View;

namespace BirdTournament.Bussiness.DTO.BirdOwner;

public class BirdOwnerView : IView<Data.Model.BirdOwner>, IDto
{
    public int Id { get; set; }

    public int Name { get; set; }

    public string Address { get; set; }

    public string PhoneNumber { get; set; }

    public UserView User { get; set; }

    public int UserID { get; set; }

    public VipAccountView? VipAccount { get; set; }

    public int? VipAccountId { get; set; }

}
