namespace EmpDeptFormApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEmpPopulate = new System.Windows.Forms.Button();
            this.btnPopulateDept = new System.Windows.Forms.Button();
            this.dataGridViewEmp = new System.Windows.Forms.DataGridView();
            this.dataGridViewDept = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDept)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpPopulate
            // 
            this.btnEmpPopulate.Location = new System.Drawing.Point(91, 28);
            this.btnEmpPopulate.Name = "btnEmpPopulate";
            this.btnEmpPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnEmpPopulate.TabIndex = 0;
            this.btnEmpPopulate.Text = "btnEmpPopulate";
            this.btnEmpPopulate.UseVisualStyleBackColor = true;
            this.btnEmpPopulate.Click += new System.EventHandler(this.btnEmpPopulate_Click);
            // 
            // btnPopulateDept
            // 
            this.btnPopulateDept.Location = new System.Drawing.Point(457, 28);
            this.btnPopulateDept.Name = "btnPopulateDept";
            this.btnPopulateDept.Size = new System.Drawing.Size(75, 23);
            this.btnPopulateDept.TabIndex = 1;
            this.btnPopulateDept.Text = "btnDeptPopulate";
            this.btnPopulateDept.UseVisualStyleBackColor = true;
            this.btnPopulateDept.Click += new System.EventHandler(this.btnPopulateDept_Click);
            // 
            // dataGridViewEmp
            // 
            this.dataGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmp.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewEmp.Name = "dataGridViewEmp";
            this.dataGridViewEmp.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewEmp.TabIndex = 2;
            // 
            // dataGridViewDept
            // 
            this.dataGridViewDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDept.Location = new System.Drawing.Point(383, 57);
            this.dataGridViewDept.Name = "dataGridViewDept";
            this.dataGridViewDept.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewDept.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 349);
            this.Controls.Add(this.dataGridViewDept);
            this.Controls.Add(this.dataGridViewEmp);
            this.Controls.Add(this.btnPopulateDept);
            this.Controls.Add(this.btnEmpPopulate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpPopulate;
        private System.Windows.Forms.Button btnPopulateDept;
        private System.Windows.Forms.DataGridView dataGridViewEmp;
        private System.Windows.Forms.DataGridView dataGridViewDept;
    }
}

