using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisasterManagementSystem
{

    public partial class Approval : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gayani\Documents\dms.db.mdf;Integrated Security=True;Connect Timeout=30");
        public Approval()
        {
            InitializeComponent();
            LoadPendingReports();
        }
        private void LoadPendingReports()
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT ReportID, VillageName, District, IncidentType, Description, ReportedAt FROM IncidentReports WHERE IsValidated = 0",
                    conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int reportId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ReportID"].Value);
                LoadReportDetails(reportId);
            }
        }

        private void LoadReportDetails(int reportId)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Description, ImageData FROM IncidentReports WHERE ReportID = @ReportID", conn);
                cmd.Parameters.AddWithValue("@ReportID", reportId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtdesceibe.Text = reader["Description"].ToString();

                    if (reader["ImageData"] != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])reader["ImageData"];
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report details: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void ShowReportDetails(int reportId)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void LoadReportImage(int reportId)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateReportValidation(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateReportValidation(false);

        }

        private void UpdateReportValidation(bool isApproved)
        {
            if (dataGridView1 .SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a report first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int reportId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ReportID"].Value);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE IncidentReports SET IsValidated = @IsValidated WHERE ReportID = @ReportID", conn);
                cmd.Parameters.AddWithValue("@IsValidated", isApproved ? 1 : 0);
                cmd.Parameters.AddWithValue("@ReportID", reportId);
                cmd.ExecuteNonQuery();

                string msg = isApproved ? "Report approved successfully!" : "Report rejected!";
                MessageBox.Show(msg, "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPendingReports();
                txtdesceibe.Clear();
                pictureBox1.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating report status: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPendingReports();
        }
    

        private void UpdateReportStatus(bool approve)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new AdminDash().Show();
        }

        private void district_Click(object sender, EventArgs e)
        {
          
        }

        private void details_Click(object sender, EventArgs e)
        {

        }

        private void txtdesceibe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
