using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helper
{
    public class DefaultConsoleTemplates
    {
        public static void ConsoleTemplate(ConsoleColor coler1, string message)
        {
            
            Console.ForegroundColor = coler1;
            Console.WriteLine(message);
            Console.ResetColor();

        }

        public static void MenuOption()
        {
            string menuoption = Console.ReadLine();
            int selectedbutton;
            bool selection = int.TryParse(menuoption, out selectedbutton);
        }
    }
}
