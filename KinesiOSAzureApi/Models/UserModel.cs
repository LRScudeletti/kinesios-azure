namespace KinesiOSAzureApi.Models;

public class UserModel
{
    public int UserId { get; set; }
    public string? Username { get; set; }
    public int PatientId { get; set; }
    public int SpecialistId { get; set; }
    public string? Password { get; set; }
    public bool Status { get; set; } = false;
    public int UserIdUpdate { get; set; }
    public DateTime UserUpdateDate { get; set; } = DateTime.Now;
}