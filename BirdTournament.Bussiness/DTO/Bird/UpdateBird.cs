using CrudApiTemplate.Model;
using CrudApiTemplate.Request;

namespace BirdTournament.Bussiness.DTO.Bird;

public class UpdateBird : UpdateDto, IUpdateRequest<Data.Model.Bird>
{
    public string? Name { get; set; }

    public int? Elo { get; set; }

    public string? Image { get; set; }

    public int? BirdTypeId { get; set; }
}
