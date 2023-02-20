using System.ComponentModel.DataAnnotations;
using CrudApiTemplate.Model;
using CrudApiTemplate.Request;

namespace BirdTournament.Bussiness.DTO.Bird;

public class CreateBird : CreateDto, ICreateRequest<Data.Model.Bird>
{
    [Required] public string Name { get; set; }

    public int Elo { get; set; }

    [Required] public int OwnerId { get; set; }

    public string Image { get; set; }

    [Required] public int BirdTypeId { get; set; }
}
