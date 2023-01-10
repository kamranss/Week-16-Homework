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
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        
        public int? Id { get ; set ; }

        public void ShareStatus()
        {

        }
    }
}
