using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Models
{
    public class StCourseEnrollment : BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Courses { get; set; }

        public float AmountPaid { get; set; }
        public string TransId { get; set; }
        public DateTime? DateCompleted { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public StCourseEnrollment()
        {
            EnrollmentDate = DateTime.Now;
        }

    }
}