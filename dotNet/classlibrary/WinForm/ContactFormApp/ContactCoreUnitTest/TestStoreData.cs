using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactCore;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ContactCoreUnitTest
{
    [TestClass]
    public class TestStoreData
    {
        StoreData s1 = new StoreData();
        List<Contact> contactlist = new List<Contact>();
   
        [TestMethod]
      //  [ExpectedException(typeof (SerializationException))]
        public void TestSerializeTheList()
        {
            contactlist.Add(new Contact("testname","11111111"));
            s1.SerializeTheList(contactlist);
           
        }
        [TestMethod]
        public void TestGetData()
        {
            s1.GetData();
        }
    }
}
