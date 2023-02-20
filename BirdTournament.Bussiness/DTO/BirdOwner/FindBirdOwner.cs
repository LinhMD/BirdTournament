
using CrudApiTemplate.Attributes.Search;
using CrudApiTemplate.Model;
using CrudApiTemplate.Request;

namespace BirdTournament.Bussiness.DTO.BirdOwner;

public class FindBirdOwner : IFindRequest<Data.Model.BirdOwner>, IDto
{

    [In("Id")] public IList<int>? Ids { get; set; }

    public int? Id { get; set; }

    [Contain] public int? Name { get; set; }

    [Contain] public string? Address { get; set; }

    [Contain] public string? PhoneNumber { get; set; }


    public int? UserId { get; set; }


}
