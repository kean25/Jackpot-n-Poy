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
        public PictureBox profileChange 
        {
            get { return this.imageData1; }
            set { this.imageData1 = (Tophet.ImageData)value; }
        }
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

        private void btnLock_Click(object sender, EventArgs e)
        {
            if(this.textBoxBet.Text== "0" || this.textBoxBet.Text == "") 
            {
                MessageBox.Show("Please Bet first, to start to play!", "Jackpot n' poy", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void textBoxBet_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxBet.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Number Only!", "Jackpot n' poy", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBoxBet.Text = textBoxBet.Text.Remove(textBoxBet.Text.Length - 1);

            }
            else if (this.textBoxBet.Text ==  "0" || this.textBoxBet.Text == "")
            {
                
                this.roundedButtonPlay.Enabled = false;
                this.roundedButtonPlay.Text = "Bet first!";
                this.roundedButtonPlay.BackColor = Color.DarkGray;
                this.roundedButtonPlay.ForeColor = Color.DarkRed;
            }
            else if (this.textBoxBet.Text.Length >= 1)
            {
                this.roundedButtonPlay.Enabled = true;
                this.roundedButtonPlay.Text = "Play";
                this.roundedButtonPlay.ForeColor = Color.White;
                this.roundedButtonPlay.BackColor = Color.Black;
            }


        }
    }
}
