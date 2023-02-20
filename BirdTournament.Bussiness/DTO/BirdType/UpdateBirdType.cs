using CrudApiTemplate.Model;
using CrudApiTemplate.Request;

namespace BirdTournament.Bussiness.DTO.BirdType;

public class UpdateBirdType : UpdateDto, IUpdateRequest<Data.Model.BirdType>
{
    public string? Name { get; set; }
}
