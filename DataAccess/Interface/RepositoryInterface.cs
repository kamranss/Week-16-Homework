using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface RepositoryInterface<T> where T:BaseInterface
    {
        void GetStatusByid(T entity);

        bool Create(T entity);
        bool Delete(T entity);
        bool Update(T entity);

        List<T> GetAll(Predicate<T> filter = null);


    }
}
