namespace KinesiOSAzureApi.Models;

public class SpecialistModel
{
    public int SpecialistId { get; set; }
    public string SpecialistDocument { get; set; }
    public string SpecialistName { get; set; }
    public string SpecialistAddress { get; set; }
    public string SpecialistDistrict { get; set; }
    public int CityId { get; set; }
    public int SpecialistPhone { get; set; }
    public string SpecialistEmail { get; set; }
    public int UserId { get; set; }
    public DateTime SpecialistUpdateDate { get; set; }
}