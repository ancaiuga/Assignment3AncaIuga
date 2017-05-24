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
    public class AdministratorProvider
    {

        private string connString;

        public AdministratorProvider()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<User> viewUsers()
        {
            IList<User> uList = new List<User>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM users ;";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User u = new User ();
                        u.idUser = reader.GetInt32("idUser");
                        u.username = reader.GetString("username");
                        u.password = reader.GetString("passwrd");
                        u.userType = reader.GetInt32("userType");

                        uList.Add(u);

                    }
                }

            }

            return uList;
        }
        public void addUser(User u)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                Security secure = new Security();
                u.password = secure.HashSHA1(u.password);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CreateUser";

 
                cmd.Parameters.Add(new MySqlParameter("idUser1", u.idUser));
                cmd.Parameters.Add(new MySqlParameter("username1", u.username));
                cmd.Parameters.Add(new MySqlParameter("passwrd1", u.password));
                cmd.Parameters.Add(new MySqlParameter("userType1", u.userType));


                cmd.ExecuteNonQuery();

            }
        }
        public void updateUser(User u)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                Security secure = new Security();
                u.password = secure.HashSHA1(u.password);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateUser";

                cmd.Parameters.Add(new MySqlParameter("idUser1", u.idUser));
                cmd.Parameters.Add(new MySqlParameter("username1", u.username));
                cmd.Parameters.Add(new MySqlParameter("passwrd1", u.password));
                cmd.Parameters.Add(new MySqlParameter("userType1", u.userType));

                cmd.ExecuteNonQuery();

            }
        }
        public void deleteUser(User u)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteUser";

                cmd.Parameters.Add(new MySqlParameter("idUser", u.idUser));


                cmd.ExecuteNonQuery();
            }
        }

        public User getUser(int idU)
        {
            User u = new User();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM Users where idUser=" + idU + " ;";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       
                        u.idUser = reader.GetInt32("idUser");
                        u.username = reader.GetString("username");
                        u.password = reader.GetString("passwrd");
                        u.userType = reader.GetInt32("userType");

                    }
                }

            }

            return u;
        }

    }
 }