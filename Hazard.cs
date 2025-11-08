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
    public partial class Hazard : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gayani\Documents\dms.db.mdf;Integrated Security=True;Connect Timeout=30");
        public Hazard()
        {
            InitializeComponent();
        }

        private void HazardType_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            string hazardType = txthazard.Text.Trim();

            if (string.IsNullOrEmpty(hazardType))
            {
                MessageBox.Show("Please enter the current hazard type to search.");
                return;
            }

            try
            {
                conn.Open();

                // Query: Get all matching disaster types and locations
                SqlCommand cmd = new SqlCommand(
                    "SELECT HazardType AS 'Hazard Type', " +
                    "DisasterType AS 'Disaster Type', " +
                    "District AS 'District', " +
                    "Location AS 'Location', " +
                    "Severity AS 'Severity Level', " +
                    "LastUpdated AS 'Last Updated' " +
                    "FROM MultiHazardCoverage WHERE HazardType LIKE @hazard", conn);

                cmd.Parameters.AddWithValue("@hazard", "%" + hazardType + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                // Display alert message
                if (dt.Rows.Count > 0)
                {
                    Status.Text = $"⚠️ {hazardType} - {dt.Rows.Count} affected areas found.";
                    Status.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    Status.Text = $"✅ No current {hazardType} hazards found.";
                   Status.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while fetching data: " + ex.Message);
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
