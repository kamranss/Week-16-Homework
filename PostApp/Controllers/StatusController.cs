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
                      $"TimePast - {newstatus.TimePast.TotalSeconds}  |");

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
                    $"TimePast - {((int)item.TimePast.TotalSeconds)} |");
                }
            }
            else
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.NoStatusInDatabase);
            }
            
        }
        public void DeleteStatus()
        {
            WriteStatusAgain: DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.WriteStatusId);
            string stringid = Console.ReadLine();
            int statusId;
            

            if (string.IsNullOrEmpty(stringid))
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, "You cannot leave filed blank");
                goto WriteStatusAgain;
            }

            bool convertedId = int.TryParse(stringid, out statusId);
            if (!convertedId)
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, "Something Went Wrong -> You should use digits");
                goto WriteStatusAgain;
            }

            Status foundStatus = statusService.Delete(statusId);
            if (foundStatus != null)
            {
                  DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.White,
                    $"following Status Deleted\n" +
                    $"Status Id - {foundStatus.Id} |" +
                    $"Status Title - {foundStatus.Title} |" +
                    $"Status Content - {foundStatus.Content} |" +
                    $"User Id - {foundStatus.User.Id} |" +
                    $"User username - {foundStatus.User.Username} |" +
                    $"SharedDate - {foundStatus.SharedDate} |" +
                    $"TimePast - {foundStatus.TimePast.TotalSeconds} |");               
            }
            else
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, "Status Not Found" );
            }
        }
        public void GetStatusById()
        {
            WriteStatusIdAgain: DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.WriteStatusId);
            string stringid = Console.ReadLine();
            int statusId;


            if (string.IsNullOrEmpty(stringid))
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, "You cannot leave filed blank");
                goto WriteStatusIdAgain;
            }

            bool convertedId = int.TryParse(stringid, out statusId);
            if (!convertedId)
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, "Something Went Wrong -> You should use digits");
                goto WriteStatusIdAgain;
            }

            Status foundStatus = statusService.Get(statusId);
            if (foundStatus != null)
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.White,
                  $"following Status Deleted\n" +
                  $"Status Id - {foundStatus.Id} |" +
                  $"Status Title - {foundStatus.Title} |" +
                  $"Status Content - {foundStatus.Content} |" +
                  $"User Id - {foundStatus.User.Id} |" +
                  $"User username - {foundStatus.User.Username} |" +
                  $"SharedDate - {foundStatus.SharedDate} |" +
                  $"Shared - {((int)foundStatus.TimePast.TotalSeconds)} - Seconds Ago |");
            }
            else
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, "Status Not Found");
            }
        }
        /// <summary>
        ///   FindStatusByDateandUserId should be modified
        /// </summary>
        public void FindStatusByDateandUserId()
        {
            WriteStatusIdAgain: DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.WriteUserId);
            string stringid = Console.ReadLine();
            int userId;


            if (string.IsNullOrEmpty(stringid))
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, "You cannot leave filed blank");
                goto WriteStatusIdAgain;
            }

            bool convertedId = int.TryParse(stringid, out userId);
            if (!convertedId)
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, "Something Went Wrong -> You should use digits");
                goto WriteStatusIdAgain;
            }

            WriteDateAgain: DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.WriteStatusSharedDate);
            DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, 
                "Please make sure that provided date is following given structure\n:" +
                "02/02/2002");
            
            string stringDate = Console.ReadLine();
            DateTime convertedDate = Convert.ToDateTime(stringDate);
            if (convertedDate == null)
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, "Given Date is not matching with provided structure");
                goto WriteDateAgain; 
            }



            List<Status> foundStatuses = statusService.GetStatusesBySharedDateandUserid(userId, convertedDate);
            if (foundStatuses != null)
            {
                foreach (var item in foundStatuses)
                {
                  DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.White,
                  $"following Status Deleted\n" +
                  $"Status Id - {item.Id} |" +
                  $"Status Title - {item.Title} |" +
                  $"Status Content - {item.Content} |" +
                  $"User Id - {item.User.Id} |" +
                  $"User username - {item.User.Username} |" +
                  $"SharedDate - {item.SharedDate} |" +
                  $"TimePast - {((int)item.TimePast.TotalSeconds)} |");
                }
            }
            else
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, "According to given Date or Id no statuses found");
            }
        }
        public void FilterStatusesbyDate()
        {
        WriteDateAgain: DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue, ConsoleMessages.WriteStatusSharedDate);
            DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Blue,
                "Please make sure that provided date is following given structure\n:" +
                "02/02/2002");

            string stringDate = Console.ReadLine();
            DateTime convertedDate = Convert.ToDateTime(stringDate);
            if (convertedDate == null)
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, "Given Date is not matching with provided structure");
                goto WriteDateAgain;
            }



            List<Status> foundStatuses = statusService.GetStatusesBySharedDate(convertedDate);
            if (foundStatuses != null)
            {
                foreach (var item in foundStatuses)
                {
                    DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.White,
                    $"following Status Deleted\n" +
                    $"Status Id - {item.Id} |" +
                    $"Status Title - {item.Title} |" +
                    $"Status Content - {item.Content} |" +
                    $"User Id - {item.User.Id} |" +
                    $"User username - {item.User.Username} |" +
                    $"SharedDate - {item.SharedDate} |" +
                    $"TimePast - {((int)item.TimePast.TotalSeconds)} |");
                }
            }
            else
            {
                DefaultConsoleTemplates.ConsoleTemplate(ConsoleColor.Red, "According to given Date or Id no statuses found");
            }
        }
        
    }
}
