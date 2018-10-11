using BankTransactionLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    AccountHolder acnt;
    int gvColumnCount = 0;
    List<BankTransaction> bankTransactionList;
    protected void Page_Load(object sender, EventArgs e)
    {
       

        if (Session["account"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        acnt = Session["account"] as AccountHolder;
        TransactionService transactionService = new TransactionService();
        bankTransactionList = transactionService.GetAllTransactionOfAcnt(acnt);
        gvPassbook.DataSource = bankTransactionList;
     
        gvPassbook.DataBind();


    }


    protected void btnDownloadPassbook_Click(object sender, EventArgs e)
    {
        Response.Clear();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", "attachment;filename=transaction_details.csv");
        Response.Charset = "";
        Response.ContentType = "application/text";
      

        StringBuilder columnbind = new StringBuilder();
       
        columnbind.Append("AcntNo" + ',' + "TransactionType" + ',' + "Amount" + ',' + "Date" + ',');
        columnbind.Append("\r\n");
        foreach (var data in bankTransactionList)
        {
            
            columnbind.Append(data.AcntNo+",");
            columnbind.Append(data.TransactionType + ",");
            columnbind.Append(data.TransactionAmount + ",");
            columnbind.Append(data.TransactionDate + ",");

            columnbind.Append("\r\n");
        }
    
        Response.Output.Write(columnbind.ToString());
        Response.Flush();
        Response.End();
       
    }
}