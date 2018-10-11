using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FirstApiApp.Repository
{
   public interface ISpecification<T>
    {
        Expression<Func<T, bool>>  Search { get; }
    }
}
