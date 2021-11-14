using System;
using System.Collections.Generic;
using System.Text;

namespace JackpotNPoy
{
    class RunnerData
    {
        private string Email,Password;

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
            this.email = "admin";
            this.password = "admin";
        }
    }
}
