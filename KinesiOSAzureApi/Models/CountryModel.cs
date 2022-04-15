namespace KinesiOSAzureApi.Models;

public class CountryModel
{
    public int CountryId { get; set; }
    public string? CountryName { get; set; }
    public int UserId { get; set; }
    public DateTime CountryUpdateDate { get; set; } = DateTime.Now;
}