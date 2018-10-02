using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactCore
{
   public  class LoginRepository
    {
        private string _connectionString;
        private SqlConnection _connection;
        private SqlCommand _selectUserLoginCommand;
        private SqlDataAdapter _dataAdapter;
        private DataSet _ds;
        private string _selectUserLogin = "SELECT * FROM UserLogin";
        private string _username, _password;

        public LoginRepository()
        {
            InitializeDBConnection();
            GetUserIdPassword();
            
        }

        private void InitializeDBConnection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
            _connection = new SqlConnection(_connectionString);
            _selectUserLoginCommand = new SqlCommand(_selectUserLogin, _connection);

            _ds = new DataSet();
        }

        public string Username
        {
            get
            {
                return _username;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
        }

        public void GetUserIdPassword()
        {
            try
            {
                _dataAdapter = new SqlDataAdapter(_selectUserLoginCommand);
                _dataAdapter.Fill(_ds, "UserLogin");
                for (int i = 0; i < _ds.Tables[0].Rows.Count; i++)
                {
                    _username = Convert.ToString(_ds.Tables[0].Rows[i]["userid"]);
                    _password = Convert.ToString(_ds.Tables[0].Rows[i]["password"]);

                }
            }
            catch (Exception exp)
            {

                MessageBox.Show("Connection establishment problem.." + exp.Message);
            }
           
        }
    }
}
