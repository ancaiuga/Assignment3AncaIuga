﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment3ClinicApplication.Models
{
    public class User
    {

        public int idUser{ get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int userType{ get; set; } 
    }
}