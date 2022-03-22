namespace KinesiOSAzureApi.Models;

public class PatientModel
{
    public int PatientId { get; set; }
    public string? PatientDocument { get; set; }
    public string? PatientName { get; set; }
    public string? PatientAddress { get; set; }
    public string? PatientDistrict { get; set; }
    public int CityId { get; set; }
    public int PatientPhone { get; set; }
    public string? PatientEmail { get; set; }
    public int UserId { get; set; }
    public DateTime PatientUpdateDate { get; set; }
}