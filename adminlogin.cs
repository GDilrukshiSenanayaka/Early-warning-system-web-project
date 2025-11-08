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
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gayani\Documents\dms.db.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string username = txta_username.Text;
            string password = txta_passward.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Admin where username = '" + txta_username + "' and Password ='" + txta_passward + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (txta_username.Text == "Admin" && txta_passward.Text == "admin123")
            {
                new AdminDash().Show();
            }
            else
            {
                MessageBox.Show("Invalied Username or Password, Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txta_username.Text = "";
                txta_passward.Text = "";
                txta_username.Focus();
            }
            conn.Close();
        }

        private void reset1_Click(object sender, EventArgs e)
        {
            txta_username.Text = "";
            txta_passward.Text = "";
            txta_username.Focus();
        }

        private void showpass1_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass1.Checked)
            {
                txta_passward.PasswordChar = '\0';
            }
            else
            {
                txta_passward.PasswordChar = '*';
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Adregister adr= new Adregister();
            adr.Show();
            this.Hide();
        }
    }
}
