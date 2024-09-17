using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.User
{
    public class User
    {
        public string Email { get; private set; }
        protected string password;

        public User(string email, string password)
        {
            Email = email;
            this.password = password;
        }

        public void Authorize(string emailInput, string passwordInput)
        {
            if (this.Email == emailInput && this.password == passwordInput)
            { 
                Console.WriteLine("You are authorized");
            }
            else
            {
                Console.WriteLine("You are not authorized");
            }
        }
    }
}
