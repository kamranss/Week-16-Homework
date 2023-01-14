using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class User : BaseInterface
    {
        public string? Name { get; set; } = null;
        public string? Surname { get; set; } = null;
        public int? Age { get; set; } = null;
        public string? EmailAddress { get; set; } = null;
        public string? Username { get; set; } = null;
        public string? Password { get; set; } = null;
        public string? Role { get; set; } = null;

        public static int? LoggedinCount { get; set; } = null;
        public int? Id { get; set; } = null;


        Regex EmailRegex = new Regex(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]{2,4}\b");
        Regex PasswordRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

        public bool PasswordChecker(string password)
        {
            if (PasswordRegex.IsMatch(password))
            {
                return true;
            }
            return false;
        }
        public bool EmailChecker(string email)
        {
            if (EmailRegex.IsMatch(email))
            {
                return true;
            }
            return false;
        }
    }
}
