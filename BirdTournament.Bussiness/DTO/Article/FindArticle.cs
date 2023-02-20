using CrudApiTemplate.Attributes.Search;
using CrudApiTemplate.Request;

namespace BirdTournament.Bussiness.DTO.Article;

public class FindArticle : IFindRequest<Data.Model.Article>
{
    [In("Id")]
    public IList<int>? Ids { get; set; }

    [Equal]
    public int Id { get; set; }

    [Contain]
    public string Title { get; set; }

    [Contain]
    public string Content { get; set; }

    [Equal]
    public int CreateById { get; set; }
}
