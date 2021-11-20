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
        //Runner
        RunnerData rt = new RunnerData();
        Random random = new Random();
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


        private void linkLabelReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// Reset
        {
            btnLock.Enabled = true;
            textBoxBet.Enabled = true;
            btnPaper.Enabled = true;
            btnRock.Enabled = true;
            btnScissor.Enabled = true;
            roundedButtonPlay.Enabled = true;
            //Reset Bet
            textBoxBet.Text = "";
        }

        private void roundedButtonPlay_Click(object sender, EventArgs e)//Start Play
        {
            //Disable Other Key to Start
            btnLock.Enabled = false;
            textBoxBet.Enabled = false;
            btnPaper.Enabled = false;
            btnRock.Enabled = false;
            btnScissor.Enabled = false;
            roundedButtonPlay.Enabled = false;
            //Start to Play

            for (int i = 0; i<4; i++) 
            {
                MessageBox.Show(random.Next().ToString());
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if(this.textBoxBet.Text== "0" || this.textBoxBet.Text == "") 
            {
                MessageBox.Show("Please Bet first, to start to play!", "Jackpot n' poy", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else 
            {
                if (this.BalanceC.Text == "Infinite") 
                {
                    //Do nothing
                }
                else 
                {
                    //Check Balance
                    if (rt.Defualt_Balance <= 0) 
                    {
                        MessageBox.Show("OH, NO you don't have enough balance!", "Jackpot n' poy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        //Start
                        float castLock = float.Parse(this.textBoxBet.Text);
                        rt.Defualt_Balance -= castLock;
                        //Update Balance
                        this.BalanceC.Text = rt.Defualt_Balance.ToString();
                    }
                    
                }
            }
        
        }

        private void textBoxBet_TextChanged(object sender, EventArgs e)//Player Enter Bet
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
        private void btnRock_Click(object sender, EventArgs e) // Player Pick Rock
        {
            if (btnRock.Focused == true)
            {
                //Enable Indicate
                btnRock.BackColor = Color.Black;
                btnRock.ForeColor = Color.White;
                
                //Not Select Other
                btnPaper.BackColor = Color.White;
                btnPaper.ForeColor = Color.Black;
                btnScissor.BackColor = Color.White;
                btnScissor.ForeColor = Color.Black;
            }


        }

        private void btnPaper_Click(object sender, EventArgs e)//Player Pick Paper
        {
            if (btnPaper.Focused == true)
            {
                //Enable Indicate
                btnPaper.BackColor = Color.Black;
                btnPaper.ForeColor = Color.White;
                
                //Not Select Other
                btnRock.BackColor = Color.White;
                btnRock.ForeColor = Color.Black;
                btnScissor.BackColor = Color.White;
                btnScissor.ForeColor = Color.Black;
            }

        }

        private void btnScissor_Click(object sender, EventArgs e)// Player pick Scissor
        {
            if (btnScissor.Focused == true)
            {
                //Enable Indicate
                btnScissor.BackColor = Color.Black;
                btnScissor.ForeColor = Color.White;
                //Not Select Other
                btnRock.BackColor = Color.White;
                btnRock.ForeColor = Color.Black;
                btnPaper.BackColor = Color.White;
                btnPaper.ForeColor = Color.Black;
            }

        }
    }
}
