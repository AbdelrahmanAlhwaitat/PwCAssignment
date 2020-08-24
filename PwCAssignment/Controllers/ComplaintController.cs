using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PwCAssignment.Controllers
{
    public class ComplaintController : Controller
    {
        // GET: Complaint
        public ActionResult AdminComplaintHome(int id)
        {
            ViewData["userId"] = id;
            return View();
        }
        public ActionResult CustomerComplaintHome(int id)
        {
            ViewData["userId"] = id;
            return View();
        }
    }
}