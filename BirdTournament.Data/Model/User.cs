using System.ComponentModel.DataAnnotations;
using CrudApiTemplate.Model;

namespace BirdTournament.Data.Model;

public class User : BaseModel
{
    public int Id { get; set; }

    public string UserName { get; set; }

    [Required]
    public Role Role { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    public string? Hash { get; set; }

    public string? Salt { get; set; }

    public void ConfigOrderBy()
    {
        SetUpOrderBy<User>();
    }

}
public enum Role
{
    Admin,
    User

}
