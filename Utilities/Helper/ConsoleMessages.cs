using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helper
{
    public class ConsoleMessages
    {
        public const string ChooseOption = "Please choose one of the option from Menu bar:\n";
        public const string OptionsForAdmin =        
        "1 - Create User:\n" +
        "2 - UpdateUserInfo:\n" +
        "3 - DeleteUserInfo:\n" +
        "4 - SearchUserByid:\n" +
        "5 - SerchUserbyUsername:\n" +
        "6 - SerachUserbyName:\n" +
        "7 - FindAllUsers:\n" +
        "8 - ShareStatus:\n" +
        "9 - DeleteStatus:\n" +
       "10 - UpdateStatus:\n" +
       "11 - SerchStatusByid:\n" +
       "12 - SerchStatusesByuserid:\n" +
       "13 - SearchStatusByDate:\n"+
       "14 - FindAllStatuses:\n" +
       "15 - GetEmployeeById:\n" +
       "16 - ExitProgram:";

        public const string OptionsForUser=
       "Please choose one of the option from Menu bar:\n" +
       "5 - ShareStatus:\n" +
       "6 - FindUserStatuses:\n" +
       "7 - FindStatusesByDate:\n" +
       "8 - ExitProgram:";

        public const string WriteStatustitle = "Please Write Status Title";
        public const string WriteStatusContent = "Please Write Status Content";

        #region Error Messages Status
        public const string TitleEmpty = " Your can not create Status without title please try again";
        public const string ContentEmpty = "Your can not create Status without Content please try again";
        #endregion

        #region Login Messages
        public const string WriteUserName = "Write User Name";
        public const string WriteUserPassword = " Write User Password";
        public const string AccessGranted = "Accedd granted-> You Logged in";
        public const string AccessDenied = "Access Denied -> Please check Username and Password";
        #endregion

        #region Notice
        public const string EmailStructure = "Email should be provided according to given structure";
        public const string PasswordStructure = 
            "Password should follow provided structure\n" +
            "At least 8 character\n" +
            "Start with Big Letter\n"+
            "At least one digit and symbol\n";
        #endregion

        #region Register User
        public const string InputName = "Write user Name";
        public const string InputSurname = "Write user Surname";
        public const string InputAge = "Write user Age";
        public const string InputEmailAddress = "Write user Email";
        public const string InputUsername = "Write User username";
        public const string InputUserPassword = " Write user Password";
        public const string InputuserRole = "Write user Role";
        #endregion

    }
}
