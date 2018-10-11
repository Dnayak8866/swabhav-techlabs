using mvcBankApp.Models.RegistrationModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcBankApp.Models.TransactionModel
{
    public class TransactionVM
    {
        [Required(ErrorMessage ="please enter a amount....")]
        public double TransactionAmount { get; set; }

        [Required(ErrorMessage ="please select transaction type...")]
        public string SeletedTransactionType { get; set; }

    
        public  List<string > TransTypeList { get; set; }
        public int LoggedInAccountNo { get; set; }

        public TransactionVM()
        {
            TransTypeList = new List<string>();
            TransTypeList.Add("Deposit");
            TransTypeList.Add("Withdraw");
        }
    }
   
}