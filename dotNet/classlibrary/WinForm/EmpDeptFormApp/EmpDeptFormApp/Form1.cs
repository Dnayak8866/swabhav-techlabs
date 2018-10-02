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

namespace EmpDeptFormApp
{
    public partial class Form1 : Form
    {
        private string _connectionString;
        private SqlConnection _connection;
        private string _selectEmp = "SELECT * FROM EMP";
        private string _selectDept = "SELECT * FROM DEPT";
        private SqlCommand _selectEmpCommand;
        private SqlCommand _selectDeptCommand;
        private SqlDataAdapter _dataAdapter;
        private DataSet _ds;

        public Form1()
        {
            InitializeComponent();
            
            InitializeDBConnection();
            
        }

        private void InitializeDBConnection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
            _connection = new SqlConnection(_connectionString);

           _selectEmpCommand = new SqlCommand(_selectEmp, _connection);
            _selectDeptCommand = new SqlCommand(_selectDept, _connection);
            _ds = new DataSet();
        }

        private void btnEmpPopulate_Click(object sender, EventArgs e)
        {
            try
            {

                _dataAdapter = new SqlDataAdapter(_selectEmpCommand);
                _dataAdapter.Fill(_ds,"EMP");
                dataGridViewEmp.DataSource = _ds.Tables["EMP"];

                
            }
            catch (Exception exp)
            {
                MessageBox.Show("Connection establishment problem.."+exp.Message);
                
            }
          
        }

        private void btnPopulateDept_Click(object sender, EventArgs e)
        {
            try
            {
                _dataAdapter = new SqlDataAdapter(_selectDeptCommand);
                _dataAdapter.Fill(_ds,"DEPT");
                dataGridViewDept.DataSource = _ds.Tables["DEPT"];
            }
            catch (Exception exp )
            {

                MessageBox.Show("Connection  establishment problem"+exp);
            }
            
            
        }
    }
}
