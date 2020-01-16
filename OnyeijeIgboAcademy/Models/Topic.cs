using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace OnyeijeIgboAcademy.Models
{
    public class Topic : BaseEntity
    {
        [Key]
        [Required]
        public int TopicId { get; set; }

        [Display(Name = "Status")]
        public bool IsEnabled { get; set; }
        public string TopicNumber { get; set; }

        public string Notes { get; set; }
        
        public int ModuleId { get; set; }
        public Modules Modules { get; set; }

        public float Duration { get; set; }
        public string Summary { get; set; }
        public string Title { get; set; }

        [Display(Name = "Video Url")]
        public string VideoUrl { get; set; }
        [Display(Name = "Completed Status")]
        public bool IsCompleted { get; set; }

        [Display(Name = "Topic Position")]
        public int Position { get; set; }

        public ICollection<StudentTopic> StudentTopic { get; set; }
        public ICollection<TopicFiles> TopicFiles { get; set; }
        public ICollection<Questions> Questions { get; set; }
    }
}
