using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace MyDemo.Models
{
    public class TicketModel
    {
        

        [Display(Name = "Ticket ID")]
        [Required(ErrorMessage = "Ticket must have an ID.")]
        public int TicketId { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Ticket must have a title.")]
        public string TicketTitle { get; set; }

        [Display(Name = "Description")]
        public string TicketDescription { get; set; }

        [Display(Name = "Submitter")]
        [Required(ErrorMessage = "Must enter your name.")]
        public string TicketSubmitter { get; set; }

        [Display(Name = "Priority")]
        [Required(ErrorMessage = "Ticket priority number is required.")]
        public int TicketPriority { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "Open, in-progress, or complete.")]
        public string TicketStatus { get; set; }

        [Display(Name = "Created On")]
        [DataType(DataType.DateTime)]
        public DateTime TicketCreatedOn { get; set; }

        [Display(Name = "Last Updated")]
        [DataType(DataType.DateTime)]
        public DateTime TicketUpdatedOn { get; set; }

        [Display(Name = "Comments")]
        public string TicketComment { get; set; }
    }
}