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

namespace ContactFormAppWithDB
{
    public partial class MdiParentForm : Form
    {
        ContactServiceProvider serviceProvider;
        public MdiParentForm()
        {
            serviceProvider = new ContactServiceProvider();
            InitializeComponent();
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactAddForm addForm = new ContactAddForm(serviceProvider);
            addForm.MdiParent = this;
            addForm.WindowState = FormWindowState.Maximized;
            addForm.Show();

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactSearchForm searchForm = new ContactSearchForm(serviceProvider);
            searchForm.MdiParent = this;
            searchForm.WindowState = FormWindowState.Maximized;
            searchForm.Show();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactDisplayForm displayForm = new ContactDisplayForm(serviceProvider);
            displayForm.MdiParent = this;
            displayForm.showContacts();
            displayForm.WindowState = FormWindowState.Maximized;
            displayForm.Show();

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.MdiParent = this;
            loginform.WindowState = FormWindowState.Maximized;
            loginform.Show();
        }
    }
}
