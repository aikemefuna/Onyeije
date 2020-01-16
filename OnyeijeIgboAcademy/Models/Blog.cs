using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnyeijeIgboAcademy.Models
{
  public class Blog : BaseEntity
    {
        [Key]
        [Required]
        [Display(Name = "Blog Id")]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Title: Field is required")]
        [StringLength(500, ErrorMessage = "Title: Length should not exceed 500 characters")]
        public string Title { get; set; }

        [Required]
        public string ShortDescription { get; set; }
      
        [Required(ErrorMessage = "Description: Field is required")]
        public string Content { get; set; }

        [StringLength(1000, ErrorMessage = "Meta: Length should not exceed 1000 characters")]
        public string Meta { get; set; }




    }
}
