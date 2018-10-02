using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace simpleConnectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // string connectionString = @"server=DESKTOP-LJORPG0\SQLEXPRESS;database=hitech;user id=sa;password=pass@123";
            string connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
               
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    Console.WriteLine("connection is opened....");
                    connection.Close();
                }
            }
            
        }
    }
}
