using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void CreateStatus()
        {

        }
        
    }
}
