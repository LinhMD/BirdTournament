using CrudApiTemplate.Model;
using CrudApiTemplate.View;

namespace BirdTournament.Bussiness.DTO.BirdType;

public class BirdTypeView : IView<Data.Model.BirdType>, IDto
{

    public int Id { get; set; }

    public string Name { get; set; }

}
