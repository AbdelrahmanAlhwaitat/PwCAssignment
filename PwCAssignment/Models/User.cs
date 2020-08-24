using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PwCAssignment.Models
{
    public class User
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string password { get; set; }
        [NotMapped]
        [Compare("password",ErrorMessage = "The password does not match")]
        public string passwordchecker { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string lastName { get; set; }
        public string email { get; set; }
        public int gender { get; set; }
        public DateTime dob { get; set; }
        public int userType { get; set; }

        public List<Complaint> complaintList { get; set; }
    }
}