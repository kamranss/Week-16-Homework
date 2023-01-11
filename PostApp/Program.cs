// See https://aka.ms/new-console-template for more information


using Domain.Models;
using PostApp.Controllers;
using System.Diagnostics;
using Utilities.Helper;
using Utilities.Helper.Enums;

LoginController loginController = new LoginController();
UserController userController = new UserController();
StatusController statusController = new StatusController();


bool whileresult = true;
DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkRed, "In oder to access system you should provide credentials:");
string role = loginController.LoginToSystem();
if (role != null)
{
    if (loginController.CheckUserkRole(role))
    {
        DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkBlue, ConsoleMessages.ChooseOption);
        DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.White, ConsoleMessages.OptionsForAdmin);
        string menuoption = Console.ReadLine();
        int selectedbutton;
        bool selection = int.TryParse(menuoption, out selectedbutton);
        while (whileresult)
        {
            switch (selectedbutton)
            {
                case (int)Enums.MenuOptionsForAdmin.CreateUser:
                    userController.CreateUser();
                    break;
                case (int)Enums.MenuOptionsForAdmin.Exit:
                    break;

                default:
                    break;
            }
        }

    }
}

