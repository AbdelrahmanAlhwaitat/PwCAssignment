using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PwCAssignment.Models
{
    public class ComplaintContext:DbContext
    {
        public ComplaintContext() : base("Name=ComplaintSystemDB")
        {
        }
        public DbSet<User> userDb { get; set; }
        public DbSet<Complaint> complaintDB { get; set; }

    }
}