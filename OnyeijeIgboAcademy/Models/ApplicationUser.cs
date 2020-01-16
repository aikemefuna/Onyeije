
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Models
{
   
    public class ApplicationUser  : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [RegularExpression("^[a-z A-Z]*$", ErrorMessage = "Only Alphabets allowed")]
        public string Country { get; set; }



        public bool Declaration { get; set; }
        [DataType(DataType.Date)]
        [RegularExpression("^[a-z A-Z]*$", ErrorMessage = "Only Alphabets allowed")]
        [StringLength(6, MinimumLength = 4, ErrorMessage = "Enter either male of Female")]
        public string DateOfBirth { get; set; }


        [StringLength(6, MinimumLength = 4, ErrorMessage = "Enter either male of Female")]
        public string Gender { get; set; }


        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public string ProfilePics { get; set; }
        public virtual ICollection<Message> Messages { get; set; }

    }
}
