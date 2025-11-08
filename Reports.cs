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
using System.Windows.Forms.DataVisualization.Charting;

namespace DisasterManagementSystem
{
    public partial class Reports : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gayani\Documents\dms.db.mdf;Integrated Security=True;Connect Timeout=30");
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[]
            {
                "Hazard Frequency by Type",
                "Affected Zones Overview",
                "Rainfall Summary by District",
                "Landslide Risk Report"
            });
            comboBox1.SelectedIndex = 0;

            // Initialize chart
            chart1.ChartAreas.Add(new ChartArea("MainArea"));
            chart1.Titles.Add("Hazard Data Summary");
            chart1.Legends.Add(new Legend("Legend"));
           status.Text = "Select a report type and click Generate.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reportType = comboBox1.SelectedItem.ToString();
            string query = "";

            switch (reportType)
            {
                case "Hazard Frequency by Type":
                    query = "SELECT HazardType AS [Hazard], COUNT(*) AS [Frequency] FROM HazardReports GROUP BY HazardType";
                    break;

                case "Affected Zones Overview":
                    query = "SELECT ZoneType AS [Zone], COUNT(*) AS [Affected Areas] FROM HazardReports GROUP BY ZoneType";
                    break;

                case "Rainfall Summary by District":
                    query = "SELECT District, AVG(Rainfall) AS [Average Rainfall (mm)] FROM HazardReports GROUP BY District";
                    break;

                case "Landslide Risk Report":
                    query = "SELECT District, LandslideRisk, COUNT(*) AS [Occurrences] FROM HazardReports GROUP BY District, LandslideRisk";
                    break;
            }

            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Display in DataGridView
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                // Display in Chart
                chart1.Series.Clear();
                Series series = new Series(reportType)
                {
                    ChartType = SeriesChartType.Column,
                    XValueMember = dt.Columns[0].ColumnName,
                    YValueMembers = dt.Columns[1].ColumnName,
                    IsValueShownAsLabel = true,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold)
                };

                chart1.Series.Add(series);
                chart1.DataSource = dt;
                chart1.DataBind();

               status.Text = $"✅ {reportType} generated successfully ({dt.Rows.Count} records).";
                status.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message);
                status.Text = "⚠️ Error while generating report.";
                status.ForeColor = Color.Red;
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new AdminDash().Show();
        }
    }
}
