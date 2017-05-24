using System;
using Assignment3ClinicApplication.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        public void login()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55497/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
           
            HttpResponseMessage response = client.GetAsync("api/Administrator/GetUser/" + textBox1.Text).Result;
            MessageBox.Show(response.ToString());

            if (response.IsSuccessStatusCode)
            {
                var u = response.Content.ReadAsAsync<User>().Result;
                User us = new User();
                us = u;
                
                Security sec = new Security();
                if(sec.VerifyHash(textBox2.Text,us.password))
                {
                    if (us.userType == 1)
                    {
                        Form f = new Administrator.Form1();
                        f.Show();
                    }
                    else
                    { if(us.userType == 2)
                        {
                            Form f = new Doctor.Form1(us.idUser.ToString());
                            f.Show();
                        }
                        else
                        {
                            Form f = new Secretary.Form1();
                            f.Show();
                        }
                    
                    }
                }else
                {
                    MessageBox.Show("This is not an user !");
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
           
        }
    }
}
