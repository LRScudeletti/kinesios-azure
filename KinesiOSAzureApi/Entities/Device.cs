using System.ComponentModel.DataAnnotations;

namespace KinesiOSAzureApi.Entities;

public class Device
{
    [Required]
    public int DeviceId { get; set; }
    [Required]
    public string? DeviceName { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public DateTime DeviceUpdateDate { get; set; }
}