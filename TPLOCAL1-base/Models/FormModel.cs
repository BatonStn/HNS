using System.ComponentModel.DataAnnotations;
using TPLOCAL1.Validation;

namespace TPLOCAL1.Models;

public class FormModel
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string Forename { get; set; }

    [Required]
    public string Gender { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    [RegularExpression(@"^[0-9]*$", ErrorMessage = "Zip must be a 5 characters long number")]
    [StringLength(5)]
    [Display(Name="Zip Code")]
    public string ZipCode { get; set; }

    [Required]
    public string Town { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    [Display(Name="Email Address")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Start Date field is required")]
    [Display(Name = "Start Date")]
    [ValidateDateAttribute(ErrorMessage = "Date must be in dd/mm/yyyy format and prior to 01/01/2021")]
    public string StartDate { get; set; }

    [Required]
    [Display(Name = "Course")]
    public string TrainingType { get; set; }

    [Required]
    [Display(Name = "Cobol Review")]
    public string CobolReview { get; set; }

    [Required]
    [Display(Name = "C# Review")]
    public string CSharpReview { get; set; }
}