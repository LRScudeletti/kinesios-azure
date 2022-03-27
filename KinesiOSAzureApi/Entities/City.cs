using System.ComponentModel.DataAnnotations;

namespace KinesiOSAzureApi.Entities;

public class City
{
    [Key]
    public int CityId { get; set; }

    [Required]
    public string? CityName { get; set; }

    [Required]
    public int StateId { get; set; }
    public State? State { get; set; }

    [Required]
    public int UserId { get; set; }
    public User? User { get; set; }

    [Required]
    public DateTime CityUpdateDate { get; set; }
}