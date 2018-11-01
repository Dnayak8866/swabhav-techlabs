using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenantManagementApi.Models.Tenant;

namespace TenantManagementApi.Repository
{
    public interface ITenantRepository<T>:IRepository<User>
    {

    }
}
