using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestTimestamp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Timestamp1.BackgroundColor = System.Drawing.Color.Gold;
        Timestamp2.BackgroundColor = System.Drawing.Color.Aqua;
        Timestamp3.BackgroundColor = System.Drawing.Color.Gray;
    }
}