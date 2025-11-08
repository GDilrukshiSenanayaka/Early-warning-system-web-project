using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisasterManagementSystem
{
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation Message",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Users_Click(object sender, EventArgs e)
        {
            Approval approval = new Approval();
            approval.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports rpts = new Reports();
            rpts.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void RealTimeAlert_Click(object sender, EventArgs e)
        {
            RealTimeAlert rta = new RealTimeAlert();
            rta.Show();
            this.Show();
        }
    }
}
