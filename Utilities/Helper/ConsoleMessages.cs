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
        "2 - ShareStatus:\n" +
        "3 - FindAllStatuses:\n" +
        "4 - FindAllUsers:\n" +
        "5 - FindStatusByDateandUserId:\n" +
        "6 - SerchStatusByid\n" +
        "7 - DeleteUser:\n" +
        "8 - UpdateUser:\n" +
        "9 - SerchUserByid:\n" +
        "10 - SerchUserbyUsername:\n" +
        "11 - SerachUserbyName:\n" +
       "12 - CreateStatus:\n" +
       "13 - DeleteStatus:\n" +
       "14 - UpdateStatus:\n" +      
       "15 - SerchStatusesByUserId:\n" +
       "16 - SearchStatusesByIdandDatetime:\n" +
       "17 - SerchUserStatuses:\n" +
       "18 - SearchUserStatusesByDate:\n" +
       "19 - LogOut:\n" +
       "20 - Exit:";


        public const string OptionsForUser=
       "Please choose one of the option from Menu bar:\n" +
       "1 - ShareStatus:\n" +
       "2 - FindUserStatuses:\n" +
       "3 - FindStatusesByDate:\n" +
       "4 - ExitProgram:";

        public const string WriteStatustitle = "Please Write Status Title";
        public const string WriteStatusContent = "Please Write Status Content";
        public const string WriteStatusId = "Please Write status Id";
        public const string WriteStatusSharedDate = "Please write date";
        public const string StatusCreated = "following Statuses Posted";
        public const string FindStatusById = "Please write Status Id";
        public const string ListStatuses = "Following statuses exist in Database";
        public const string NoStatusInDatabase = "There is no status in Database";

        #region Error/Notice Messages Status
        public const string TitleEmpty = " Your can not create Status without title please try again";
        public const string ContentEmpty = "Your can not create Status without Content please try again";
        public const string SomethinWrong = "Something Went Wrong";
        public const string StatusNotCreated = "Something Went Wrong: Status Not Created";
        public const string FieldEmpty = "Youd cannot leave the filed blank: please tyr again";
        public const string UserRoleWrong = "Provided Role is Wrong: Please try again";
        public const string PasswordFaild = "the  --Password-- does not match with provided structure";
        public const string EmailFaild = "the  --Emailadress-- does not match with provided structure";
        public const string EntityNotFound = "Entities Not Found";
        #endregion

        #region Login Messages
        public const string WriteUserName = "Write ---Username--- ";
        public const string WriteUserPassword = " Write User ---Password---";
        public const string WriteUserId = "please write user Id";
        public const string AccessGranted = "Accedd granted-> You Logged in";
        public const string AccessDenied = "Access Denied -> Please check Username and Password";
        #endregion
      
        public const string PasswordStructure = 
            "Password should match to provided structure\n" +
            "At least 8 character\n" +
            "Start with Big Letter\n"+
            "At least one digit and symbol\n";
        public const string EmailStructure = "Email should should match to provided structure:\n" +
            "Example: kamran18@gmail.com\"";



        #region Register User
        public const string InputName = "Write user Name";
        public const string InputSurname = "Write user Surname";
        public const string InputAge = "Write user Age";
        public const string InputEmailAddress = "Write user Email";
        public const string InputUsername = "Write User username";
        public const string InputUserPassword = " Write user Password";
        public const string ListUserRoles = 
            "Following roles exist in Database You can Choose one\n"+
            "Admin:         1\n"+
            "User:          2\n"+
            "DataBaseAdmin: 3\n";
        public const string RoleNotice = "Choose the number of the respective role and press enter";
        public const string InputuserRole = "Write user Role";
        #endregion

    }
}
