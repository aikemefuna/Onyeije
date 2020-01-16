
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.ViewModel
{
    public class EditInstructorViewModel
    {
        [Required]
        [RegularExpression("^[a-z A-Z]*$", ErrorMessage = "Only Alphabets allowed")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Surname")]
        [RegularExpression("^[a-z A-Z]*$", ErrorMessage = "Only Alphabets allowed")]
        public string SurName { get; set; }

        [Display(Name = "Other Names")]
        [RegularExpression("^[a-z A-Z]*$", ErrorMessage = "Only Alphabets allowed")]
        public string OtherNames { get; set; }
        [Required]
        [Display(Name = "Other Names")]
        [RegularExpression("^[a-z A-Z]*$", ErrorMessage = "Only Alphabets allowed")]
        public string PreferedName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string InstructorEmail { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter a valid Phone number")]
        [RegularExpression("^[+0-9]*$", ErrorMessage = "Input a valid Phone Number.")]
        [MaxLength(15, ErrorMessage = "Lenght Exceeded..")]
        [StringLength(maximumLength: 15, MinimumLength = 15, ErrorMessage = "not a valid number")]
        public string PhoneNumber { get; set; }

        [Required]
        [RegularExpression("^[a-z A-Z]*$", ErrorMessage = "Only Alphabets allowed")]
        public string Country { get; set; }



    
    }
}
