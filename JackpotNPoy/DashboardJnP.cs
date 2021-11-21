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
        //Runner
        RunnerData rt = new RunnerData();
        Random random = new Random();
        public DashboardJnP()
        {
            InitializeComponent();
            this.lblComputerBalance.Text = rt.Enemy_Balanc.ToString();
            this.textBoxBet.Enabled = false;
            this.btnLock.Enabled = false;


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


        private void linkLabelReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// Reset
        {
            btnLock.Enabled = true;
            textBoxBet.Enabled = true;
            btnPaper.Enabled = true;
            btnRock.Enabled = true;
            btnScissor.Enabled = true;
            roundedButtonPlay.Enabled = true;
            //Reset Color BTN
            //Not Select Other
            btnRock.BackColor = Color.White;
            btnRock.ForeColor = Color.Black;
            btnPaper.BackColor = Color.White;
            btnPaper.ForeColor = Color.Black;
            btnScissor.BackColor = Color.White;
            btnScissor.ForeColor = Color.Black;
            btnLock.BackColor = Color.White;
            btnLock.ForeColor = Color.Black;
            //Reset Bet
            playerImageBox.Image = global::JackpotNPoy.Properties.Resources.NoAnswer;
            enemyImagebox.Image = global::JackpotNPoy.Properties.Resources.NoAnswer;
            textBoxBet.Text = "";
        }

        private void roundedButtonPlay_Click(object sender, EventArgs e)//Start Play
        {
            roundedButtonPlay.BackColor = Color.SeaGreen;
            roundedButtonPlay.Enabled = false;

            //Start to Play
            int Computer_Enemy = random.Next(3);
            
            if (Computer_Enemy == 0) //Rock
            {
                //Show Enemy Pick
                this.enemyImagebox.Image = global::JackpotNPoy.Properties.Resources.Rock;
                //Show Player Pick
                if (this.btnRock.BackColor ==  Color.SeaGreen) { playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Rock; }
                else if (this.btnPaper.BackColor == Color.SeaGreen) { playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Paper; }
                else if (this.btnScissor.BackColor == Color.SeaGreen) { playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Scissor; }
                //Reward Function
                if (this.playerImageBox.Image == global::JackpotNPoy.Properties.Resources.Paper) // Win
                {
                    //Reward
                    this.BalanceC.Text += this.textBoxBet.Text + this.textBoxBet.Text;
                    //Cast Enemy Balance
                    rt.Enemy_Balanc -= float.Parse(this.textBoxBet.Text);
                    this.lblComputerBalance.Text = rt.Enemy_Balanc.ToString() ;
                    //Indicate
                    this.lblPlayerWL.Text = rt.playerName+" Win You lose!";
                }
                else if (this.playerImageBox.Image == global::JackpotNPoy.Properties.Resources.Scissor) //Lose
                {
                    //Lose Reward
                    rt.Enemy_Balanc += float.Parse(this.textBoxBet.Text + this.textBoxBet.Text);
                    //Indicate
                    this.lblPlayerWL.Text = "Computer Win You lose!";
                }
            }
            else if (Computer_Enemy == 1) //Paper
            {
                
                this.enemyImagebox.Image = global::JackpotNPoy.Properties.Resources.Paper;
                //Show Player Pick
                if (this.btnRock.BackColor == Color.SeaGreen) { playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Rock; }
                else if (this.btnPaper.BackColor == Color.SeaGreen) { playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Paper; }
                else if (this.btnScissor.BackColor == Color.SeaGreen) { playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Scissor; }
                //Reward Function
                if (this.playerImageBox.Image == global::JackpotNPoy.Properties.Resources.Scissor) // Win
                {
                    //Reward
                    this.BalanceC.Text += this.textBoxBet.Text + this.textBoxBet.Text;
                    //Cast Enemy Balance
                    rt.Enemy_Balanc -= float.Parse(this.textBoxBet.Text);
                    this.lblComputerBalance.Text = rt.Enemy_Balanc.ToString();
                    //Indicate
                    this.lblPlayerWL.Text = rt.playerName + " Win You lose!";
                }
                else if (this.playerImageBox.Image == global::JackpotNPoy.Properties.Resources.Rock) //Lose
                {
                    //Lose Reward
                    rt.Enemy_Balanc += float.Parse(this.textBoxBet.Text + this.textBoxBet.Text);
                    //Indicate
                    this.lblPlayerWL.Text = "Computer Win You lose!";
                }
            }
            else if (Computer_Enemy == 2)//Scissor
            {
                
                this.enemyImagebox.Image = global::JackpotNPoy.Properties.Resources.Scissor;
                //Show Player Pick
                if (this.btnRock.BackColor == Color.SeaGreen) { playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Rock; }
                else if (this.btnPaper.BackColor == Color.SeaGreen) { playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Paper; }
                else if (this.btnScissor.BackColor == Color.SeaGreen) { playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Scissor; }
                //Reward Function
                if (this.playerImageBox.Image == global::JackpotNPoy.Properties.Resources.Rock) // Win
                {
                    //Reward
                    this.BalanceC.Text += this.textBoxBet.Text + this.textBoxBet.Text;
                    //Cast Enemy Balance
                    rt.Enemy_Balanc -= float.Parse(this.textBoxBet.Text);
                    this.lblComputerBalance.Text = rt.Enemy_Balanc.ToString();
                    //Indicate
                    this.lblPlayerWL.Text = rt.playerName + " Win You lose!";
                }
                else if (this.playerImageBox.Image == global::JackpotNPoy.Properties.Resources.Paper) //Lose
                {
                    //Lose Reward
                    rt.Enemy_Balanc += float.Parse(this.textBoxBet.Text + this.textBoxBet.Text);
                    //Indicate
                    this.lblPlayerWL.Text = "Computer Win You lose!";

                }
            }

        }

        private void btnLock_Click(object sender, EventArgs e)//Lock
        {
            
            if (this.textBoxBet.Text== "0" || this.textBoxBet.Text == "") 
            {
                MessageBox.Show("Please Bet first, to start to play!", "Jackpot n' poy", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }else if (this.btnRock.BackColor == Color.SeaGreen || this.btnPaper.BackColor == Color.SeaGreen || this.btnScissor.BackColor == Color.SeaGreen) 
            {
                //Disable Other Key to Start
                btnLock.Enabled = false;
                textBoxBet.Enabled = false;
                btnPaper.Enabled = false;
                btnRock.Enabled = false;
                btnScissor.Enabled = false;
                //Change Color Lock
                btnLock.BackColor = Color.SeaGreen;
                
                //Balance Function
                float castLock = float.Parse(this.textBoxBet.Text);
                rt.Defualt_Balance -= castLock;
                //Update Balance
                this.BalanceC.Text = rt.Defualt_Balance.ToString();
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
                btnRock.BackColor = Color.SeaGreen;
                btnRock.ForeColor = Color.White;
                this.playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Rock;

                this.textBoxBet.Enabled = true;
                this.btnLock.Enabled = true;

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
                btnPaper.BackColor = Color.SeaGreen;
                btnPaper.ForeColor = Color.White;
                this.playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Paper;

                this.textBoxBet.Enabled = true;
                this.btnLock.Enabled = true;

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
                btnScissor.BackColor = Color.SeaGreen;
                btnScissor.ForeColor = Color.White;
                this.playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Scissor;

                this.textBoxBet.Enabled = true;
                this.btnLock.Enabled = true;

                //Not Select Other
                btnRock.BackColor = Color.White;
                btnRock.ForeColor = Color.Black;
                btnPaper.BackColor = Color.White;
                btnPaper.ForeColor = Color.Black;
            }

        }
    }
}
