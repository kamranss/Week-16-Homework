using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IUserService
    {
        User Create(User user);
        User Update(User user, int id);
        User Delete(int id);
        User Get(int id);
        User Get(string username);
        List<User> GetAll();
        List<User> GetAllByName(string name);
    }
}
