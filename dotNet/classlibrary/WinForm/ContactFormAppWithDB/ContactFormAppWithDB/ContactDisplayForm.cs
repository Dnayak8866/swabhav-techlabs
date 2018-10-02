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
    public partial class ContactDisplayForm : Form
    {
        List<Contact> nameList = new List<Contact>();
        ContactServiceProvider serviceProvider;
        public ContactDisplayForm(ContactServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            InitializeComponent();
        }
        public void showContacts()
        {
            nameList=serviceProvider.NameList;
            foreach (Contact contact in nameList)
            {
    
                dataGridView1.Rows.Add(contact.Name,contact.Number);
            }
        }
    }
}
