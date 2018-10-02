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
using ContactCore;

namespace ContactFormAppWithDB
{
   
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginService loginservice = new LoginService();
           
            string inputUserName = txtUserName.Text;
            string inputPass = txtPassWord.Text;
            
           
            if(loginservice.AuthenticateUser(inputUserName,inputPass))
            {
               
                ToolStripMenuItem filemenuitems;
                Form parentform = this.MdiParent;
                MenuStrip ms = (MenuStrip)parentform.Controls["menuStrip2"];
                filemenuitems = (ToolStripMenuItem)ms.Items["fileToolStripMenuItem"];
                MessageBox.Show("login success...");
                foreach (ToolStripItem item in filemenuitems.DropDownItems)
                {
                    if (item.Name == "addToolStripMenuItem" || item.Name == "searchToolStripMenuItem" || item.Name == "displayToolStripMenuItem")
                    {
                        item.Enabled = true;
                    }

                }

                DialogResult dialogueResult = MessageBox.Show("Login Successfull.....");
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
