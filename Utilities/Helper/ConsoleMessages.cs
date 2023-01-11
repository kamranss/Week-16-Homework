using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helper
{
    public class ConsoleMessages
    {
        public const string WriteStatustitle = "Please Write Status Title";
        public const string WriteStatusContent = "Please Write Status Content";

        #region Error Messages Status
        public const string TitleEmpty = " Your can not create Status without title please try again";
        public const string ContentEmpty = "Your can not create Status without Content please try again";
        #endregion

        #region Login Messages
        public const string AccessGranted = "Accedd granted-> You Logged in";
        public const string AccessDenied = "Access Denied -> Please check Username and Password";
        #endregion

       
    }
}
