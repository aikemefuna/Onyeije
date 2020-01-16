using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Models
{
    public class StAssignment : BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string CourseCode { get; set; }

        [Display(Name = "Completed Status")]
        public bool IsCompleted { get; set; }

        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? CompletedTime { get; set; }
        public string Description { get; set; }
    }
}
