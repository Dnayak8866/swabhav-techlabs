using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transactionApp
{
    class TransactionService
    {
        string connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
        SqlConnection connection;
        SqlTransaction transaction;
        
        SqlCommand command;



        public TransactionService()
        {
            
        }

       

        public void MakeTransaction(Merchant merchant,int amount,int customerid)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Connection established to SQLSERVER...");
               

                command= connection.CreateCommand();
                transaction = connection.BeginTransaction("simpletransaction");

                command.Connection = connection;
                command.Transaction = transaction;
                Console.WriteLine("Its here...");

                try
                {
                   
                    //getting cutomer balance...and updating customerbalance
                    int customerBalance = 0; ;
                    int customerupdatedbalance;
                    command.CommandText = "Select balance FROM CUSTOMERS WHERE id=@param1";
                    command.Parameters.Add("@param1", SqlDbType.Int);
                    command.Parameters["@param1"].Value = customerid;

                    SqlDataReader cutomerbalanceReader = command.ExecuteReader();
                    
                    while (cutomerbalanceReader.Read())
                    {
                        customerBalance += Convert.ToInt32(cutomerbalanceReader[0]);
                        Console.WriteLine("balance " + customerBalance);
                       
                    }
                   
                    command.Dispose();
                  
                    cutomerbalanceReader.Close();
                  
                    cutomerbalanceReader.Dispose();
                  
                    customerupdatedbalance = customerBalance - amount;
                   
                    command = connection.CreateCommand();
                    command.Connection = connection;
                    command.Transaction = transaction;

                    command.CommandText = "UPDATE CUSTOMERS SET balance=" + customerupdatedbalance + "WHERE id= @custid";
                    command.Parameters.Add("@custid", SqlDbType.Int);
                    command.Parameters["@custid"].Value = customerid;
                 
                    command.ExecuteNonQuery();
                  
                    command.Dispose();
                    //getting merchant and updating balance..
                    int merchantBalance = 0; ;
                    int merchantupdatedbalance;
                    command = connection.CreateCommand();
                    command.Connection = connection;
                    command.Transaction = transaction;
                    command.CommandText = "Select balance FROM MERCHANTS WHERE id=@param2";
                    command.Parameters.Add("@param2", SqlDbType.Int);
                    command.Parameters["@param2"].Value = merchant.Id;

                    SqlDataReader merchantBalanceReader = command.ExecuteReader();

                    while (merchantBalanceReader.Read())
                    {
                        merchantBalance += Convert.ToInt32(merchantBalanceReader[0]);
                    }
                    command.Dispose();
                    merchantBalanceReader.Close();
                    merchantBalanceReader.Dispose();
                    merchantupdatedbalance = merchantBalance + amount;

                    command = connection.CreateCommand();
                    command.Connection = connection;
                    command.Transaction = transaction;
                    command.CommandText = "UPDATE MERCHANTS SET balance=" + merchantupdatedbalance+"WHERE id=@merchantid";
                    command.Parameters.Add("@merchantid", SqlDbType.Int);
                    command.Parameters["@merchantid"].Value = merchant.Id;
                    command.ExecuteNonQuery();
                    command.Dispose();
                    transaction.Commit();
                    Console.WriteLine("Both customer and merchant table updated......");

                }
                catch (Exception ex)
                {

                    Console.WriteLine("  Transaction errror.........: {0}", ex.Message);
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
               

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }
        }
    }
}
