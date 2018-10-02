using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleWinFormApp
{
    class WelcomeForm:Form
    {
        public WelcomeForm()
        {
            this.Text = "Welcome Form";
            this.Height = 768;
            this.Width = 1024;

            Button redBtn = new Button();
            redBtn.Text = "Red";
            redBtn.Width = 150;
            redBtn.Height = 50;
            redBtn.Left = (this.ClientSize.Width - redBtn.Width) / 2;
            redBtn.Top = (this.ClientSize.Height - redBtn.Height) / 2;
            redBtn.FlatStyle = FlatStyle.Flat;
            redBtn.Click += new EventHandler(ChangeBackGround);
            this.Controls.Add(redBtn);

            Button blueBtn = new Button();
            blueBtn.Text = "Blue";
            blueBtn.Width = 150;
            blueBtn.Height = 50;
            blueBtn.Left = (this.ClientSize.Width -  blueBtn.Width) / 2;
            blueBtn.Top = (this.ClientSize.Height - (redBtn.Height + blueBtn.Height+100)) / 2;
            blueBtn.Click += new EventHandler(ChangeBackGround);
            blueBtn.FlatStyle = FlatStyle.Flat;
            this.Controls.Add(blueBtn);
          

        }
        public void ChangeBackGround(Object sender,System.EventArgs e)
        {
            string btnClickedText = (sender as Button).Text;
            if (btnClickedText.Equals("Red", StringComparison.CurrentCultureIgnoreCase))
            {
                this.BackColor = System.Drawing.Color.Red;
            }else
            {
                this.BackColor = System.Drawing.Color.Blue;
            }
                      
        }
    }
}
