using CrudApiTemplate.Attributes.Search;
using CrudApiTemplate.Model;
using CrudApiTemplate.Request;

namespace BirdTournament.Bussiness.DTO.Bird;

public class FindBird : IFindRequest<Data.Model.Bird>, IDto
{

    [In("Id")] public IList<int>? Ids { get; set; }

    [Contain] public string Name { get; set; }

    public int RankId { get; set; }

    public int Elo { get; set; }

    public int OwnerId { get; set; }

    public int BirdTypeId { get; set; }


}
