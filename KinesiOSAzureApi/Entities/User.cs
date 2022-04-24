namespace KinesiOSAzureApi.Entities;

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class User
{
    [Key]
    public string? Email { get; set; }

    [Required]
    public string? FirstName { get; set; }

    [Required]
    public string? LastName { get; set; }

    [JsonIgnore]
    [Required]
    public string? Password { get; set; }

    [JsonIgnore]
    [Required]
    public string? PasswordHash { get; set; }

    [Required]
    [EnumDataType(typeof(Role))]
    public int Role { get; set; }

    [Required]
    public bool FirstAccess { get; set; }

    [Required]
    public bool Status { get; set; }

    [Required]
    public string? UserUpdate { get; set; }

    [Required]
    public DateTime UpdateDate { get; set; } = DateTime.Now;
}