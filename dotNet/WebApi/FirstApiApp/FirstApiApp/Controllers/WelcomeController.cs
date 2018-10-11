using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FirstApiApp.Controllers
{
    public class WelcomeController:ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Get method invoked");
        }

        public IHttpActionResult Get(int id)
        {
            return Ok("Get method invoked through param id " + id);
        }

        public IHttpActionResult Post()
        {
            return Ok("Post invoked...");
        }

        public IHttpActionResult Put()
        {
            return Ok("Put method invoked...");
        }

        public IHttpActionResult Delete()
        {
            return Ok("Delete method invoked....");
        }
           
    }
}