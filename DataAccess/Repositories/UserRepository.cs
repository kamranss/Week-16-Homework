using DataAccess.Interface;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UserRepository : RepositoryInterface<User>
    {
        public bool Create(User entity)
        {
            try
            {
                AppDbContext.Users.Add(entity);
                return true;
                    
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(User entity)
        {
            AppDbContext.Users.Remove(entity);
            return true;
        }

        public User Get(Predicate<User> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll(Predicate<User> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
