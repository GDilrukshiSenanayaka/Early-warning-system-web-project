using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisasterManagementSystem
{
    public partial class Weather : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gayani\Documents\dms.db.mdf;Integrated Security=True;Connect Timeout=30");

        public Weather()
        {
            InitializeComponent();
        }

        private void EWS_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string location = txtlocation.Text.Trim();

            if (string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Please enter a location to search.");
                return;
            }

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT Location, District, Temperature, Rainfall, WindSpeed, Humidity, Condition, LastUpdated " +
                    "FROM RealTimeWeather WHERE Location LIKE @loc OR District LIKE @loc", conn);

                cmd.Parameters.AddWithValue("@loc", "%" + location + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                   status.Text = $"🌤 Weather updates found for '{location}' ({dt.Rows.Count} record(s))";
                   status.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    status.Text = $"⚠️ No weather updates found for '{location}'";
                    status.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching weather data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new CustomerDash().Show();
        }
    }
}
