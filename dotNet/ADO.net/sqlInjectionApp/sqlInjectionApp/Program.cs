using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace sqlInjectionApp
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
                string rollNo = Convert.ToString(Console.ReadLine());
                string selectsinglerecord = "SELECT * FROM Student WHERE rollNo="+rollNo;
                SqlCommand command = new SqlCommand(selectsinglerecord,connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Firstname : {0} | Lastname :{1} | CGPA :{2}",reader[1].ToString(),reader[2].ToString(),reader[3].ToString());
                }
                
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            finally
            {
                connection.Close();
            }
            
        }
    }
}
