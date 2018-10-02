using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

using System.Windows.Forms;

namespace ContactCore
{
    public class DatabaseStore
    {
        private string _connectionString;
        private SqlConnection _connection;
        private string _selectContacts = "SELECT * FROM Contacts";
        
        private string _insertContacts = "INSERT INTO Contacts(name,number)VALUES(@param1,@param2)";
        private SqlCommand _selectContactsCommand;
       
        private SqlCommand _insertContactCommand;
        private SqlDataAdapter _dataAdapter;
        private DataSet _ds;
        private List<Contact> contactLists;
        
        public DatabaseStore()
        {
            contactLists = new List<Contact>();
            InitializeDBConnection();
        }

        private void InitializeDBConnection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
            _connection = new SqlConnection(_connectionString);

            _selectContactsCommand = new SqlCommand(_selectContacts, _connection);
           

            _insertContactCommand = new SqlCommand(_insertContacts,_connection);
            _insertContactCommand.Parameters.Add("@param1", SqlDbType.VarChar, 20);
            _insertContactCommand.Parameters.Add("@param2", SqlDbType.VarChar, 20);

            _ds = new DataSet();
        }

        public  void storeContactToDatabase(Contact contact)
        {
            string name = contact.Name;
            string number = contact.Number;
            
             _connection.Open();
           
            _insertContactCommand.Parameters["@param1"].Value = name;
            _insertContactCommand.Parameters["@param2"].Value = number;
            _insertContactCommand.ExecuteReader();
           _connection.Close();
            
           
        }

        public List<Contact> getAllContactsFromDatabase()
        {
            try
            {
                _dataAdapter = new SqlDataAdapter(_selectContactsCommand);
                _dataAdapter.Fill(_ds, "Contacts");
                for (int i=0;i<_ds.Tables[0].Rows.Count;i++)
                {
                    string name = Convert.ToString(_ds.Tables[0].Rows[i]["name"]);
                    string number = Convert.ToString(_ds.Tables[0].Rows[i]["number"]);
                    contactLists.Add(new Contact(name,number));
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Connection establishment problem.." + exp.Message);
            }
            return contactLists;
        }


    }
}
