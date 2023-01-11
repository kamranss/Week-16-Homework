using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

        }
    }
}
