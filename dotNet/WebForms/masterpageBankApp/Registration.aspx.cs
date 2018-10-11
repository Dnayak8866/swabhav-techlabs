using BankTransactionLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        AccountHolder newAcntHolder;
        int acntno = Convert.ToInt32(txtAcntNo.Text);
        string name = Convert.ToString(txtName.Text);
        float balance = Convert.ToSingle(txtBalance.Text);
        string password = Convert.ToString(txtPassword.Text);

        newAcntHolder = new AccountHolder { AccntNo=acntno,AcntHolderName=name,Balance=balance};

        TransactionService transactionService = new TransactionService();
        if(transactionService.RegisterAccount(newAcntHolder, password))
        {
            lblRegisterSuccess.Text = "Successfully Registered......";
        }
    }
}