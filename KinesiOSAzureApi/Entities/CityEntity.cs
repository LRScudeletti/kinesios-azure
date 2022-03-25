using System.ComponentModel.DataAnnotations;

namespace KinesiOSAzureApi.Entities;

public class CityEntity
{
    [Required]
    public int CityId { get; set; }
    [Required]
    public string? CityName { get; set; }
    [Required]
    public int StateId { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public DateTime CityUpdateDate { get; set; }
}