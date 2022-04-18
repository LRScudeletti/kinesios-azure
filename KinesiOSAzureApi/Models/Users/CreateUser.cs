namespace KinesiOSAzureApi.Models.Users;

using Entities;
using System.ComponentModel.DataAnnotations;

public class CreateUser
{
    [Key]
    public string? Username { get; set; }

    [Required]
    [MinLength(6)]
    public string? UserPassword { get; set; }

    [Required]
    [Compare("UserPassword")]
    public string? UserConfirmPassword { get; set; }

    [Required]
    [EnumDataType(typeof(Role))]
    public int UserRole { get; set; }

    [Required]
    public bool UserStatus { get; set; }

    [Required]
    public string UserUpdate { get; set; }

    [Required]
    public DateTime UserUpdateDate { get; set; } = DateTime.Now;
}