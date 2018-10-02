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
    public partial class MenuParent : Form
    {
       public   static int  todoCount=0;
       public static int parentCount = 0;
     
       
        
        public MenuParent()
        {
            InitializeComponent();
        }

        private void TodoMenuItem_Click(object sender, EventArgs e)
        {
            if (parentCount == 0)
            {
                todoCount = 0;
            }
            parentCount++;
            todoCount++;
            TodoForm form = new TodoForm();
            form.MdiParent = this;
            form.Text = "TodoApp: " + todoCount;
            form.Show();
            this.Text = "MenuParent " + parentCount;
            
            
        }
    }
}
