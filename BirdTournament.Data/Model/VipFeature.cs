using System.ComponentModel.DataAnnotations;
using CrudApiTemplate.Model;

namespace BirdTournament.Data.Model;

public class VipFeature : BaseModel
{

    public int Id { get; set; }

    public FeatureType FeatureType { get; set; }

    [Range(0, int.MaxValue)]
    public int UsageLeft { get; set; }

    public VipAccount Account { get; set; }

    public int AccountId { get; set; }

}

public enum FeatureType
{
    ExceedLevel, NonWait
}