using System;
using System.Collections.Generic;
using System.Text;

namespace MoniHealth.Models
{
    class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {

        }
        public User(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }
        public bool checkInformation()
        {
            if (this.Email != null && this.Password != null)
                return true;
            else
                return false;
        }
    }
}
