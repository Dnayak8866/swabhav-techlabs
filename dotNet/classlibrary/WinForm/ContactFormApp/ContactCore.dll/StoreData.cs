using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore.dll
{
    public class StoreData
    {
        IFormatter formatter = new BinaryFormatter();
        public void SerializeTheList(List<Contact> contactList)
        {
            Console.WriteLine("Inside serializaedata()..");
            try
            {
                Stream stream = new FileStream("N:\\Localrepository\\dotNet\\csharp\\ContactApp\\ContactApp\\resources\\contactlist.txt", FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, contactList);
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occured :" + e);
            }


        }

        public List<Contact> GetData()
        {
            List<Contact> contactList = new List<Contact>();
            try
            {

                Stream stream = new FileStream("N:\\Localrepository\\dotNet\\csharp\\ContactApp\\ContactApp\\resources\\contactlist.txt", FileMode.Open, FileAccess.Read);
                contactList = (List<Contact>)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);

            }
            return contactList;


        }
    }
}
