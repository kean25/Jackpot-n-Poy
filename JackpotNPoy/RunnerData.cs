using System;
using System.Collections.Generic;
using System.Text;

namespace JackpotNPoy
{
    class RunnerData
    {
        private string Email,Password;
        private string PlayerName;
        private Tophet.ImageData PlayerProfile = new Tophet.ImageData();
        public string Trial_Name = "Guest"; //Guest
        public string Status_Trial = "Trial"; // Guest
        public string Status_Player = "Player"; // Player
        public float Defualt_Balance = 5000.00f; // Player
        public float Enemy_Balanc = 5000.00f; // Enemy
        public string Trial_Balance = "Infinite"; // Guest

        public Tophet.ImageData playerProfile 
        {
            get { return this.PlayerProfile; }
            set { this.PlayerProfile = value; }

        }
        public string playerName 
        {
            get { return PlayerName; }
            set { PlayerName = value; }
        }
        public string email 
        {
            get { return Email; }
            set { Email = value; }
        }
        public string password 
        {
            get { return Password; }
            set { Password = value; }
        }

        public RunnerData() 
        {
            //Default Properties
            this.playerProfile.Image = global::JackpotNPoy.Properties.Resources.Userprofilepicture;
            this.playerName = "Kazuma";
            this.email = "Admin";
            this.password = "admin";
        }
    }
}
