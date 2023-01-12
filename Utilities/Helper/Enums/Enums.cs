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

        public enum MenuOptions
        {
            CreateUser = 1,
            CreateStatus,
            FindAllStatuses,
            FindAllUsers,
            DeleteUser,
            UpdateUser,
            SerchUserByid,
            SerchUserbyUsername,
            SerachUserbyName,          
            ECreateStatus,
            DeleteStatus,
            UpdateStatus,
            SerchStatusByid,
            SerchStatusesByUserId,
            SearchStatusesByIdandDatetime,          
            SerchUserStatuses,
            SearchUserStatusesByDate,
            LogOut,
            Exit

        }
        
    }
}
