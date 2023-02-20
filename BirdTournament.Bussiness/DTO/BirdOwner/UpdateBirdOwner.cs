using CrudApiTemplate.Model;
using CrudApiTemplate.Request;

namespace BirdTournament.Bussiness.DTO.BirdOwner;

public class UpdateBirdOwner : UpdateDto, IUpdateRequest<Data.Model.BirdOwner>
{
    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

}
