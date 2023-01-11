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
        bool Create(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        T Get(Predicate<T> filter = null);
        List<T> GetAll(Predicate<T> filter = null);
        
    }
}
