using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JackpotNPoy
{
    public partial class LogInForm : Form
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
        public LogInForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        RunnerData rt = new RunnerData();
        DashboardJnP djp = new DashboardJnP();
        PictureBox pb = new PictureBox();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.Silver;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.PasswordChar = '*';
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.PasswordChar = default;
                textBoxPassword.ForeColor = Color.Silver;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == rt.email && textBoxPassword.Text == rt.password) 
            {
                
                //Function
                djp.playerChangeName.Text = rt.playerName; // Change Name
                djp.statusC.Text = rt.Status_Player; // Change Status
                djp.balanceC.Text = rt.Defualt_Balance.ToString(); // Player Balance 5000
                djp.profileChange.Image = rt.playerProfile.Image; // Player set Image
                //Change Tab
                this.Hide();
                djp.ShowDialog();
                djp.ShowDialog();
                this.Close();
            }
            MessageBox.Show("Email or Password are incorrect please try again.", "JackPotNPoy", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Guest
        {
            //Function
            djp.playerChangeName.Text = rt.Trial_Name; // Change Name
            djp.statusC.Text = rt.Status_Trial; // Change Status
            djp.balanceC.Text = rt.Trial_Balance; // Guest Balance Infinite
            
            //Change Tab                   
            this.Hide();
            djp.ShowDialog();
            djp.ShowDialog();
            this.Close();

        }

        private void ExitProgram_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
