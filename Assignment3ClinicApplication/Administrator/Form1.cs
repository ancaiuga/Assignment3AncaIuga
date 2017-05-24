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
namespace Administrator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                User u = dataGridView1.SelectedRows[0].DataBoundItem as User;
                if (u != null)
                {
                    textBox1.Text = u.idUser.ToString();
                    textBox2.Text = u.username;
                    textBox3.Text = u.password;
                    textBox4.Text = u.userType.ToString();

                }
            }
        }
        private void EmptyUser()
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            dataGridView1.SelectedRows[0].Selected = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.idUser = Convert.ToInt32(textBox1.Text);
            u.username = textBox2.Text;
            u.password = textBox3.Text;
            u.userType = Convert.ToInt32(textBox4.Text);


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55497/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Administrator/AddUser", u).Result;

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
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55497/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Administrator/GetUsers").Result;

            if (response.IsSuccessStatusCode)
            {
                var cons = response.Content.ReadAsAsync<IEnumerable<User>>().Result;
                dataGridView1.DataSource = cons;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.idUser = Convert.ToInt32(textBox1.Text);
            u.username = textBox2.Text;
            u.password = textBox3.Text;
            u.userType = Convert.ToInt32(textBox4.Text);


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55497/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Administrator/UpdateUser", u).Result;

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
            User u = new User();
            u.idUser = Convert.ToInt32(textBox1.Text);
            u.username = textBox2.Text;
            u.password = textBox3.Text;
            u.userType = Convert.ToInt32(textBox4.Text);


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:55497/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Administrator/DeleteUser", u).Result;

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
