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
    [RoutePrefix("api/Doctor")]
    public class DoctorController : ApiController
    {
        DoctorProvider dp = new DoctorProvider();

        //GET Consultation
        [Route("GetConsultation/{id}/{id1}")]
        public IEnumerable<Consultation> Get(int id,int id1)
        {
            return dp.viewConsultation(id,id1);
        }

        //ADD Consultation
        [HttpPost]
        [Route("AddConsultation")]
        public void Post([FromBody]Consultation value)
        {
            dp.addConsultation(value);
        }
    }
}
