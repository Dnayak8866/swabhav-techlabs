using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore
{
   public class LoginService
    {
        public bool AuthenticateUser(string name,string pass)
        {
            LoginRepository loginrepo = new LoginRepository();
            if (name==loginrepo.Username && pass==loginrepo.Password)
            {
                return true;
            }
            return false;
        }
    }
}
