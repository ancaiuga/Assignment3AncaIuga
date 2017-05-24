using Assignment3ClinicApplication.Models;
using Assignment3ClinicApplication.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment3ClinicApplication.Controllers
{
    [RoutePrefix("api/Administrator")]
    public class AdministratorController : ApiController
    {

        AdministratorProvider ap = new AdministratorProvider();
        //ADD User
        [HttpPost]
        [Route("AddUser")]
        public void AddUserPost([FromBody] User value)
        {
            ap.addUser(value);
        }
        // Get Users
        [Route("GetUsers")]
        public IEnumerable<User> Get()
        {
            return ap.viewUsers();
        }

        //UPDATE User
        [HttpPost]
        [Route("UpdateUser")]
        public void UpdateUserPost([FromBody] User value)
        {
            ap.updateUser(value);
        }

        //DELETE User
        [HttpPost]
        [Route("DeleteUser")]
        public void DeleteUserPost([FromBody] User value)
        {
            ap.deleteUser(value);
        }

        //GET User
        [Route("GetUser/{id}")]
        public User Get(int id)
        {
            return ap.getUser(id);
        }
    }
}
