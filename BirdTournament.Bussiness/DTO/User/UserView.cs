using BirdTournament.Data.Model;
using CrudApiTemplate.Model;
using CrudApiTemplate.View;
using Mapster;

namespace BirdTournament.Bussiness.Service.DTO;

public class UserView : BaseModel, IView<User>, IDto
{
    public int? Id { get; set; }

    public string? Email { get; set; }

    public string? AvatarLink { get; set; }

    public string? UserName { get; set; }

    public Role? Role { get; set; }

    public string? PhoneNumber { get; set; }

    public int ProviderId { get; set; }

    public void InitMapper()
    {
        TypeAdapterConfig<User, UserView>.NewConfig();
    }
}