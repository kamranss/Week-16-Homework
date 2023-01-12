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
        

            if (stringAge != null)
            {
                bool convertedAge = int.TryParse(stringAge, out Age);
                if (convertedAge)
                {
                    DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputEmailAddress);
                    string emailaddress = Console.ReadLine();

                    DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputUsername);
                    string username = Console.ReadLine();

                    DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputUserPassword);
                    string password = Console.ReadLine();

                    DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputuserRole);
                    string role = Console.ReadLine();                    

                }
            }
            else
            {
                goto WriteAgeAgain; DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, "Something Went Wrong -> You should use digits");
            }
            








        }
    }
}
