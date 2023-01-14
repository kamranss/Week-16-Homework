// See https://aka.ms/new-console-template for more information


using Domain.Models;
using PostApp.Controllers;
using System.Diagnostics;
using Utilities.Helper;
using Utilities.Helper.Enums;

LoginController loginController = new LoginController();
UserController userController = new UserController();
StatusController statusController = new StatusController();



LogInAgain: DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkRed, "In oder to access system you should provide credentials:");
User loggedInUser = loginController.LoginToSystem();

if (loggedInUser == null)
{

    DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkRed, "Credentials is wrong:");
    goto LogInAgain;
}

if (loggedInUser.Role == ConstantRoles.Admin)
{

    bool whileresult = true;
    while (whileresult)
    {

        DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkMagenta, ConsoleMessages.ChooseOption);
        DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.White, ConsoleMessages.OptionsForAdmin);
        string menuoption = Console.ReadLine();
        int selectedbutton;
        bool selection = int.TryParse(menuoption, out selectedbutton);

        switch (selectedbutton)
        {
            
            case (int)Enums.MenuOptions.CreateUser:
                userController.CreateUser();               
                break;
            case (int)Enums.MenuOptions.ShareStatus:
                statusController.CreateStatus(loggedInUser);
                break;
            case (int)Enums.MenuOptions.FindAllStatuses:
                statusController.FindAllStatuses();
                break;
            case (int)Enums.MenuOptions.FindAllUsers:
                userController.FindAllUsers();
                break;
            case (int)Enums.MenuOptions.FindStatusByDateandUserId:
                statusController.FindStatusByDateandUserId();
                break;
            case (int)Enums.MenuOptions.SerchStatusByid:
                statusController.GetStatusById();
                break;
            case (int)Enums.MenuOptions.LogOut:
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkRed, "You looged out:");
                goto LogInAgain;
            case (int)Enums.MenuOptions.DeleteStatus:
                statusController.DeleteStatus();
                break;
            case (int)Enums.MenuOptions.LogOut2:
                break;
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkRed, "You looged out:");
                break;
            case (int)Enums.MenuOptions.Exit:
                whileresult = false;
                break;


            default:
                break;
        }
    }

}
else if (loggedInUser.Role == ConstantRoles.User)
{
    
    bool whileresult = true;

    while (whileresult)
    {
        DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkMagenta, ConsoleMessages.ChooseOption);
        DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.White, ConsoleMessages.OptionsForUser);
        string menuoption = Console.ReadLine();
        int selectedbutton;
        bool selection = int.TryParse(menuoption, out selectedbutton);
        Console.WriteLine("You do not have access to Services");
        switch (selectedbutton)
        {
            case (int)Enums.MenuOptions2.ShareStatus:
                userController.CreateUser();
                break;
            case (int)Enums.MenuOptions2.Exit:
                whileresult = false;
                break;


            default:
                break;
        }
    }

}
//else if (loggedInUser.Role == ConstantRoles.User)
//{
//    DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkBlue, ConsoleMessages.ChooseOption);
//    DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.White, ConsoleMessages.OptionsForAdmin);
//    string menuoption = Console.ReadLine();
//    int selectedbutton;
//    bool selection = int.TryParse(menuoption, out selectedbutton);
//    bool whileresult = true;
//    while (true)
//    {
//        switch (selectedbutton)
//        {
//            case (int)Enums.MenuOptions.CreateStatus:
//                statusController.CreateStatus(loggedInUser);
//                break;
//            case (int)Enums.MenuOptions.FindAllStatuses:
//                statusController.FindAllStatuses();
//                break;
//            case (int)Enums.MenuOptions.Exit:
//                whileresult = false;
//                break;

//            default:
//                break;
//        }
//    }

//}
//else if (loggedInUser.Role == ConstantRoles.DataBaseAdmin)
//{

//}
//else
//{
//    Console.WriteLine(" You do not have access to any service ");
//}

