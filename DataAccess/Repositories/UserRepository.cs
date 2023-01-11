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
            try
            {
                AppDbContext.Users.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User Get(Predicate<User> filter = null)
        {
            try
            {
                return filter != null ? AppDbContext.Users.Find(filter) : AppDbContext.Users[0];
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<User> GetAll(Predicate<User> filter = null)
        {
            try
            {
                return filter != null ? AppDbContext.Users.FindAll(filter) : AppDbContext.Users;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(User entity)
        {
            try
            {
                User founduser = Get(us => us.Id == entity.Id);
                if (founduser != null)
                {
                    founduser = entity;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
