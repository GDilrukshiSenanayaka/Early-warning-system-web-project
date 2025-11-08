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
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gayani\Documents\dms.db.mdf;Integrated Security=True;Connect Timeout=30");

            if (txtusername.Text == "" || txtpassward.Text == "" || txtcmpass.Text == "")
            {
                MessageBox.Show("Username and Passward fields are empty", "Registration Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtpassward.Text == txtcmpass.Text)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES('" + txtusername.Text + "','" + txtpassward.Text + "','" + txtcmpass.Text + "' ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                conn.Close();

                txtusername.Text = "";
                txtpassward.Text = "";
                txtcmpass.Text = "";

                MessageBox.Show("Your Account has been succesfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passward does not match,Please Re-enter", "Registration Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassward.Text = "";
                txtcmpass.Text = "";
                txtpassward.Focus();
            }
        }

        private void reset2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassward.Text = "";
            txtcmpass.Text = "";
            txtusername.Focus();
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                txtpassward.PasswordChar = '\0';
                txtcmpass.PasswordChar = '\0';
            }
            else
            {
                txtpassward.PasswordChar = '*';
                txtcmpass.PasswordChar = '*';
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

           UserLogin uslogin = new UserLogin();
            uslogin.Show();
            this.Hide();
        }

        private void UserRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
