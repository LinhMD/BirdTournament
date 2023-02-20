using System.ComponentModel.DataAnnotations;
using BirdTournament.Data.Model;
using CrudApiTemplate.Model;
using CrudApiTemplate.Request;

namespace BirdTournament.Bussiness.DTO.Article;

public class CreateArticle : CreateDto, ICreateRequest<Data.Model.Article>
{
    [Required] public int Id { get; set; }

    [Required][MaxLength(255)] public string Title { get; set; }

    [Required] public string Content { get; set; }

    public DateTime PostDate { get; set; } = DateTime.Now;

    [Required] public int CreateById { get; set; }

}
