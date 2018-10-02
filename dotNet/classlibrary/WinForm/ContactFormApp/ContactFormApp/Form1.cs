using ContactCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactFormApp
{
    public partial class ContactForm : Form
    {
        ContactServiceProvider serviceProvider;
        public ContactForm()
        {
            serviceProvider = new ContactServiceProvider();
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ContactAddForm addForm = new ContactAddForm(serviceProvider);
            addForm.MdiParent = this;
            addForm.Show();
           
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactDisplayForm displayForm = new ContactDisplayForm(serviceProvider);
            displayForm.MdiParent = this;
            displayForm.showContacts();
            displayForm.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactSearchForm searchForm = new ContactSearchForm(serviceProvider);
            searchForm.MdiParent = this;
            searchForm.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.MdiParent = this;
            loginform.Show();
        }
        
    }
}
