using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PwCAssignment.Models
{
    public class Complaint
    {
        
        public int id { get; set; }
        [ForeignKey("userRef")]
        public int userId { get; set; }
        public int status { get; set; }
        public string complaintletter { get; set; }

        public User userRef { get; set; }
    }
}