using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
    public partial class GISMap : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gayani\Documents\dms.db.mdf;Integrated Security=True;Connect Timeout=30");
        GMapOverlay markersOverlay = new GMapOverlay("hazardMarkers");
        GMapOverlay polygonsOverlay = new GMapOverlay("hazardZones");
        public GISMap()
        {
            InitializeComponent();
           
        }

        private void InitializeMap()
        {
            
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void GISMap_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmap.Position = new PointLatLng(7.8731, 80.7718); // Center of Sri Lanka
            gmap.MinZoom = 5;
            gmap.MaxZoom = 18;
            gmap.Zoom = 7;
            gmap.ShowCenter = false;
            gmap.DragButton = MouseButtons.Left;

            gmap.Overlays.Add(markersOverlay);
            gmap.Overlays.Add(polygonsOverlay);

            status.Text = "Map initialized. Enter a location to search hazards.";
        }

        private void btnhaza_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtlocation.Text))
                {
                    MessageBox.Show("Please enter a village or district to search.");
                    return;
                }

                conn.Open();
                string query = "SELECT HazardType, District, LocationName, Latitude, Longitude, Severity, ZoneType " +
                               "FROM HazardLocations " +
                               "WHERE LocationName LIKE @location OR District LIKE @location";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@location", "%" + txtlocation.Text.Trim() + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                markersOverlay.Markers.Clear();
                polygonsOverlay.Polygons.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    double lat = Convert.ToDouble(row["Latitude"]);
                    double lng = Convert.ToDouble(row["Longitude"]);
                    string hazard = row["HazardType"].ToString();
                    string severity = row["Severity"].ToString();
                    string location = row["LocationName"].ToString();
                    string district = row["District"].ToString();
                    string zoneType = row["ZoneType"].ToString();

                    PointLatLng point = new PointLatLng(lat, lng);

                    // Marker color based on severity
                    GMarkerGoogleType markerColor = GMarkerGoogleType.green_dot;
                    if (severity == "High" || severity == "Severe") markerColor = GMarkerGoogleType.red_dot;
                    else if (severity == "Medium") markerColor = GMarkerGoogleType.yellow_dot;
                    else if (severity == "Low") markerColor = GMarkerGoogleType.blue_dot;

                    // Add marker without tooltip
                    GMarkerGoogle marker = new GMarkerGoogle(point, markerColor);
                    markersOverlay.Markers.Add(marker);

                    // Draw simple polygon for flood/landslide zones
                    if (zoneType == "FloodZone" || zoneType == "LandslideZone")
                    {
                        GMapPolygon polygon = new GMapPolygon(new System.Collections.Generic.List<PointLatLng>
                        {
                            new PointLatLng(lat+0.01, lng-0.01),
                            new PointLatLng(lat+0.01, lng+0.01),
                            new PointLatLng(lat-0.01, lng+0.01),
                            new PointLatLng(lat-0.01, lng-0.01)
                        }, zoneType);

                        polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Blue));
                        polygon.Stroke = new Pen(Color.Blue, 1);
                        polygonsOverlay.Polygons.Add(polygon);
                    }
                }

                // Center map on first result
                if (dt.Rows.Count > 0)
                {
                    gmap.Position = new PointLatLng(Convert.ToDouble(dt.Rows[0]["Latitude"]), Convert.ToDouble(dt.Rows[0]["Longitude"]));
                }

                status.Text = $"🗺️ {dt.Rows.Count} hazard locations displayed.";
               status.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new CustomerDash().Show();
        }
    }
}
