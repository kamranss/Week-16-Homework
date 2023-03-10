using DataAccess;
using DataAccess.Repositories;
using Domain.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;

namespace PostApp.Controllers
{
    public class LoginController
    {
        UserRepository userRepository;
        LoginService loginService;
        public LoginController()
        {
            userRepository = new UserRepository();
            loginService = new LoginService();
        }
        
        public User LoginToSystem()
        {
            DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.WriteUserName);
            string username = Console.ReadLine();
            DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.WriteUserPassword);
            string password = Console.ReadLine();

            User user = loginService.Login(username, password);         
            if (user != null)
            {
                return user;
               
            }           
            return null;

        }
        
        public bool CheckUserkRole(string role)
        {
            if (role == ConstantRoles.User)
            {
                return true;
            }
            return false;
        }


    }
}
