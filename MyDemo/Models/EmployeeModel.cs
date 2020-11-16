using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyDemo.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }
        public string Role { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display (Name = "First Name")]
        public string FirstName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
       
      

    }
}