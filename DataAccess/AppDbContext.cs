using DataAccess.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;

namespace DataAccess
{
    public class AppDbContext
    {
        public static List<Status>? Statuses { get; set; }
        public static List<User>? Users { get; set; }
        public static int? CountStatuses { get; set; } = 0;
        public static int? CountUsers { get; set; } = 0;
        public AppDbContext()
        {
            Statuses = new List<Status>();
            Users = new List<User>();

            
        }

        public bool DefaultUserCreation()
        {
            UserRepository userRepository = new UserRepository();

            User adminUser = new User();
            adminUser.Id = 0;
            adminUser.EmailAddress = "user@email.com";
            adminUser.Name = "system";
            adminUser.Age = 0;
            adminUser.Role = ConstantRoles.Admin;
            adminUser.Username = "admin";
            adminUser.Password = "Admin";           

            User user1 = new User();
            user1.Id = 0;
            user1.EmailAddress = "admin@email.com";
            user1.Name = "system";
            user1.Age = 0;
            user1.Role = ConstantRoles.User;
            user1.Username = "user";
            user1.Password = "User";

            userRepository.Create(adminUser);
            userRepository.Create(user1);
            return true;
        }
        
        
    }
}
;