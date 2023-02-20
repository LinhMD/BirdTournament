using System.ComponentModel.DataAnnotations;
using CrudApiTemplate.Model;
using CrudApiTemplate.Request;

namespace BirdTournament.Bussiness.DTO.BirdType;

public class CreateBirdType : CreateDto, ICreateRequest<Data.Model.BirdType>
{

    [Required] public string Name { get; set; }
}
