using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Models
{
    public class StudentModules
    {
        public int StudentModulesId { get; set; }

        [Display(Name = "Completed Status")]
        public bool IsCompleted { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int ModuleId { get; set; }
        public Modules Modules { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? CompletedTime { get; set; }
    }
}
