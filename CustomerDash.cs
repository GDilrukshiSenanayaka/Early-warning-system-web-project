using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisasterManagementSystem
{
    public partial class CustomerDash : Form
    {
        public CustomerDash()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation Message",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Alert alert = new Alert();
            alert.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hazard hazard = new Hazard();
            hazard.Show();
            this.Hide();
        }
        private void weather_Click(object sender, EventArgs e)
        {
            Weather weather = new Weather();
            weather.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            GISMap map = new GISMap();
            map.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
           IncidentReports reports = new IncidentReports();
            reports.Show();
            this.Hide();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
