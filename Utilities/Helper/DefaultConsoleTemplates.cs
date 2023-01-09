using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helper
{
    public class DefaultConsoleTemplate
    {
        public static void ConsoleTemplate(ConsoleColor coler1, string message)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = coler1;
            Console.WriteLine(message);
            Console.ResetColor();

        }
    }
}
