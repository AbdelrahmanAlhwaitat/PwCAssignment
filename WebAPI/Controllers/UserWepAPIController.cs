using PwCAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UserWepAPI.Controllers
{
    public class UserWepAPIController : ApiController
    {
        [HttpPost]
        [Route("api/UserWepAPI/PostInsert")]
        public void PostInsert(User obj)
        {
            obj.userType = 2;

            if (ModelState.IsValid)
            {
                ComplaintContext oCon = new ComplaintContext();
                oCon.userDb.Add(obj);
                oCon.SaveChanges();
            }
        }

        [HttpPost]
        [Route("api/UserWepAPI/PostInsertAdmin")]
        public void PostInsertAdmin(User obj)
        {
            obj.userType = 1;

            if (ModelState.IsValid)
            {
                ComplaintContext oCon = new ComplaintContext();
                oCon.userDb.Add(obj);
                oCon.SaveChanges();
            }
        }

        [HttpGet]
        [Route("api/UserWepAPI/GetInfo")]
        public User GetInfo(string sentEmail, string sentPassword)
        {
            ComplaintContext context = new ComplaintContext();
            var query = from us in context.userDb
                        where us.email == sentEmail && us.password == sentPassword
                        select us;
            var user = query.FirstOrDefault<User>();
            User _user = user;
            return _user;
        }

        [HttpGet]
        [Route("api/UserWepAPI/GetUserById")]
        public User GetUserById(int _id)
        {
            ComplaintContext context = new ComplaintContext();
            User _user = context.userDb.Find(_id);
            return _user;
        }

        [HttpGet]
        [Route("api/UserWepAPI/GetAllUser")]
        public List<User> GetAllUser()
        {
            ComplaintContext context = new ComplaintContext();
            List<User> userList = context.userDb.ToList<User>();
            return userList;
        }
    }
}
