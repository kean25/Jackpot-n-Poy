
namespace JackpotNPoy
{
    partial class DashboardJnP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPlayerBalance = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.imageData1 = new Tophet.ImageData();
            this.panel4 = new System.Windows.Forms.Panel();
            this.roundedButtonPlay = new Tophet.RoundedButton();
            this.btnLock = new System.Windows.Forms.Button();
            this.textBoxBet = new System.Windows.Forms.TextBox();
            this.btnScissor = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPlayerCountBattle = new System.Windows.Forms.Label();
            this.lblComputerBalance = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblPlayerWL = new System.Windows.Forms.Label();
            this.lblLinkSurrender = new System.Windows.Forms.LinkLabel();
            this.linkLabelReset = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageData1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(700, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(88, 47);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.imageData1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 102);
            this.panel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPlayerBalance);
            this.panel3.Location = new System.Drawing.Point(338, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 70);
            this.panel3.TabIndex = 10;
            // 
            // lblPlayerBalance
            // 
            this.lblPlayerBalance.AutoSize = true;
            this.lblPlayerBalance.Location = new System.Drawing.Point(15, 16);
            this.lblPlayerBalance.Name = "lblPlayerBalance";
            this.lblPlayerBalance.Size = new System.Drawing.Size(89, 15);
            this.lblPlayerBalance.TabIndex = 0;
            this.lblPlayerBalance.Text = "Player Balance: ";
            this.lblPlayerBalance.Click += new System.EventHandler(this.lblPlayerBalance_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.lblPlayerName);
            this.panel2.Location = new System.Drawing.Point(112, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 71);
            this.panel2.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(4, 46);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 15);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status: ";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(4, 13);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(80, 15);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player Name: ";
            this.lblPlayerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageData1
            // 
            this.imageData1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imageData1.Location = new System.Drawing.Point(12, 15);
            this.imageData1.Name = "imageData1";
            this.imageData1.Size = new System.Drawing.Size(80, 72);
            this.imageData1.TabIndex = 0;
            this.imageData1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.linkLabelReset);
            this.panel4.Controls.Add(this.roundedButtonPlay);
            this.panel4.Controls.Add(this.btnLock);
            this.panel4.Controls.Add(this.textBoxBet);
            this.panel4.Controls.Add(this.btnScissor);
            this.panel4.Controls.Add(this.btnPaper);
            this.panel4.Controls.Add(this.btnRock);
            this.panel4.Location = new System.Drawing.Point(542, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 353);
            this.panel4.TabIndex = 10;
            // 
            // roundedButtonPlay
            // 
            this.roundedButtonPlay.Location = new System.Drawing.Point(76, 199);
            this.roundedButtonPlay.Name = "roundedButtonPlay";
            this.roundedButtonPlay.Size = new System.Drawing.Size(110, 85);
            this.roundedButtonPlay.TabIndex = 5;
            this.roundedButtonPlay.Text = "Play";
            this.roundedButtonPlay.UseVisualStyleBackColor = true;
            this.roundedButtonPlay.Click += new System.EventHandler(this.roundedButtonPlay_Click);
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(158, 154);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(52, 24);
            this.btnLock.TabIndex = 4;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            // 
            // textBoxBet
            // 
            this.textBoxBet.Location = new System.Drawing.Point(51, 155);
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(109, 23);
            this.textBoxBet.TabIndex = 3;
            // 
            // btnScissor
            // 
            this.btnScissor.Location = new System.Drawing.Point(50, 116);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(160, 23);
            this.btnScissor.TabIndex = 2;
            this.btnScissor.Text = "Scissors";
            this.btnScissor.UseVisualStyleBackColor = true;
            this.btnScissor.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(50, 71);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(160, 23);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(50, 28);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(160, 23);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(25, 126);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 168);
            this.panel5.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 134);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Location = new System.Drawing.Point(288, 126);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(234, 168);
            this.panel6.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Location = new System.Drawing.Point(16, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 134);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblPlayerCountBattle
            // 
            this.lblPlayerCountBattle.AutoSize = true;
            this.lblPlayerCountBattle.Location = new System.Drawing.Point(25, 297);
            this.lblPlayerCountBattle.Name = "lblPlayerCountBattle";
            this.lblPlayerCountBattle.Size = new System.Drawing.Size(75, 15);
            this.lblPlayerCountBattle.TabIndex = 13;
            this.lblPlayerCountBattle.Text = "Show Count ";
            // 
            // lblComputerBalance
            // 
            this.lblComputerBalance.AutoSize = true;
            this.lblComputerBalance.Location = new System.Drawing.Point(385, 297);
            this.lblComputerBalance.Name = "lblComputerBalance";
            this.lblComputerBalance.Size = new System.Drawing.Size(137, 15);
            this.lblComputerBalance.TabIndex = 14;
            this.lblComputerBalance.Text = "Show Computer Balance";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Location = new System.Drawing.Point(25, 345);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(83, 72);
            this.panel7.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 66);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblPlayerWL);
            this.panel8.Location = new System.Drawing.Point(148, 345);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(229, 72);
            this.panel8.TabIndex = 16;
            // 
            // lblPlayerWL
            // 
            this.lblPlayerWL.AutoSize = true;
            this.lblPlayerWL.Location = new System.Drawing.Point(53, 22);
            this.lblPlayerWL.Name = "lblPlayerWL";
            this.lblPlayerWL.Size = new System.Drawing.Size(131, 15);
            this.lblPlayerWL.TabIndex = 0;
            this.lblPlayerWL.Text = "Show Player win or lose";
            this.lblPlayerWL.Click += new System.EventHandler(this.lblPlayerWL_Click);
            // 
            // lblLinkSurrender
            // 
            this.lblLinkSurrender.AutoSize = true;
            this.lblLinkSurrender.Location = new System.Drawing.Point(235, 426);
            this.lblLinkSurrender.Name = "lblLinkSurrender";
            this.lblLinkSurrender.Size = new System.Drawing.Size(58, 15);
            this.lblLinkSurrender.TabIndex = 17;
            this.lblLinkSurrender.TabStop = true;
            this.lblLinkSurrender.Text = "Surrender";
            // 
            // linkLabelReset
            // 
            this.linkLabelReset.AutoSize = true;
            this.linkLabelReset.Location = new System.Drawing.Point(113, 301);
            this.linkLabelReset.Name = "linkLabelReset";
            this.linkLabelReset.Size = new System.Drawing.Size(35, 15);
            this.linkLabelReset.TabIndex = 6;
            this.linkLabelReset.TabStop = true;
            this.linkLabelReset.Text = "Reset";
            this.linkLabelReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelReset_LinkClicked);
            // 
            // DashboardJnP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JackpotNPoy.Properties.Resources.darkmode;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLinkSurrender);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.lblComputerBalance);
            this.Controls.Add(this.lblPlayerCountBattle);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardJnP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jackpot n\' Poy";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageData1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPlayerBalance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPlayerName;
        private Tophet.ImageData imageData1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblPlayerCountBattle;
        private System.Windows.Forms.Label lblComputerBalance;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.LinkLabel lblLinkSurrender;
        private Tophet.RoundedButton roundedButtonPlay;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.TextBox textBoxBet;
        private System.Windows.Forms.Label lblPlayerWL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkLabelReset;
    }
}