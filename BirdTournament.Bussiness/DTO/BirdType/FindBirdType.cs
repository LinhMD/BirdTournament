using CrudApiTemplate.Model;
using CrudApiTemplate.Request;

namespace BirdTournament.Bussiness.DTO.BirdType;

public class FindBirdType : IFindRequest<Data.Model.BirdType>, IDto
{

    public int? Id { get; set; }

    public string? Name { get; set; }
}
