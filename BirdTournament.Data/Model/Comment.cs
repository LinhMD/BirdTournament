using CrudApiTemplate.Model;

namespace BirdTournament.Data.Model;

public class Comment : BaseModel
{
    public int Id { get; set; }

    public string Content { get; set; }

    public User User { get; set; }

    public int UserId { get; set; }

    public Article Article { get; set; }

    public int ArticleId { get; set; }

}