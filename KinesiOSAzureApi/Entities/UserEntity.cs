using System.ComponentModel.DataAnnotations;

namespace KinesiOSAzureApi.Entities;

public class UserEntity
{
    [Required]
    public int UserId { get; set; }
    [Required]
    public string? Username { get; set; }
    public int PatientId { get; set; }
    public int SpecialistId { get; set; }
    [Required]
    public string? Password { get; set; }
    [Required]
    public int UserIdUpdate { get; set; }
    [Required]
    public DateTime UserUpdateDate { get; set; }
}