using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DataSetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
               
                string selectcmd = "SELECT * FROM Student";
                SqlCommand cmd = new SqlCommand(selectcmd,connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "Student");
                dataGridView1.DataSource =ds.Tables["Student"];

            }
            catch ( Exception exp)
            {

                MessageBox.Show("Connection not established..");
            }
            finally
            {
                if (connection.State==ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
