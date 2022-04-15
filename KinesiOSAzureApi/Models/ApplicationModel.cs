namespace KinesiOSAzureApi.Models;

public class ApplicationModel
{
    public int ApplicationId { get; set; }
    public string? ApplicationName { get; set; }
    public int DeviceId { get; set; }
    public bool Status { get; set; } = true;
    public int UserId { get; set; }
    public DateTime ApplicationUpdateDate { get; set; } = DateTime.Now;
}