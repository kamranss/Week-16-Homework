using Domain.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Utilities.Helper;

namespace PostApp.Controllers
{
    public class UserController
    {
        UserService userService;
        public UserController()
        {
            userService = new UserService();
        }
        Regex Passwordcheck3 = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

        public void CreateUser()
        {
            DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputName);
            string name = Console.ReadLine();
            DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputSurname);
            string surname = Console.ReadLine();
            WriteAgeAgain: DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputAge);
            string stringAge = Console.ReadLine();
            int Age;
        

            if (string.IsNullOrEmpty(stringAge))
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, "You cannot leave filed blank");
                goto WriteAgeAgain; 
            }
            
            bool convertedAge = int.TryParse(stringAge, out Age);
            if (!convertedAge)
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, "Something Went Wrong -> You should use digits");
                goto WriteAgeAgain; 
            }


            WriteUserNameAgain: DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputUsername);
            string username = Console.ReadLine();
            if (string.IsNullOrEmpty(username))
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, ConsoleMessages.UserNameEmpty);
                goto WriteUserNameAgain;
            }

            WriteUserPasswordAgain: DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputUserPassword);
            string password = Console.ReadLine();
            if (string.IsNullOrEmpty(password))
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, ConsoleMessages.UserPasswordEmpty);
                goto WriteUserPasswordAgain;
            }
            WriteUserRoleAgain: DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Yellow, ConsoleMessages.ListUserRoles);
            DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Yellow, ConsoleMessages.RoleNotice);
            DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputuserRole);
            int role = int.Parse(Console.ReadLine());

            if (role ==null)
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, ConsoleMessages.UserRoleWrong);
                goto WriteUserRoleAgain;

            }
            DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputEmailAddress);
            string emailaddress = Console.ReadLine();

        }
    }
}
