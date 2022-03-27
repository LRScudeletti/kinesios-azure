using System.ComponentModel.DataAnnotations;

namespace KinesiOSAzureApi.Entities;

public class State
{
    [Key]
    public int StateId { get; set; }

    [Required]
    public string? UfState { get; set; }

    [Required]
    public string? StateName { get; set; }

    [Required]
    public int CountryId { get; set; }
    public Country? Country { get; set; }

    [Required]
    public int UserId { get; set; }
    public User? User { get; set; }

    [Required]
    public DateTime StateUpdateDate { get; set; }
}