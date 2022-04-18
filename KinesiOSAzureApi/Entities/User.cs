namespace KinesiOSAzureApi.Entities;

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class User
{
    [Key]
    public string? Username { get; set; }

    public string? UserPassword { get; set; }

    [JsonIgnore]
    public string? UserPasswordHash { get; set; }

    public Role UserRole { get; set; }

    public bool UserStatus { get; set; }

    public string? UserUpdate { get; set; }

    public DateTime UserUpdateDate { get; set; }
}