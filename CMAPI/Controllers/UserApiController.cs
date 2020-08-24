using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PwCAssignment.Models;

namespace CMAPI.Controllers
{
    public class UserApiController : ApiController
    {
        [HttpPost]
        [Route("api/UserApi/PostInsert")]
        public void PostInsert(User user)
        {
            System.Diagnostics.Debugger.Break();
            user.userType = 2;
            if (ModelState.IsValid)
            {
                ComplaintContext oCon = new ComplaintContext();
                oCon.userDb.Add(user);
                oCon.SaveChanges();
            }
        }
    }
}
