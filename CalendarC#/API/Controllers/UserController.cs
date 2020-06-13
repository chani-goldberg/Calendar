using System;
using System.Collections.Generic;
using DTO;
using BL;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [RoutePrefix("user")]

    public class UserController : ApiController
    {

        [Route("users/{id}")]
        [HttpGet]
        public IHttpActionResult GetUserById(int id)
        {
            var user = UserBL.GetUserById(id);
            if (user == null)
                return BadRequest("id wasn't found");
            return Ok(user);
        }


        [Route("users")]
        [HttpGet]
        public IHttpActionResult GetUsers()
        {
            return Ok(UserBL.GetUsers());
        }

        [Route("users")]
        [HttpPost]
        public IHttpActionResult AddNewUser(UserDTO user)
        {
            try
            {
                var new_user = UserBL.AddNewUser(user);
                if (new_user != null)
                    return Ok(new_user);
                return NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        [Route("users/{id}")]
        [HttpDelete]
        public IHttpActionResult DeleteUser(int id)
        {
           int i = UserBL.DeleteUser(id);
            if (i == 0)
                return BadRequest("id wasn't found");
            return Ok(i);
        }



    }
}