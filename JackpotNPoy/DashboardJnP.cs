using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JackpotNPoy
{
    public partial class DashboardJnP : Form
    {
        public DashboardJnP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // ##asdasdasd
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogInForm logout = new LogInForm();
            logout.ShowDialog();
            this.Hide();
        }
    }
}
