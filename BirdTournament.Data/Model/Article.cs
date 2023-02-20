using CrudApiTemplate.Model;

namespace BirdTournament.Data.Model;

public class Article : BaseModel
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Content { get; set; }

    public DateTime PostDate { get; set; }

    public User CreateBy { get; set; }

    public int CreateById { get; set; }


    public IList<Comment> Comments { get; set; }

}
