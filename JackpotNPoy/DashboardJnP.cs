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
        //Changes Function
        public Label playerChangeName 
        {
            get { return this.PlayerNameLabelC; }
            set { this.PlayerNameLabelC = value; }
        }
        public Label statusC 
        {
            get { return this.StatusC; }
            set { this.StatusC = value; }

        }
        public Label balanceC  
        {
            get { return this.BalanceC; }
            set { this.BalanceC = value; }

        }
        //Function
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogInForm logout = new LogInForm();
            
            this.Hide();
            logout.ShowDialog();
            this.Close();
        }


        private void linkLabelReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelReset.Enabled = false;
        }

        private void roundedButtonPlay_Click(object sender, EventArgs e)
        {
            linkLabelReset.Enabled = true;
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            


        }
    }
}
