using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApiApp.Specification
{
    public class ContactSearchCriteria
    {
        public string ContactName { get; set; }
        public Guid ContactId { get; set; }
    }
}