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
    public partial class Alert : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gayani\Documents\dms.db.mdf;Integrated Security=True;Connect Timeout=30");

        public Alert()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (txtvillage.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a village name");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT VillageName, District, HazardType AS 'Current Hazard', AlertLevel AS 'Alert Level', LastUpdated " +
                    "FROM VillageAlerts WHERE VillageName LIKE @village", conn);

                cmd.Parameters.AddWithValue("@village", "%" + txtvillage.Text.Trim() + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    string hazard = dt.Rows[0]["Current Hazard"].ToString();
                    string alert = dt.Rows[0]["Alert Level"].ToString();

                    Hazard.Text = $"⚠️ Hazard: {hazard} | Level: {alert}";
                    Hazard.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                   Hazard.Text = "✅ No current hazards for this village";
                    Hazard.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
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
