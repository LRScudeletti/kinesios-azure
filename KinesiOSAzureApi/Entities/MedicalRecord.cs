using System.ComponentModel.DataAnnotations;

namespace KinesiOSAzureApi.Entities;

public class MedicalRecord
{
    [Required]
    public int MedicalRecordId { get; set; }
    [Required]
    public int PatientId { get; set; }
    [Required]
    public int SpecialistId { get; set; }
    [Required]
    public string? MedicalRecordDescription { get; set; }
    public string? MedicalRecordDetail { get; set; }
    [Required]
    public DateTime MedicalRecordDate { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public DateTime MedicalRecordUpdateDate { get; set; }
}