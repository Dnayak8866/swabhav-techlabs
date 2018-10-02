using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactCore;
using System.Collections.Generic;
using System.IO;

namespace ContactCoreUnitTest
{
    [TestClass]
    public class ContactServiceProviderTest
    {

        ContactServiceProvider serviceProvider = new ContactServiceProvider();
        List<Contact> namelist = new List<Contact>();

        [TestMethod]  
        public void TestAddContact()
        {
           
            serviceProvider.AddContact("testname","123132111");

        }

        [TestMethod]
        public void TestNameListProperty()
        {
            Assert.AreNotEqual(0,serviceProvider.NameList.Count);
        }

    }
}
