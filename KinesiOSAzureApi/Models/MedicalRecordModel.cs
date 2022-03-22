namespace KinesiOSAzureApi.Models;

public class MedicalRecordModel
{
    public int MedicalRecordId { get; set; }
    public int PatientId { get; set; }
    public int SpecialistId { get; set; }
    public string? MedicalRecordDescription { get; set; }
    public string? MedicalRecordDetail { get; set; }
    public DateTime MedicalRecordDate { get; set; }
    public int UserId { get; set; }
    public DateTime MedicalRecordUpdateDate { get; set; }
}