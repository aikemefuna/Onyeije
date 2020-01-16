using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Full Name")]
        [RegularExpression("^[a-z A-Z]*$", ErrorMessage = "Only Alphabets allowed")]
        public string FullName { get; set; }
      

    
        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailInUse", controller: "Account")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password does not match")]
        public string ComfirmPassword { get; set; }

        public bool Privacy { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }
     


    }
}
