using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppDbContext
    {
        public static List<Status> Statuses { get; set; }
        public AppDbContext()
        {
            Statuses = new List<Status>();
        }
    }
}
