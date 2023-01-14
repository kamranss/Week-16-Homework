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
            ShareStatus,
            FindAllStatuses,
            FindAllUsers,
            FindStatusByDateandUserId,
            SerchStatusByid,
            DeleteStatus,
            DeleteUser,
            UpdateUser,
            SerchUserByid,
            SerchUserbyUsername,
            SerachUserbyName,          
            ECreateStatus,
            UpdateStatus,
            SerchStatusesByUserId,
            SearchStatusesByIdandDatetime,          
            SerchUserStatuses,
            SearchUserStatusesByDate,
            LogOut,
            LogOut2,
            Exit

        }
        
    }
}
