using PwCAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class ComplaintWebAPIController : ApiController
    {
        [HttpPost]
        [Route("api/ComplaintWebAPI/PostInsert")]
        public void PostInsert(Complaint obj)
        {
            if (ModelState.IsValid)
            {
                ComplaintContext oCon = new ComplaintContext();
                oCon.complaintDB.Add(obj);
                oCon.SaveChanges();
            }
        }

        [HttpGet]
        [Route("api/ComplaintWebAPI/GetAllComplaint")]
        public List<Complaint> GetAllComplaint()
        {
            ComplaintContext oCon = new ComplaintContext();
            List<Complaint> complaintList = oCon.complaintDB.ToList<Complaint>();
            return complaintList;
        }

        [HttpGet]
        [Route("api/ComplaintWebAPI/GetComplaintById")]
        public List<Complaint> GetComplaintById(int _id)
        {
            ComplaintContext oCon = new ComplaintContext();
            List<Complaint> complaintList = oCon.complaintDB.Where(a=>a.userId==_id).ToList<Complaint>();
            return complaintList;
        }
    }
}
    

