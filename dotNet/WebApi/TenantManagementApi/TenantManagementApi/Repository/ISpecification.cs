using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TenantManagementApi.Repository
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> SearchExpression { get; }
    }
}
