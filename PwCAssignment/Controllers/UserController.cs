using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PwCAssignment.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult userLogin()
        {
            return View();
        }
        public ActionResult userReg()
        {
            return View();
        }
        public ActionResult AdminReg()
        {
            return View();
        }
    }
}