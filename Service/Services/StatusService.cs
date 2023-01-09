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
    public class StatusService : IStatusservice
    {
        private readonly StatusRepository statusRepository;
        private readonly UserRepository userRepository;

        public StatusService()
        {
            statusRepository = new StatusRepository();
            userRepository = new UserRepository();
        }
        public Status Create(Status status)
        {
            try
            {
                if (status.Title != null && status.Content != null && status.User !=null )
                {
                    statusRepository.Create(status);
                    return status;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Status Delete(int id)
        {
            try
            {
                Status status = statusRepository.Get(st => st.Id == id);
                if (status != null)
                {
                    statusRepository.Delete(status);
                    return status;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Status Get(int id)
        {
            try
            {
                Status status = statusRepository.Get(st => st.Id == id);
                if (status != null)
                {
                    return status;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Status Get(string title)
        {
            try
            {
                Status status = statusRepository.Get(st => st.Title == title);
                if (status != null)
                {
                    return status;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Status> GetAll()
        {
            try
            {
                List<Status> statuses = statusRepository.GetAll();
                if (statuses != null)
                {
                    return statuses;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Status> GetAllByTitle(string title)
        {
            try
            {
                List<Status> statuses = statusRepository.GetAll(st => st.Title == title);
                if (statuses != null)
                {
                    return statuses;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Status> GetSbySharedDate(DateTime dateTime)
        {
            try
            {
                List<Status> status = statusRepository.GetAll(st => st.SharedDate >= dateTime);
                if (status != null)
                {
                    return status;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Status> GetStatusesBySharedDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public Status Update(Status status)
        {
            throw new NotImplementedException();
        }
    }
}
