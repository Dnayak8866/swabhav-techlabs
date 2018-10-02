using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Timestamp : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
        
    }

    public Color BorderColer
    {
        get
        {
            return lblTime.BorderColor;
        }
        set
        {
            lblTime.BorderColor = value;
        }
    }

    public Color BackgroundColor
    {
        get
        {
            return lblTime.BackColor;
        }
        set
        {
            lblTime.BackColor = value;
        }
    }
}