using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Models
{
    public class Student:BaseEntity
    {
        [Key]
        [Required]
        public int StudentId { get; set; }

       
        [Display(Name = "First Name")]
        public string StudentFirstName { get; set; }

     
        [Display(Name = "Last Name")]
        public string StudentLastName { get; set; }
        [Display(Name = "Middle Name")]
        public string StudentMiddleName { get; set; }

        public string Gender { get; set; }

        [EmailAddress]
        public string StudentEmail { get; set; }

        [Display(Name = "Status")]
        public bool IsEnabled { get; set; }

        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public double Points { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ProfilePics { get; set; }
        public string FullName
        {
            get { return StudentLastName + ", " + StudentFirstName + " " + StudentMiddleName; }
        }

        public bool Declaration { get; set; }

        public ICollection<StAssignment> StAssignment { get; set; }
        public ICollection<StudentTopic> StudentTopics { get; set; }
        public ICollection<StudentModules> StudentModules { get; set; }

        public ICollection<StAssignmentAnswer> StAssignmentAnswer { get; set; }
        public ICollection<StCourseEnrollment> StCourseEnrollment { get; set; }
    
    }
}
