using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.User
{
    public class Teacher : User
    {
        public Teacher(string email, string password) : base(email, password)
        {
            Console.WriteLine("Teacher created");
        }

        public Teacher() : base("base_admin_email", "base_admin_password")
        {
            Console.WriteLine("Teacher created");
        }

        public void CheckHomework()
        {
            Console.WriteLine("Homework checked");
        }

        public bool ValidateAdminPassword()
        {
            return base.password.Length >= 10;
        }

        public string GetPassword()
        {
            return base.password;
        }
    }
}
