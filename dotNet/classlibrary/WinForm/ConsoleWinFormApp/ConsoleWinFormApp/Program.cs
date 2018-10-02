using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleWinFormApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeForm welcomeform = new WelcomeForm();
            Application.Run(new WelcomeForm());
            
        }
    }
}
