using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace DisasterManagementSystem
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gayani\Documents\dms.db.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string username = txtc_username.Text;
            string password = txtc_passward.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users where username = '" + txtc_username + "' and Password ='" + txtc_passward + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (txtc_username.Text == "User" && txtc_passward.Text == "user123")
            {
                new CustomerDash().Show();
            }
            else
            {
                MessageBox.Show("Invalied Username or Password, Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtc_username.Text = "";
                txtc_passward.Text = "";
                txtc_username.Focus();
            }
            conn.Close();
        }

        private void reset1_Click(object sender, EventArgs e)
        {

            txtc_username.Text = "";
            txtc_passward.Text = "";
            txtc_username.Focus();
        }

        private void showpass1_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass1.Checked)
            {
                txtc_passward.PasswordChar = '\0';
            }
            else
            {
                txtc_passward.PasswordChar = '*';
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UserRegister ur = new UserRegister();
           ur.Show();
            this.Hide();
        }
    }
}
