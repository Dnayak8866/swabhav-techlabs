using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace commandApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string selectString = "SELECT * FROM Student";
                SqlCommand command = new SqlCommand(selectString,connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Roll NO :{0} | FistName :{1} | LastName :{2} | CGPA :{3}", reader[0].ToString(), reader[1].ToString(),reader[2].ToString(),reader[3].ToString());
                  
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
            finally
            {
                if (connection.State==ConnectionState.Open)
                {
                    // Console.BackgroundColor = ConsoleColor.DarkBlue;
                   

                }
            }
        }
    }
}
