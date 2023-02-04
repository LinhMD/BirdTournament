using System.ComponentModel.DataAnnotations;
using CrudApiTemplate.Request;
using BirdTournament.Data.Model;
using CrudApiTemplate.Model;
using CrudApiTemplate.View;
using Mapster;

namespace BirdTournament.Bussiness.Service.DTO;
public class AdminUpdate : UpdateDto, IUpdateRequest<User>
{
    [EmailAddress] public string? Email { get; set; }

    public string? AvatarLink { get; set; }

    [MaxLength(255)] public string? UserName { get; set; }

    [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}", ErrorMessage = "Must be a phone number")]
    [MaxLength(10)]
    public string? PhoneNumber { get; set; }

    public ModelStatus? Status { get; set; }

    public string? ProviderName { get; set; }

    public string? Address { get; set; }

    public string? TaxCode { get; set; }
}
