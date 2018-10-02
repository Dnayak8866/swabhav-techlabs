using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactCore;

namespace ContactFormApp
{
    public partial class ContactAddForm : Form
    {
        ContactServiceProvider serviceProvider;
        public ContactAddForm(ContactServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string num = txtNumber.Text;
            if (name!="" && num!="")
            {
                serviceProvider.AddContact(name, num);
                MessageBox.Show("Contact successfully added.....");
                this.txtName.Text = "";
                this.txtNumber.Text = "";
            }
           
        }
    }
}
