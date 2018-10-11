using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankTransactionLib;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["account"] == null)
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        TransactionService transacService = new TransactionService();
        float transamt = Convert.ToSingle(txtAmt.Text);
        string transType = btnRadioTransactionType.SelectedValue;
        AccountHolder acnt = Session["account"] as AccountHolder;
        transacService.DoTransaction(acnt, transamt, transType);
        lblSuccess.Text = "Transaction successfull";
    }
}