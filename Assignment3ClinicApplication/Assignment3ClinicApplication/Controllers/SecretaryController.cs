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
    [RoutePrefix("api/Secretary")]
    public class SecretaryController : ApiController
    {
        SecretaryProvider sp = new SecretaryProvider();

      
        //ADD Patient
        [HttpPost]
        [Route("AddPatient")]
        public void AddPatientPost([FromBody] Patient value)
        {
            sp.addPatient(value);
        }

        //UPDATE Patient
        [HttpPost]
        [Route("UpdatePatient")]
        public void UpdatePatientPost([FromBody] Patient value)
        {
            sp.updatePatient(value);
        }

        // Get Patients
        [Route("GetPatients")]
        public IEnumerable<Patient> GetPatients()
        {
            return sp.viewuPatients();
        }
        //ADD Consultation
        [HttpPost]
        [Route("AddConsultation")]
        public void AddConsultationPost([FromBody] Consultation value)
        {
            sp.addConsultation(value);
        }
        // Get Consultations
        [Route("GetConsultations")]
        public IEnumerable<Consultation> Get()
        {
            return sp.viewConsultations();
        }

        //UPDATE Consultation
        [HttpPost]
        [Route("UpdateConsultation")]
        public void UpdateConsultationPost([FromBody] Consultation value)
        {
            sp.updateConsultation(value);
        }

        //DELETE Consultation
        [HttpPost]
        [Route("DeleteConsultation")]
        public void DeleteConsultationPost([FromBody] Consultation value)
        {
            sp.deleteConsultation(value);
        }
    }
}
