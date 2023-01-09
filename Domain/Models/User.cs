using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class User:BaseInterface
    {
        public string Username { get; set; }
        public int? id { get ; set ; }

        public void ShareStatus()
        {

        }
    }
}
