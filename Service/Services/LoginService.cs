using DataAccess;
using DataAccess.Repositories;
using Domain.Models;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;
using Utilities.Helper.Enums;

namespace Service.Services
{
    public class LoginService : ILoginService
    {
        UserRepository userRepository;
        public LoginService()
        {
            userRepository = new UserRepository();
        }
        public User Login(string username, string password)
        {
            AppDbContext appDbContext = new AppDbContext();

            appDbContext.DefaultUserCreation();


            User user = userRepository.Get(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                User.LoggedinCount++;
                Console.WriteLine(User.LoggedinCount);
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkGreen, ConsoleMessages.AccessGranted);
                return user;
                
            }
            else
            {
                
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkRed, ConsoleMessages.AccessDenied);                
                return user;
                
            }
        }

        //public bool CheckRole(string role)
        //{
        //    if (role  == ConstantRoles.Admin)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
    
}
