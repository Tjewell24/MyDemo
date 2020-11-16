using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyDemo.Models
{
    public class BugModel
    {
        [Display(Name = "Bug Id") ]
        public int BugId { get; set; }
        [Display(Name = "Bug Description")]
        public string BugDescription { get; set; }
        [Display(Name = "Team Member Assigned")]
        public string TeamMember { get; set; }
        [Display(Name = "Priority Status")]
        public string BugPriority { get; set; }
    }
}