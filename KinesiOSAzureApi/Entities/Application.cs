using System.ComponentModel.DataAnnotations;

namespace KinesiOSAzureApi.Entities;

// ReSharper disable once ClassNeverInstantiated.Global
public class Application
{
    [Key]
    public int ApplicationId { get; set; }

    [Required]
    public string? ApplicationName { get; set; }

    [Required]
    public int DeviceId { get; set; }

    [Required]
    public int UserId { get; set; }
    public User? User { get; set; }

    [Required]
    public DateTime ApplicationUpdateDate { get; set; }
}