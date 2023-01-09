using DataAccess.Interface;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class StatusRepository : RepositoryInterface<Status>
    {
        public bool Create(Status entity)
        {
            try
            {
                AppDbContext.Statuses.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Status entity)
        {
            try
            {
                AppDbContext.Statuses.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Status Get(Predicate<Status> filter = null)
        {
            try
            {
                return filter != null ? AppDbContext.Statuses.Find(filter) : AppDbContext.Statuses[0];
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Status> GetAll(Predicate<Status> filter = null)
        {
            try
            {
                return filter != null ? AppDbContext.Statuses.FindAll(filter) : AppDbContext.Statuses;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Status entity)
        {
            try
            {
                Status foundStatus = Get(sts => sts.id == entity.id);
                if (foundStatus != null)
                {
                    foundStatus = entity;
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
