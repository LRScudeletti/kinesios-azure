using System.ComponentModel.DataAnnotations;

namespace KinesiOSAzureApi.Entities;

public class State
{
    [Required]
    public int StateId { get; set; }
    [Required]
    public string? StateName { get; set; }
    [Required]
    public int CountryId { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public DateTime StateUpdateDate { get; set; }
}