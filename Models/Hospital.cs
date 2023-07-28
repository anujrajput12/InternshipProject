using Humanizer.Localisation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InternshipProject.Models;

public partial class Hospital
{
    [Key]
    [Required]
    public int HospitalId { get; set; }

    public string? HospitalCode { get; set; }

    public string? HospitalName { get; set; }

    public string? ResidentialAddress { get; set; }

    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public DateTime? IpdCheckOutTime { get; set; }

    public int? RegistrationCharges { get; set; }

    public int? IpdFileCharges { get; set; }

    public int? AdmissionCancellationCharges { get; set; }

    public DateTime? EmergencyVisitTimingFrom { get; set; }

    public DateTime? EmergencyVisitTimingTo { get; set; }

    public string? Tagline1 { get; set; }

    public string? Tagline2 { get; set; }

    public string? City { get; set; }

    public int? Pincode { get; set; }
    [Required]
    public int? PhoneNo { get; set; }

    public string? Fax { get; set; }
    [Required]
    public string? Email { get; set; }

    public string? Website { get; set; }

    public int? ConsultationChargeValidityDays { get; set; }

    //public DateTime? BillCancellationUpdationTimeLimit { get; set; }

    public int? FueLCharge { get; set; }

    public int? AllSeviceDiscount { get; set; }

    //public DateTime? OpdTimingFrom { get; set; }

    //public DateTime? OpdTimingTo { get; set; }

    public string? CompanyName { get; set; }

    public int? EmergencyContactNo { get; set; }

    public int? WhatsappNo { get; set; }

    public string? HospitalGmapUrl { get; set; }

    public string? LocationLat { get; set; }

    public string? LocationLon { get; set; }

    public string? HowToReachUs { get; set; }

    public string? HospitalDescription { get; set; }

    public string? BillingGroup { get; set; }

    public string? BillType { get; set; }
}
