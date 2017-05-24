using Assignment3ClinicApplication.Models;
using System;
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

namespace Secretary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void grid1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               Patient p = dataGridView1.SelectedRows[0].DataBoundItem as Patient;
                if (p != null)
                {
                    textBox1.Text = p.idPatient.ToString();
                    textBox2.Text = p.patientName;
                    textBox3.Text = p.identityCardNumber.ToString();
                    textBox4.Text = p.cnp;
                    dateTimePicker1.Text = p.birthDate.ToString();
                    textBox5.Text = p.address;

                }
            }
        }
        private void grid2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Consultation c = dataGridView1.SelectedRows[0].DataBoundItem as Consultation;
                if (c != null)
                {

                    dateTimePicker2.Text = c.consultationDate.ToString();
                    textBox7.Text = c.consultationHour.ToString();
                    textBox8.Text = c.idPatient.ToString();
                    textBox9.Text = c.details;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.idPatient = Convert.ToInt32(textBox1.Text);
            p.patientName = textBox2.Text;
            p.identityCardNumber = textBox3.Text;
            p.cnp = textBox4.Text;
            p.birthDate = Convert.ToDateTime(dateTimePicker1.Text);
            p.address = textBox5.Text;
           
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55497/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Secretary/AddPatient",p).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.idPatient = Convert.ToInt32(textBox1.Text);
            p.patientName = textBox2.Text;
            p.identityCardNumber = textBox3.Text;
            p.cnp = textBox4.Text;
            p.birthDate = Convert.ToDateTime(dateTimePicker1.Text);
            p.address = textBox5.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55497/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Secretary/UpdatePatient", p).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Consultation cons = new Consultation();
            cons.consultationDate = Convert.ToDateTime(dateTimePicker1.Text);
            cons.consultationHour = Convert.ToInt32(textBox7.Text);
            cons.idPatient = Convert.ToInt32(textBox8.Text);
            cons.idDoctor = Convert.ToInt32(textBox6.Text);
            cons.details = textBox9.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55497/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Secretary/AddConsultation", cons).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consultation cons = new Consultation();
            cons.consultationDate = Convert.ToDateTime(dateTimePicker1.Text);
            cons.consultationHour = Convert.ToInt32(textBox7.Text);
            cons.idPatient = Convert.ToInt32(textBox8.Text);
            cons.idDoctor = Convert.ToInt32(textBox6.Text);
            cons.details = textBox9.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55497/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Secretary/UpdateConsultation", cons).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Consultation cons = new Consultation();
            cons.consultationDate = Convert.ToDateTime(dateTimePicker2.Text);
            cons.consultationHour = Convert.ToInt32(textBox7.Text);
            cons.idPatient = Convert.ToInt32(textBox8.Text);
            cons.idDoctor = Convert.ToInt32(textBox6.Text);
            cons.details = textBox9.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55497/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Secretary/DeleteConsultation", cons).Result;
           
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55497/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Secretary/GetConsultations").Result;

            if (response.IsSuccessStatusCode)
            {
                var cons = response.Content.ReadAsAsync<IEnumerable<Consultation>>().Result;
                dataGridView2.DataSource = cons;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55497/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Secretary/GetPatients").Result;

            if (response.IsSuccessStatusCode)
            {
                var cons = response.Content.ReadAsAsync<IEnumerable<Patient>>().Result;
                dataGridView1.DataSource = cons;
            }
        }
    }
}
