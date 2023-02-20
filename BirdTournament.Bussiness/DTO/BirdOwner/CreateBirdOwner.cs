using System.ComponentModel.DataAnnotations;
using CrudApiTemplate.Model;
using CrudApiTemplate.Request;

namespace BirdTournament.Bussiness.DTO.BirdOwner;

public class CreateBirdOwner : CreateDto, ICreateRequest<Data.Model.BirdOwner>
{
    [Required] public string Name { get; set; }

    public string Address { get; set; }

    public string PhoneNumber { get; set; }

    [Required] public int UserId { get; set; }
}
