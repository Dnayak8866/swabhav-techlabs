using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormTodoApp
{
    public partial class TodoForm : Form
    {

        public TodoForm()
        {
            InitializeComponent();

        }

       public void ButtonClickEventHandler(Object sender,System.EventArgs e)
        {
            if((sender as Button).Name == "btnAdd")
            {
                string task = Convert.ToString(txtTask.Text);
                lblDisplay.Visible = true;
                btnDelete.Visible = true;
                lstBoxTasks.Visible = true;
                lstBoxTasks.Items.Add(task);
                txtTask.Text = "";
            }
            else
            {
                if (lstBoxTasks.Items.Count <= 0)
                {
                    MessageBox.Show("Your all Tasks are done,add some new Task...");
                }
                lstBoxTasks.Items.Remove(lstBoxTasks.SelectedItem);
            }
           

        }

        private void TodoFormClosed_Event(object sender, FormClosedEventArgs e)
        {
            MenuParent.parentCount--;
            this.MdiParent.Text = "MenuParent " + MenuParent.parentCount;
        }
    }
}
