using Assignment3ClinicApplication.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace Assignment3ClinicApplication.Providers
{
    public class SecretaryProvider
    {
        private string connString;

        public SecretaryProvider()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<Consultation> viewConsultations()
        {
            IList<Consultation> cList = new List<Consultation>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM consultation ;";

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
        public void updateConsultation(Consultation consult)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateConsultation";


                cmd.Parameters.Add(new MySqlParameter("consultationDate1", consult.consultationDate));
                cmd.Parameters.Add(new MySqlParameter("consultationHour1", consult.consultationHour));
                cmd.Parameters.Add(new MySqlParameter("idDoctor1", consult.idDoctor));
                cmd.Parameters.Add(new MySqlParameter("idPatient1", consult.idPatient));
                cmd.Parameters.Add(new MySqlParameter("details1", consult.details));

                cmd.ExecuteNonQuery();

            }
        }
        public void deleteConsultation(Consultation cons)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteConsultation";

                cmd.Parameters.Add(new MySqlParameter("idDoctor1", cons.idDoctor));
                cmd.Parameters.Add(new MySqlParameter("idPatient1", cons.idPatient));
                cmd.Parameters.Add(new MySqlParameter("consultationDate1", cons.consultationDate));
                cmd.Parameters.Add(new MySqlParameter("consultationHour1", cons.consultationHour));

                cmd.ExecuteNonQuery();
            }
        }

        public void addPatient(Patient p)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CreatePatient";

                cmd.Parameters.Add(new MySqlParameter("idPatient1", p.idPatient));
                cmd.Parameters.Add(new MySqlParameter("patientName1",p.patientName));
                cmd.Parameters.Add(new MySqlParameter("identityCardNumber1",p.identityCardNumber));
                cmd.Parameters.Add(new MySqlParameter("cnp1", p.cnp));
                cmd.Parameters.Add(new MySqlParameter("birthDate1", p.birthDate));
                cmd.Parameters.Add(new MySqlParameter("address1", p.address));

                cmd.ExecuteNonQuery();

            }
        }
        public void updatePatient(Patient p)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdaatePatient";

                cmd.Parameters.Add(new MySqlParameter("idPatient1", p.idPatient));
                cmd.Parameters.Add(new MySqlParameter("patientName1", p.patientName));
                cmd.Parameters.Add(new MySqlParameter("identityCardNumber1", p.identityCardNumber));
                cmd.Parameters.Add(new MySqlParameter("cnp1", p.cnp));
                cmd.Parameters.Add(new MySqlParameter("birthDate1", p.birthDate));
                cmd.Parameters.Add(new MySqlParameter("address1", p.address));

                cmd.ExecuteNonQuery();

            }
        }
        public IList<Patient> viewuPatients()
        {
            IList<Patient> pList = new List<Patient>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM patient ;";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Patient patient = new Patient();

                        patient.idPatient = reader.GetInt32("idPatient");
                        patient.patientName = reader.GetString("patientName");
                        patient.identityCardNumber = reader.GetString("identityCardNumber");
                        patient.cnp = reader.GetString("cnp");
                        patient.birthDate = reader.GetDateTime("birthDate");
                        patient.address = reader.GetString("address");

                        pList.Add(patient);

                    }
                }

            }


            return pList;
        }

    }
}
