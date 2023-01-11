using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IStatusservice
    {
        Status Create(Status status);
        Status Update(Status status, int id);
        Status Delete(int id);
        Status Get(int id);
        Status Get(string title);
        List<Status> GetAll();
        List<Status> GetAllByTitle(string title);
        List<Status> GetStatusesBySharedDate(DateTime dateTime);
        List<Status> GetStatusesByUserId(int id);
        
    }
}
