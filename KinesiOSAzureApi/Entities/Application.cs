using System.ComponentModel.DataAnnotations;

namespace KinesiOSAzureApi.Entities;

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
    [Required]
    public DateTime ApplicationUpdateDate { get; set; }
}