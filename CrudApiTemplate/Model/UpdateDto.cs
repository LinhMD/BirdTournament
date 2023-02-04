
namespace CrudApiTemplate.Model;

public class UpdateDto : IDto
{
    public DateTime UpdateAt { get; } = DateTime.Now;

    public virtual void InitMapper()
    {
    }
}