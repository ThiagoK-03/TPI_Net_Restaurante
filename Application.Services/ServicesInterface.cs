using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface CrudService<T>
    {
        IEnumerable<T> GetAll();
        T? Get(int id);
        T Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }

}
