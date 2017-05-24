using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment3ClinicApplication.Models
{
    public class Consultation
    {
        public DateTime consultationDate { get; set; }
        public int consultationHour { get; set; }
        public int idPatient { get; set; }
        public int idDoctor { get; set; }
        public string details { get; set; }
      
    }
}