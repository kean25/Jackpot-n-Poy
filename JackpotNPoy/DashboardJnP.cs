using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace JackpotNPoy
{
    public partial class DashboardJnP : Form
    {
        //Border
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        //Runner
        RunnerData rt = new RunnerData();
        Random random = new Random();
        public DashboardJnP()
        {
            InitializeComponent();
            this.lblComputerBalance.Text = rt.Enemy_Balanc.ToString();
            this.textBoxBet.Enabled = false;
            //Border
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


        }
        //Changes Function
        public PictureBox profileChange {get { return this.imageData1; }set { this.imageData1 = (Tophet.ImageData)value; }}
        public Label playerChangeName {get { return this.PlayerNameLabelC; }set { this.PlayerNameLabelC = value; }}
        public Label statusC {get { return this.StatusC; }set { this.StatusC = value; }}
        public Label balanceC  {get { return this.BalanceC; }set { this.BalanceC = value; }}
        public Label ComputerBalance {get { return lblComputerBalance; }set { lblComputerBalance = value; }}
        public Button ButtonPlay {get { return roundedButtonPlay; }set { roundedButtonPlay = (Tophet.RoundedButton)value; }}
        public LinkLabel Reset { get { return this.linkLabelReset; } set { this.linkLabelReset = value; } }
        public TextBox TextBet { get { return textBoxBet; }set { textBoxBet = value; } }
        public LinkLabel guestReset { get { return ResetGuest; }set { ResetGuest = value; } }
        public Button LockMe { get { return btnLock; } set { btnLock = value; } }

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
            btnPaper.Enabled = true;
            btnRock.Enabled = true;
            btnScissor.Enabled = true;
            textBoxBet.Enabled = false;
            roundedButtonPlay.Enabled = false;
            
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
            WandL.Image = global::JackpotNPoy.Properties.Resources.NoAnswer2;
            playerImageBox.Image = global::JackpotNPoy.Properties.Resources.NoAnswer2;
            enemyImagebox.Image = global::JackpotNPoy.Properties.Resources.NoAnswer2;
            textBoxBet.Text = "";

        }

        private void roundedButtonPlay_Click(object sender, EventArgs e)//Start Play
        {
            roundedButtonPlay.BackColor = Color.SeaGreen;
            roundedButtonPlay.Enabled = false;

            //Start to Play
            int Computer_Enemy = random.Next(3);
            // Registered Player
            if (this.statusC.Text == rt.Status_Player) 
            {
                if (Computer_Enemy == 0) //Rock
                {
                    //Show Enemy Pick
                    this.enemyImagebox.Image = global::JackpotNPoy.Properties.Resources.Rock;
                    //Show Player Pick
                    if (this.btnRock.BackColor == Color.SeaGreen) { playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Rock; }
                    else if (this.btnPaper.BackColor == Color.SeaGreen) { playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Paper; }
                    else if (this.btnScissor.BackColor == Color.SeaGreen) { playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Scissor; }
                    //Reward Function
                    if (this.btnPaper.BackColor == Color.SeaGreen) // Win using Paper
                    {
                        //Reward
                        rt.Defualt_Balance += float.Parse(textBoxBet.Text) * 2;
                        this.BalanceC.Text = rt.Defualt_Balance.ToString();
                        //Cast Enemy Balance
                        rt.Enemy_Balanc -= float.Parse(this.textBoxBet.Text);
                        this.lblComputerBalance.Text = rt.Enemy_Balanc.ToString();
                        //Indicate
                        this.lblPlayerWL.Text = rt.playerName + " Win!";
                        this.WandL.Image = global::JackpotNPoy.Properties.Resources.Money;
                        if (rt.Enemy_Balanc <= 0)
                        {
                            this.lblPlayerWL.Text = "Enemy Computer bankrupt. Win!";
                            this.panel6.BackColor = Color.Red;
                        }
                    }
                    else if (this.btnScissor.BackColor == Color.SeaGreen) //Lose using scissor
                    {
                        //Lose Reward
                        rt.Enemy_Balanc += float.Parse(this.textBoxBet.Text) * 2;
                        //Indicate
                        this.lblPlayerWL.Text = "Computer Win You lose!";
                        this.WandL.Image = global::JackpotNPoy.Properties.Resources.lose;
                        
                    }
                    else // Draw
                    {
                        rt.Defualt_Balance += float.Parse(textBoxBet.Text);
                        this.BalanceC.Text = rt.Defualt_Balance.ToString();
                        this.lblPlayerWL.Text = "Draw";

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
                    if (this.btnScissor.BackColor == Color.SeaGreen) // Win using scissor
                    {
                        //Reward
                        rt.Defualt_Balance += float.Parse(textBoxBet.Text) * 2;
                        this.BalanceC.Text = rt.Defualt_Balance.ToString();
                        //Cast Enemy Balance
                        rt.Enemy_Balanc -= float.Parse(this.textBoxBet.Text);
                        this.lblComputerBalance.Text = rt.Enemy_Balanc.ToString();
                        //Indicate
                        this.lblPlayerWL.Text = rt.playerName + " Win!";
                        this.WandL.Image = global::JackpotNPoy.Properties.Resources.Money;
                        if (rt.Enemy_Balanc <= 0)
                        {
                            this.lblComputerBalance.Text = "Enemy Computer bankrupt. Win!";
                            this.panel6.BackColor = Color.Red;
                        }
                    }
                    else if (this.btnRock.BackColor == Color.SeaGreen) //Lose using rock
                    {
                        //Lose Reward
                        rt.Enemy_Balanc += float.Parse(this.textBoxBet.Text) * 2;
                        //Indicate
                        this.lblPlayerWL.Text = "Computer Win You lose!";
                        this.WandL.Image = global::JackpotNPoy.Properties.Resources.lose;
                    }
                    else // Draw
                    {
                        rt.Defualt_Balance += float.Parse(textBoxBet.Text);
                        this.BalanceC.Text = rt.Defualt_Balance.ToString();
                        this.lblPlayerWL.Text = "Draw";
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
                    if (this.btnRock.BackColor == Color.SeaGreen) // Win using rock
                    {
                        //Reward
                        rt.Defualt_Balance += float.Parse(textBoxBet.Text) * 2;
                        this.BalanceC.Text = rt.Defualt_Balance.ToString();
                        //Cast Enemy Balance
                        rt.Enemy_Balanc -= float.Parse(this.textBoxBet.Text);
                        this.lblComputerBalance.Text = rt.Enemy_Balanc.ToString();
                        //Indicate
                        this.lblPlayerWL.Text = rt.playerName + " Win!";
                        this.WandL.Image = global::JackpotNPoy.Properties.Resources.Money;
                        if (rt.Enemy_Balanc <= 0)
                        {
                            this.lblComputerBalance.Text = "Enemy Computer bankrupt. Win!";
                            this.panel6.BackColor = Color.Red;
                        }
                    }
                    else if (this.btnPaper.BackColor == Color.SeaGreen) //Lose using paper
                    {
                        //Lose Reward
                        rt.Enemy_Balanc += float.Parse(this.textBoxBet.Text) * 2;
                        //Indicate
                        this.lblPlayerWL.Text = "Computer Win You lose!";
                        this.WandL.Image = global::JackpotNPoy.Properties.Resources.lose;

                    }
                    else // Draw
                    {
                        rt.Defualt_Balance += float.Parse(textBoxBet.Text);
                        this.BalanceC.Text = rt.Defualt_Balance.ToString();
                        this.lblPlayerWL.Text = "Draw";
                    }

                }

            }
            //Guest
            else if (this.statusC.Text == rt.Status_Trial) 
            {
                if (Computer_Enemy == 0) //Rock
                {
                    //Show Enemy Pick
                    this.enemyImagebox.Image = global::JackpotNPoy.Properties.Resources.Rock;
                    //Show Player Pick
                    if (this.btnRock.BackColor == Color.SeaGreen) { playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Rock; }
                    else if (this.btnPaper.BackColor == Color.SeaGreen) { playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Paper; }
                    else if (this.btnScissor.BackColor == Color.SeaGreen) { playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Scissor; }
                    //Reward Function
                    if (this.btnPaper.BackColor == Color.SeaGreen) // Win using Paper
                    {
                        //Indicate
                        this.lblPlayerWL.Text = rt.Trial_Name + " Win!";
                        this.WandL.Image = global::JackpotNPoy.Properties.Resources.Money;
                       
                    }
                    else if (this.btnScissor.BackColor == Color.SeaGreen) //Lose using scissor
                    {
                        //Indicate
                        this.lblPlayerWL.Text = "Computer Win You lose!";
                        this.WandL.Image = global::JackpotNPoy.Properties.Resources.lose;
                    }
                    else // Draw
                    {
   
                        this.lblPlayerWL.Text = "Draw";

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
                    if (this.btnScissor.BackColor == Color.SeaGreen) // Win using scissor
                    {
                        
                        //Indicate
                        this.lblPlayerWL.Text = rt.Trial_Name + " Win!";
                        this.WandL.Image = global::JackpotNPoy.Properties.Resources.Money;
                        
                    }
                    else if (this.btnRock.BackColor == Color.SeaGreen) //Lose using rock
                    {
                        
                        //Indicate
                        this.lblPlayerWL.Text = "Computer Win You lose!";
                        this.WandL.Image = global::JackpotNPoy.Properties.Resources.lose;
                    }
                    else // Draw
                    {
                      
                        this.lblPlayerWL.Text = "Draw";
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
                    if (this.btnRock.BackColor == Color.SeaGreen) // Win using rock
                    {
                        //Indicate
                        this.lblPlayerWL.Text = rt.Trial_Name + " Win!";
                        this.WandL.Image = global::JackpotNPoy.Properties.Resources.Money;
                        
                    }
                    else if (this.btnPaper.BackColor == Color.SeaGreen) //Lose using paper
                    {
                        
                        //Indicate
                        this.lblPlayerWL.Text = "Computer Win You lose!";
                        this.WandL.Image = global::JackpotNPoy.Properties.Resources.lose;

                    }
                    else // Draw
                    {
                        
                        this.lblPlayerWL.Text = "Draw";
                    }

                }

            }


        }

        private void btnLock_Click(object sender, EventArgs e)//Lock
        {
            
            if (this.textBoxBet.Text== "0" || this.textBoxBet.Text == "") 
            {
                MessageBox.Show("Please Bet first, to start to play!", "Jackpot n' poy", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (float.Parse(textBoxBet.Text) > float.Parse(BalanceC.Text) || float.Parse(textBoxBet.Text) <= 0)
            {
                MessageBox.Show("Not enough Balance!", "Jackpot n' poy", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (this.btnRock.BackColor == Color.SeaGreen || this.btnPaper.BackColor == Color.SeaGreen || this.btnScissor.BackColor == Color.SeaGreen) 
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
                if(this.statusC.Text == rt.Status_Player) 
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
                else 
                {
                    //Enable Indicate
                    btnRock.BackColor = Color.SeaGreen;
                    btnRock.ForeColor = Color.White;
                    this.playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Rock;

                    //Not Select Other
                    btnPaper.BackColor = Color.White;
                    btnPaper.ForeColor = Color.Black;
                    btnScissor.BackColor = Color.White;
                    btnScissor.ForeColor = Color.Black;
                }
                
            }


        }

        private void btnPaper_Click(object sender, EventArgs e)//Player Pick Paper
        {
            if (btnPaper.Focused == true)
            {
                if(this.statusC.Text == rt.Status_Player) 
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
                else 
                {

                    //Enable Indicate
                    btnPaper.BackColor = Color.SeaGreen;
                    btnPaper.ForeColor = Color.White;
                    this.playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Paper;

                    //Not Select Other
                    btnRock.BackColor = Color.White;
                    btnRock.ForeColor = Color.Black;
                    btnScissor.BackColor = Color.White;
                    btnScissor.ForeColor = Color.Black;
                }
                
            }

        }

        private void btnScissor_Click(object sender, EventArgs e)// Player pick Scissor
        {
            if (btnScissor.Focused == true)
            {
                if(this.statusC.Text == rt.Status_Player) 
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
                else 
                {
                    //Enable Indicate
                    btnScissor.BackColor = Color.SeaGreen;
                    btnScissor.ForeColor = Color.White;
                    this.playerImageBox.Image = global::JackpotNPoy.Properties.Resources.Scissor;

                    //Not Select Other
                    btnRock.BackColor = Color.White;
                    btnRock.ForeColor = Color.Black;
                    btnPaper.BackColor = Color.White;
                    btnPaper.ForeColor = Color.Black;

                }
                
            }

        }

        private void ResetGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnLock.Enabled = false;
            btnPaper.Enabled = true;
            btnRock.Enabled = true;
            btnScissor.Enabled = true;
            textBoxBet.Enabled = false;
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
            WandL.Image = global::JackpotNPoy.Properties.Resources.NoAnswer2;
            playerImageBox.Image = global::JackpotNPoy.Properties.Resources.NoAnswer2;
            enemyImagebox.Image = global::JackpotNPoy.Properties.Resources.NoAnswer2;
            textBoxBet.Text = "";

        }
    }
}
