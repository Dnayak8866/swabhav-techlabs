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
    public partial class ContactSearchForm : Form
    {
        bool isSearchBtnClicked = false;
        List<Contact> contactList = new List<Contact>();
      
        ContactServiceProvider serviceProvider;
        public ContactSearchForm(ContactServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (isSearchBtnClicked)
            {
                dataGridViewSearch.Rows.Clear();
            }
            isSearchBtnClicked = true;
            string inputName = txtSearchBox.Text;
            SearchContact(inputName);

        }
       

        public void SearchContact(string inputContact)
        {
            string inputName = inputContact;
            contactList = serviceProvider.NameList;
            foreach (Contact contact in contactList)
            {
                if (contact.Name.ToUpper().Contains(inputName.ToUpper()))
                {
                    dataGridViewSearch.Rows.Add(contact.Name, contact.Number);
                }
            }
        }
    }
}
