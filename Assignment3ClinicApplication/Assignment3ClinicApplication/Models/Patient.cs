using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment3ClinicApplication.Models
{
    public class Patient
    {
        public int idPatient { get; set; }
        public string patientName { get; set; }
        public string identityCardNumber { get; set; }
        public string cnp{ get; set; }
        public DateTime birthDate { get; set; }
        public string address { get; set; }
    }
}