﻿using DataAccess.Repositories;
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
        public static List<Status> Statuses { get; set; }
        public static List<User> Users { get; set; }
        public AppDbContext()
        {
            Statuses = new List<Status>();
            Users = new List<User>();
        }

        public User AdminUserCreation()
        {
            UserRepository userRepository = new UserRepository();

            User adminUser = new User();
            adminUser.Id = 0;
            adminUser.EmailAddress = "admin@email.com";
            adminUser.Name = "system";
            adminUser.Age = 0;
            adminUser.Role = ConstantRoles.Admin;
            adminUser.Username = "admin";
            adminUser.Password = "Admin";
            return adminUser;           

            User user1 = new User();
            user1.Id = 0;
            user1.EmailAddress = "admin@email.com";
            user1.Name = "system";
            user1.Age = 0;
            user1.Role = ConstantRoles.Admin;
            user1.Username = "admin";
            user1.Password = "Admin";
            return adminUser;

            userRepository.Create(adminUser);
            userRepository.Create(user1);

        }
        
        
    }
}
;