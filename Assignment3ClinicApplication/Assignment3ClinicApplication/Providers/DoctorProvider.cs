using Assignment3ClinicApplication.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace Assignment3ClinicApplication.Providers
{
    public class DoctorProvider
    {
        private string connString;

        public DoctorProvider()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<Consultation> viewConsultation(int idP, int idD)
        {
            IList<Consultation> cList = new List<Consultation>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM Consultation where idPatient = " + idP + " AND idDoctor  = " + idD +  " ;";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Consultation consult = new Consultation();

                        consult.consultationDate = reader.GetDateTime("consultationDate");
                        consult.consultationHour = reader.GetInt32("consultationHour");
                        consult.idDoctor = reader.GetInt32("idDoctor");
                        consult.idPatient = reader.GetInt32("idPatient");
                        consult.details = reader.GetString("details");
                        Console.WriteLine(consult.details);

                        cList.Add(consult);

                    }
                }

            }


            return cList;
        }
        public void addConsultation(Consultation consult)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CreateConsultation";


                cmd.Parameters.Add(new MySqlParameter("consultationDate1", consult.consultationDate));
                cmd.Parameters.Add(new MySqlParameter("consultationHour1", consult.consultationHour));
                cmd.Parameters.Add(new MySqlParameter("idDoctor1", consult.idDoctor));
                cmd.Parameters.Add(new MySqlParameter("idPatient1", consult.idPatient));
                cmd.Parameters.Add(new MySqlParameter("details1", consult.details));
    
                cmd.ExecuteNonQuery();

            }
        }
       
        
    }
}