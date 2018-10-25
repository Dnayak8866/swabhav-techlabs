using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeApi.Repository
{
    public interface IRepository<T>
    {

        List<T> GetAll();
        T GetByID(int entityId);
        List<T> GetByname(string entityName);
    }
}
