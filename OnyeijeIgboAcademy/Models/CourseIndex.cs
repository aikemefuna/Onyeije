using System;
using System.Collections.Generic;
using System.Text;

namespace OnyeijeIgboAcademy.Models
{
   public class CourseIndex
    {
        public Course Course { get; set; }
      
        public IEnumerable<Modules> Moduless { get; set; }
        
        public IEnumerable<Topic> Topic { get; set; }
       
    }
}
