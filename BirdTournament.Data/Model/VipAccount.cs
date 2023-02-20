using CrudApiTemplate.Model;

namespace BirdTournament.Data.Model;

public class VipAccount : BaseModel
{

    public int Id { get; set; }

    public int BirdOwerId { get; set; }

    public IList<VipFeature> VipFeatures { get; set; }
}