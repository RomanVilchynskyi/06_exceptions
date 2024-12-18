using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06_exceptions
{
    internal class Acount
    {
        private string email;
        private string password;

        public string Email
        {
            get => email;
            set
            {
                if (!ValidateEmail(value))
                    throw new ArgumentException("Invalid email format");
                email = value;
            }
        }

        private bool ValidateEmail(string email)
        {
            if (email.Length < 4 || email.Length > 50)
                return false;

            if (!email.Contains("@"))
                return false;

            foreach (char c in email)
            {
                if (!(char.IsLetterOrDigit(c) || c == '_' || c == '@'))
                    return false;
            }

            return true;
        }

    }
}
