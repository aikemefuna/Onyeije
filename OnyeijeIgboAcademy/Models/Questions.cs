using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Models
{
    public class Questions : BaseEntity
    {
        [Key]
        [Required]
        public int QuestId { get; set; }

        public int Course { get; set; }
     
        public int TopicId { get; set; }
        public Topic Topic { get; set; }

       
        public int Module { get; set; }
      

        public string Question { get; set; }

        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string RightAnswer { get; set; }

    }
}
