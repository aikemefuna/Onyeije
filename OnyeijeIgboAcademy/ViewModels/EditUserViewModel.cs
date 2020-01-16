
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.ViewModel
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Role Name is Required")]
        public string Username { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Surname")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter a valid Number")]
        [RegularExpression("^[+0-9]*$", ErrorMessage = "Phone Number not Valid")]
        [MaxLength(15, ErrorMessage = "Lenght Exceeded..")]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailInUse", controller: "Account")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password does not match")]
        public string ComfirmPassword { get; set; }
      

        public IList<string> Roles { get; set; }
        public List<string> Claims { get; set; }
        public EditUserViewModel()
        {
            Roles = new List<string>();
            Claims = new List<string>();
        }
    }
}
