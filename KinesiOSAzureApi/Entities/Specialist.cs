using System.ComponentModel.DataAnnotations;

namespace KinesiOSAzureApi.Entities;

public class Specialist
{
    [Key]
    public int SpecialistId { get; set; }

    [Required]
    public string? SpecialistDocument { get; set; }

    [Required]
    public string? SpecialistName { get; set; }

    public string? SpecialistAddress { get; set; }

    public string? SpecialistDistrict { get; set; }

    public int CityId { get; set; }
    public City? City { get; set; }

    public int SpecialistPhone { get; set; }

    public string? SpecialistEmail { get; set; }

    [Required]
    public int UserId { get; set; }
    public User? User { get; set; }

    [Required]
    public DateTime SpecialistUpdateDate { get; set; }

    public virtual List<Specialist>? Specialists { get; set; }
}