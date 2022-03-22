using System.ComponentModel.DataAnnotations;

namespace KinesiOSAzureApi.Entities;

public class CountryEntity
{
    [Required]
    public int CountryId { get; set; }
    [Required]
    public string? CountryName { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public DateTime CountryUpdateDate { get; set; }
}