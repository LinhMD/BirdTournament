using CrudApiTemplate.Model;
using CrudApiTemplate.Request;

namespace BirdTournament.Bussiness.DTO.Article;

public class UpdateArticle : UpdateDto, IUpdateRequest<Data.Model.Article>
{

    public string? Title { get; set; }

    public string? Content { get; set; }

}
