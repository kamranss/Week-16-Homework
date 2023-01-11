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

        public enum MenuOptionsForAdmin
        {
            CreateUser = 1,
            DeleteUser,
            UpdateUser,
            SerchUserByid,
            SerchUserbyUsername,
            SerachUserbyName,
            FindAllUsers,
            ECreateStatus,
            DeleteStatus,
            UpdateStatus,
            SerchStatusByid,
            SerchStatusesByUserId,
            SearchStatusesByIdandDatetime,
            FindAllStatuses,
            Exit
        }
        public enum MenuOptionsForUser
        {
            CreateStatus = 1,
            SerchUserStatuses,
            SearchUserStatusesByDate,
            Exit
        }
    }
}
