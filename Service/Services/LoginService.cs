using DataAccess.Repositories;
using Domain.Models;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                if (CheckRole(role))
                {
                    return AccountContans.SuperAdminValidEntrance;
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

        private bool CheckRole(int role)
        {
            switch (role)
            {
                case (int).Enums
                    return true;
                default:
                    return false;
            }
        }
    }
    }
}
