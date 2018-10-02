using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContactCore;

public partial class ContactForm : System.Web.UI.Page
{
    ContactServiceProvider serviceProvider = new ContactServiceProvider();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        
        if ((txtName.Text!=string.Empty) && (txtNumber.Text!=string.Empty))
        {
            serviceProvider.AddContact(txtName.Text,txtNumber.Text);
        }
        
        
    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        List<Contact> contactList = new List<Contact>();
        contactList = serviceProvider.NameList;
        GridViewContacts.DataSource = contactList;
        GridViewContacts.DataBind();
    }
}