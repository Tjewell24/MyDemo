using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyDemo.Models
{
    public class ProjectModel
    {
        [Display(Name = "Project ID")]
        [Required(ErrorMessage = "Project must have an ID.")]
        public int ProjectId { get; set; }


        [Display(Name = "Project Name")]
        [Required(ErrorMessage = "Project must have a name.")]
        public string ProjectTitle { get; set; }


        [Display(Name = "Project Start Date")]
        [DataType(DataType.DateTime)]
        public DateTime ProjectStartDate { get; set; }


        
    }

}
