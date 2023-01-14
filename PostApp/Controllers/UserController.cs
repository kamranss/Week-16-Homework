using DataAccess;
using DataAccess.Repositories;
using Domain.Models;
using Service.Interface;
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

    
        public void CreateUser()
        {
            DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputName);
            string name = Console.ReadLine();
            DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputSurname);
            string surname = Console.ReadLine();
            WriteAgeAgain: DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputAge);
            string stringAge = Console.ReadLine();
            int age;
        

            if (string.IsNullOrEmpty(stringAge))
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, "You cannot leave filed blank");
                goto WriteAgeAgain; 
            }
            
            bool convertedAge = int.TryParse(stringAge, out age);
            if (!convertedAge)
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, "Something Went Wrong -> You should use digits");
                goto WriteAgeAgain; 
            }


            WriteUserNameAgain: DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputUsername);
            string username = Console.ReadLine();
            if (string.IsNullOrEmpty(username))
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, ConsoleMessages.FieldEmpty);
                goto WriteUserNameAgain;
            }

            WriteUserPasswordAgain: DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkGreen, ConsoleMessages.PasswordStructure);
            DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputUserPassword);
            string password = Console.ReadLine();
            if (string.IsNullOrEmpty(password))
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, ConsoleMessages.FieldEmpty);
                goto WriteUserPasswordAgain;
            }

            User user = new User();
            if (!user.PasswordChecker(password))
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, ConsoleMessages.PasswordFaild);
                goto WriteUserPasswordAgain;
            }

            WriteEmailAgain: DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkGreen, ConsoleMessages.EmailStructure);
            DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputEmailAddress);
            string emailaddress = Console.ReadLine();
            if (string.IsNullOrEmpty(emailaddress))
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkRed, ConsoleMessages.FieldEmpty);
                goto WriteEmailAgain;
            }

            if (!user.EmailChecker(emailaddress))
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkRed, ConsoleMessages.EmailFaild);
                goto WriteEmailAgain;
            }

            WriteUserRoleAgain: DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Yellow, ConsoleMessages.ListUserRoles);
            DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Yellow, ConsoleMessages.RoleNotice);
            DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.InputuserRole);
            string selectedRole = (Console.ReadLine());

            if (string.IsNullOrEmpty(selectedRole))
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, ConsoleMessages.UserRoleWrong);
                goto WriteUserRoleAgain;
            }
            int role;
            bool convertedRole = int.TryParse(selectedRole, out role);
            if (!convertedRole || role > 3)
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, ConsoleMessages.UserRoleWrong);
                goto WriteUserRoleAgain;
            }

            user.Name = name;
            user.Surname = surname;
            user.Age = age;
            user.Username = username;
            user.EmailAddress = emailaddress;
            user.Password = password;
            if (role == 1)
            {
                user.Role = ConstantRoles.Admin;
            }
            else if (role == 2)
            {
                user.Role = ConstantRoles.User;
            }
            else
            {
                user.Role = ConstantRoles.DataBaseAdmin;
            }

            User newUser = userService.Create(user);
            if (newUser != null)
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.White, "Following User Created");
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Green,
                $"Id - {newUser.Id}  |" +
                $"Name - {newUser.Name}  |" +
                $"Surname - {newUser.Surname}  |" +
                $"Age- {newUser.Age}  |" +
                $"Username - {newUser.Username}  |" +
                $"Emailaddress - {newUser.EmailAddress}  |" +
                $"Role - {newUser.Role}  |");
            }
            else
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkRed, "Something Went Wrong: User not Created");
            }
            

        }

        public void FindAllUsers()
        {
            List<User> users = new List<User>();
            users = userService.GetAll();
            if (AppDbContext.CountUsers != 0)
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.ListStatuses);
                foreach (var item in users)
                {
                    DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.White, "Following User Created");
                    DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Green,
                    $"Id - {item.Id}  |" +
                    $"Name - {item.Name}  |" +
                    $"Surname - {item.Surname}  |" +
                    $"Age- {item.Age}  |" +
                    $"Username - {item.Username}  |" +
                    $"Emailaddress - {item.EmailAddress}  |" +
                    $"Role - {item.Role}  |");


                }
            }
            else
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.NoStatusInDatabase);
            }
        }

    }
}
