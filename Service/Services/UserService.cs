using DataAccess;
using DataAccess.Repositories;
using Domain.Models;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository userRepository;
        public static int Id { get; set; } = 1;
        public UserService()
        {
            userRepository = new UserRepository();
        }
        public User Create(User user)
        {
            try
            {
                User findUser = userRepository.Get(u => u.Username.ToLower() == user.Username.ToLower() || u.EmailAddress == user.EmailAddress);
                if (findUser == null)
                {
                    if (user.Username != null && user.Password != null)
                    {
                        user.Id = Id;
                        if (userRepository.Create(user))
                        {
                            Id++;
                            AppDbContext.CountUsers++;
                            return user;
                        }
                    }
                    return null;
                }
                return null;
                

            }
            catch (Exception)
            {

                throw;
            }
        }

        public User Delete(int id)
        {
            try
            {
                User user = userRepository.Get(u => u.Id == id);
                if (user != null)
                {
                    userRepository.Delete(user);
                    AppDbContext.CountUsers--;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User Get(int id)
        {
            try
            {
                User user = userRepository.Get(u => u.Id == id);
                if (user != null)
                {
                    return user;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User Get(string username)
        {
            try
            {
                User user = userRepository.Get(u => u.Username == username);
                if (user!= null)
                {
                    return user;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<User> GetAll()
        {
            List<User> users = userRepository.GetAll();
            if (users!= null)
            {
                return users;
            }
            return null;
        }

        public List<User> GetAllByName(string name)
        {
            try
            {
                List<User> users = userRepository.GetAll(users => users.Name == name);
                if (users != null)
                {
                    return users;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User Update(User user, int id)
        {
            try
            {
                User founduser = userRepository.Get(u => u.Id == id);
                if (founduser != null)
                {
                    userRepository.Update(founduser);
                    return founduser;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
