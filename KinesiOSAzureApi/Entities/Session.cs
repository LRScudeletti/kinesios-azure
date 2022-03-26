using System.ComponentModel.DataAnnotations;

namespace KinesiOSAzureApi.Entities;

public class Session
{
    [Key]
    public int SessionId { get; set; }
    [Required]
    public int MedicalRecordId { get; set; }
    [Required]
    public string? SessionDescription { get; set; }
    public string? SessionDetail { get; set; }
    [Required]
    public DateTime SessionDate { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public DateTime SessionUpdateDate { get; set; }
}