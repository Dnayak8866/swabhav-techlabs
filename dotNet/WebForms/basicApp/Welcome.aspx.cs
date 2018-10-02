using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //lblDisplayTask.Text = lblDisplayTask.Text + " "+txtTask.Text;
       
        ListItem task = new ListItem();
        task.Text = txtTask.Text;
        lstTasks.Items.Add(task);


    }
}