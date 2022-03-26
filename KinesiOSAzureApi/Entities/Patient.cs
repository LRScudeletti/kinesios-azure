﻿using System.ComponentModel.DataAnnotations;

namespace KinesiOSAzureApi.Entities;

public class Patient
{
    [Required]
    public int PatientId { get; set; }
    [Required]
    public string? PatientDocument { get; set; }
    [Required]
    public string? PatientName { get; set; }
    public string? PatientAddress { get; set; }
    public string? PatientDistrict { get; set; }
    public int CityId { get; set; }
    public int PatientPhone { get; set; }
    public string? PatientEmail { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public DateTime PatientUpdateDate { get; set; }
}