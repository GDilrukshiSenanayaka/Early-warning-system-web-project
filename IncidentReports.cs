using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DisasterManagementSystem
{
    public partial class IncidentReports : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gayani\Documents\dms.db.mdf;Integrated Security=True;Connect Timeout=30");
        byte[] imageData;

        public IncidentReports()
        {
            InitializeComponent();
            LoadIncidentReports();
        }
        private void LoadIncidentReports()
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT ReportID, VillageName, District, IncidentType, Description, ReportedAt FROM IncidentReports", conn);
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

        }

        private void IncidentReports_Load(object sender, EventArgs e)
        {

        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                // Convert image to byte array
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    imageData = ms.ToArray();
                }
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtlcation.Text) || string.IsNullOrWhiteSpace(txtdist.Text) || cmbtype.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                string query = @"INSERT INTO IncidentReports (VillageName, District, IncidentType, Description, ImageData) 
                                 VALUES (@village, @district, @type, @desc, @image)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@village", txtlcation.Text.Trim());
                cmd.Parameters.AddWithValue("@district",txtdist.Text.Trim());
                cmd.Parameters.AddWithValue("@type", cmbtype.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@desc", txtdesc.Text.Trim());
                cmd.Parameters.AddWithValue("@image", imageData ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Incident report submitted for admin review!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear form
               txtlcation.Clear();
                txtdist.Clear();
                cmbtype.SelectedIndex = -1;
                txtdesc.Clear();
                pictureBox1.Image = null;
                imageData = null;

                LoadIncidentReports(); // refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting report: " + ex.Message);
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