using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore
{
    public class FileStore
    {
        IFormatter formatter = new BinaryFormatter();
        public void SerializeTheList(List<Contact> contactList)
        {
            Console.WriteLine("Inside serializaedata()..");
            
                Stream stream = new FileStream("resources\\contacts.txt", FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, contactList);
                stream.Close();
        }

        public List<Contact> GetData()
        {
            Stream stream=null;
            List<Contact> contactList = new List<Contact>();
            try
            {

                stream = new FileStream("resources\\contacts.txt", FileMode.Open, FileAccess.Read);
                contactList = (List<Contact>)formatter.Deserialize(stream);
                Console.WriteLine("asadada");
                
            }
            catch (FileNotFoundException e)
            {
               
                stream = new FileStream("resources\\contacts.txt", FileMode.Create);
              //  Console.WriteLine(e);
            }
            finally
            {
                stream.Close();
                
            }
          
            return contactList;

        }
    }
}
