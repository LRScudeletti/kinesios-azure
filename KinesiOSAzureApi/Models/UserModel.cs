namespace KinesiOSAzureApi.Models;

using System.ComponentModel.DataAnnotations;
using Entities;

public class UserModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    [MinLength(6)]
    public string Password { get; set; }

    [Required]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }

    [Required]
    [EnumDataType(typeof(Role))]
    public int Role { get; set; }

    public bool FirstAccess { get; set; }

    public bool Status { get; set; }

    [Required]
    public string UserUpdate { get; set; }

    public DateTime UpdateDate { get; set; } = DateTime.Now;
}