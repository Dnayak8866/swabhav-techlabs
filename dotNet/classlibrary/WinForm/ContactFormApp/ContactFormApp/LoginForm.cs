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
namespace ContactFormApp
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        
            string inputUserName = txtUserName.Text;
            string inputPass = txtPassWord.Text;

            string userid=ConfigurationManager.AppSettings["userid"];
            string password = ConfigurationManager.AppSettings["password"];
            if(inputUserName.Equals(userid) && inputPass.Equals(password))
            {
                ToolStripMenuItem filemenuitems;
                Form parentform = this.MdiParent;
                MenuStrip ms = (MenuStrip)parentform.Controls["menuStrip1"];
                filemenuitems = (ToolStripMenuItem)ms.Items["fileToolStripMenuItem"];

                foreach (ToolStripItem item in filemenuitems.DropDownItems)
                {
                    if (item.Name == "addToolStripMenuItem" || item.Name == "searchToolStripMenuItem" || item.Name == "displayToolStripMenuItem")
                    {
                        item.Enabled = true;
                    }

                }
                DialogResult dialogueResult= MessageBox.Show("Login Successfull.....");
                if (dialogueResult==DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter correct credentials....");
            }

        }
    }
}
