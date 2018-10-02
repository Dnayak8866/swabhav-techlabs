using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace sqlInjectionPreventApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connection established to SQLSERVER...");
                Console.WriteLine("Enter a rollNo: ");
                string rollNo = Console.ReadLine();
                string selectsinglerecord = "SELECT * FROM Student WHERE rollNo=@param1";

                SqlCommand command = new SqlCommand(selectsinglerecord, connection);
                command.Parameters.Add("@param1",SqlDbType.VarChar,20);
          
                command.Parameters["@param1"].Value = rollNo;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("Firstname : {0} | Lastname :{1} | CGPA :{2}", reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                if(connection.State==ConnectionState.Open)
                {
                    connection.Close();
                }
               
            }
        }
    }
}
