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
        public bool Login(string username, string password)
        {
            User user = userRepository.Get(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                if (CheckRole(user.Role))
                {
                    Console.WriteLine(ConsoleMessages.AccessGranted); 
                    return true; ;
                }
                else
                {
                    return AccountContans.SuperAdminCredentialsInvalid;
                }
            }
            else
            {
                return AccountContans.CredentialsInvalid;
            }
        }

        private bool CheckRole(string role)
        {
            if (role  == ConstantRoles.Admin)
            {
                return true;
            }
            return false;
        }
    }
    }
}
