using System.ComponentModel.DataAnnotations;
using BirdTournament.Data.Model;
using CrudApiTemplate.Model;
using CrudApiTemplate.View;
using Mapster;

namespace BirdTournament.Bussiness.Service.DTO;
public class UserSignUp : CreateDto
{
    [Required][EmailAddress] public string Email { get; set; }

    [Required][MaxLength(255)] public string UserName { get; set; }

    [Required]
    [MinLength(8)]
    [MaxLength(32)]
    public string Password { get; set; }

    [Required] public Role Role { get; set; }

    [RegularExpression(@"\(?\d{3}\)?-?\d{3}-?\d{4}", ErrorMessage = "Must be a phone number")]
    public string? PhoneNumber { get; set; }

    public string? AvatarLink { get; set; }
}