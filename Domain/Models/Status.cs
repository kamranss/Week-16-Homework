using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Status:BaseInterface
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SharedDate { get; set; }
        public TimeSpan TimePast { get; set; } = new TimeSpan (0, 0, 0);
        //public int UserId { get; set; }
        public User User { get; set; }
        public int? Id { get; set; }
        

        public void GetStatusInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Id - {Id} | Title - {Title} | Content - {SharedDate} | User_Name {User.Username} | User_Id - {User.Id} ");
            Console.ResetColor();
        }
    }
}
