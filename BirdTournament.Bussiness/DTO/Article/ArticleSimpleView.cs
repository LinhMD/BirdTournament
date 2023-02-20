using BirdTournament.Bussiness.DTO.Comment;
using BirdTournament.Bussiness.Service.DTO;
using CrudApiTemplate.Model;
using CrudApiTemplate.View;

namespace BirdTournament.Bussiness.DTO.Article;

public class ArticleSimpleView : IView<Data.Model.Article>, IDto
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Content { get; set; }

    public DateTime PostDate { get; set; }

    public UserView CreateBy { get; set; }

    public int CreateById { get; set; }


    public IList<CommentView> Comments { get; set; }
}
