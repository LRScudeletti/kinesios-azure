namespace KinesiOSAzureApi.Models;

public class SessionModel
{
    public int SessionId { get; set; }
    public int MedicalRecordId { get; set; }
    public string SessionDescription { get; set; }
    public string SessionDetail { get; set; }
    public DateTime SessionDate { get; set; }
    public int UserId { get; set; }
    public DateTime SessionUpdateDate { get; set; }
}