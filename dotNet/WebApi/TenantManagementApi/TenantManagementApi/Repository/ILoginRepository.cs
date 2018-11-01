using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenantManagementApi.Models.Login;

namespace TenantManagementApi.Repository
{
    interface ILoginRepository<T>:IRepository<LoginDetail>
    {
         bool AuthenticateUSer(string username,string password);
         LoginDetail GetByUserName(string username);
    }
}
