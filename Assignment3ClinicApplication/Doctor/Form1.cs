using Assignment3ClinicApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;


namespace Doctor
{
    public partial class Form1 : Form
    {
        public Form1(String s)
        {
            InitializeComponent();
            textBox2.Text= s;
        }


        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Consultation c = dataGridView1.SelectedRows[0].DataBoundItem as Consultation;
                if (c != null)
                {

                    textBox1.Text = c.consultationDate.ToString();
                    conHourTB.Text = c.consultationHour.ToString();
                    idPatientTB.Text = c.idPatient.ToString();
                    detailsTB.Text = c.details;

                }
            }
        }

        private void viewCTB_Click(object sender, EventArgs e)
        {
           
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55497/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Doctor/GetConsultation/" + idPatientTB.Text+"/"+textBox2.Text).Result;

            if (response.IsSuccessStatusCode)
            {
                var cons = response.Content.ReadAsAsync<IEnumerable<Consultation>>().Result;
                dataGridView1.DataSource = cons;
            }
        }
        

        private void addCB_Click(object sender, EventArgs e)
        {


            Consultation cons = new Consultation();
            cons.consultationDate = Convert.ToDateTime(textBox1.Text);
            cons.consultationHour = Convert.ToInt32(conHourTB.Text);
            cons.idPatient = Convert.ToInt32(idPatientTB.Text);
            cons.idDoctor = Convert.ToInt32(textBox2.Text);
            cons.details = detailsTB.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55497/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Doctor/AddConsultation", cons).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

     
    }
}
