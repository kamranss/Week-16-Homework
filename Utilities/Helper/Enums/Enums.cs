using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helper.Enums
{
    public static class Enums
    {
        public enum Roles
        {
            Admin,
            User,
            DataBaseAdministrator
        }

        public enum MenuOptionsForUser
        {
            CreateUser = 1,
            DeleteUser,
            UpdateUser,
            SerchUserByid,
            SerchUserbyUsername,
            SerachUserbyName,
            FindAllUsers
        }
        public enum MenuOptionsForStatus
        {
            CreateStatus = 1,
            DeleteStatus,
            UpdateStatus,
            SerchStatusByid,
            SerchStatusesByUserId,
            SerachUserbyName,
            FindAllStatuses
        }
    }
}
