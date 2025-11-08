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
    public partial class RealTimeAlert : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gayani\Documents\dms.db.mdf;Integrated Security=True;Connect Timeout=30");
        public RealTimeAlert()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void RealTimeAlert_Load(object sender, EventArgs e)
        {
            
            Status.Text = "";

            comboBox1.Items.AddRange(new string[]
            {
                "Advisory",
                "Watch",
                "Warning",
                "Evacuation"
            });
            comboBox1.SelectedIndex = 0;

            LoadData();
            timer1.Interval = 10000; // auto-refresh every 10 seconds
            timer1.Start();
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT ID, Zone, District, AlertLevel, Message, DateUpdated FROM AlertUpdates ORDER BY DateUpdated DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                // DataGridView styling
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dataGridView1.RowsDefaultCellStyle.BackColor = Color.Beige;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

               Status.Text = $"✅ {dt.Rows.Count} alerts loaded at {DateTime.Now:T}";
                Status.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                Status.Text = "⚠️ Error loading alerts: " + ex.Message;
               Status.ForeColor = Color.Red;
            }
            finally
            {
                conn.Close();
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Alert_Click(object sender, EventArgs e)
        {
            if (Zone.Text == "" || District.Text == "" || Message.Text == "")
            {
                MessageBox.Show("Please fill all fields before sending alert.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                string query = "INSERT INTO AlertUpdates (Zone, District, AlertLevel, Message, DateUpdated) VALUES (@z, @d, @a, @m, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@z", Zone.Text);
                cmd.Parameters.AddWithValue("@d", District.Text);
                cmd.Parameters.AddWithValue("@a", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@m", Message.Text);
                cmd.ExecuteNonQuery();

                Status.Text = "🚨 Alert sent successfully!";
                Status.ForeColor = Color.Blue;
                MessageBox.Show("Alert update broadcasted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending alert: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ClearFields()
        {
           
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new AdminDash().Show();
        }
    }
}
