using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helper
{
    public class ConsoleMessages
    {
        public const string Options = 
       "Please choose one of the option from Menu bar:\n" +
       "1 - Create Department:\n" +
       "2 - UpdateDepartment:\n" +
       "3 - DeleteDepartment:\n" +
       "4 - GetDepartmentbyId:\n" +
       "5 - GetDepartmentbyName:\n" +
       "6 - GetDepartmentbyCapacity:\n" +
       "7 - GetAllDepartment:\n" +
       "8 - CreateEmployee:\n" +
       "9 - GetAllEmployeesList:\n" +
       "10 - UpdateEmployee:\n" +
       "11 - CountAllEmployee:\n" +
       "12 - GetEmployeeById:\n" +
       "13 - ExitProgram:";


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

       
    }
}
