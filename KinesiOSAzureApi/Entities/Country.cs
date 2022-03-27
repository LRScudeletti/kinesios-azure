using System.ComponentModel.DataAnnotations;

namespace KinesiOSAzureApi.Entities;

// ReSharper disable once ClassNeverInstantiated.Global
public class Country
{
    [Key]
    public int CountryId { get; set; }

    [Required]
    public string? CountryName { get; set; }

    [Required]
    public int UserId { get; set; }
    public User? User { get; set; }

    [Required]
    public DateTime CountryUpdateDate { get; set; }
}