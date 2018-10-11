using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApiApp.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string No { get; set; }

        public Contact()
        {
            Id = Guid.NewGuid();
        }
    }
}