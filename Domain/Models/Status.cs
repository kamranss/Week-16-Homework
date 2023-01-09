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


       public void GetStatusInfo()
        {

        }
    }
}
