using DataAccess;
using Domain.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;

namespace PostApp.Controllers
{
    public class StatusController
    {
        StatusService statusService;
        UserService UserService;
        public StatusController()
        {
            statusService = new StatusService();
            UserService = new UserService();
        }

        public void CreateStatus(User user)
        {
            WriteTitleAgain:DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.WriteStatustitle);
            string title = Console.ReadLine();
            
            if (string.IsNullOrEmpty(title)!)
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkRed, ConsoleMessages.TitleEmpty);
                goto WriteTitleAgain;
                
            }
            WriteContentAgain: DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.WriteStatusContent);
            string content = Console.ReadLine();
            if (string.IsNullOrEmpty(content)!)
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkRed, ConsoleMessages.ContentEmpty);
                goto WriteContentAgain;
            }

            Status status = new Status();
            status.Title = title;
            status.Content = content;
            status.User = user; /* The user comes as parameter from Log in method which called in Main Class*/
            Status newstatus = statusService.Create(status);            
            if (newstatus.Title == title)
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.StatusCreated);
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue,
                      $"Status Id - {newstatus.Id}  |" +
                      $"Status Title - {newstatus.Title}  |" +
                      $"Status Content - {newstatus.Content}  |" +
                      $"User Id - {newstatus.User.Id}  |" +
                      $"User username - {newstatus.User.Username}  |" +
                      $"SharedDate - {newstatus.SharedDate}  |" +
                      $"TimePast - {newstatus.TimePast}  |");

            }
            else
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.DarkRed, ConsoleMessages.StatusNotCreated);
            }
        }

        public void FindAllStatuses()
        {
            List<Status> statuses = new List<Status>();
            statuses = statusService.GetAll();
            if (AppDbContext.CountStatuses != 0)
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.ListStatuses);
                foreach (var item in statuses)
                {
                    DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.White,
                    $"Status Id - {item.Id} |" +
                    $"Status Title - {item.Title} |" +
                    $"Status Content - {item.Content} |" +
                    $"User Id - {item.User.Id} |" +
                    $"User username - {item.User.Username} |" +
                    $"SharedDate - {item.SharedDate} |" +
                    $"TimePast - {item.TimePast} |");

                    //DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.White,
                    //$"Status Id - {item.Id} |\n" );
                    //DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Yellow,
                    //$"Status Title - {item.Title} |\n" );
                    //DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Green,
                    //$"Status Content - {item.Content} |\n" );
                    //DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue,
                    //$"User Id - {item.User.Id} |\n" );
                    //DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.White,
                    //$"User username - {item.User.Username} |\n");
                    //DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red,
                    //$"SharedDate - {item.SharedDate} |\n" );
                    //DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Magenta,
                    //$"TimePast - {item.TimePast} |\n");
                }
            }
            else
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.NoStatusInDatabase);
            }
            
        }
        
    }
}
