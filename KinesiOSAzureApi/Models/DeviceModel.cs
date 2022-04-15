namespace KinesiOSAzureApi.Models;

public class DeviceModel
{
    public int DeviceId { get; set; }
    public string? DeviceName { get; set; }
    public bool Status { get; set; } = true;
    public int UserId { get; set; }
    public DateTime DeviceUpdateDate { get; set; } = DateTime.Now;
}