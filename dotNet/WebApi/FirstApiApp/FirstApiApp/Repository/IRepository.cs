using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApiApp.Repository
{
   public  interface IRepository<T>
    {
        Guid Add(T entity);
        void Update(T entity);
        void Delete(Guid entityId);
        T GetById(Guid entityId);
       
        List<T> Search(ISpecification<T> specification);
        List<T> GetAll();
       
    }
}
