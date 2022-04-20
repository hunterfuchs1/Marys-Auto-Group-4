namespace Marys_Auto
{
    partial class Employees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Employee_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HourlyWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Experience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.AllowUserToDeleteRows = false;
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee_ID,
            this.EmployeeFirstName,
            this.EmployeeLastName,
            this.JobTitle,
            this.HourlyWage,
            this.Experience});
            this.EmployeeGridView.Location = new System.Drawing.Point(21, 9);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.RowHeadersWidth = 51;
            this.EmployeeGridView.RowTemplate.Height = 24;
            this.EmployeeGridView.Size = new System.Drawing.Size(716, 259);
            this.EmployeeGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 302);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(268, 330);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 22);
            this.textBox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Job Title";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(268, 358);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 22);
            this.textBox4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hourly Wage";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(268, 386);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(153, 22);
            this.textBox5.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Experience";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(268, 414);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(153, 22);
            this.textBox6.TabIndex = 2;
            // 
            // Employee_ID
            // 
            this.Employee_ID.DataPropertyName = "Employee_ID";
            this.Employee_ID.HeaderText = "Employee ID";
            this.Employee_ID.MinimumWidth = 6;
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.Width = 125;
            // 
            // EmployeeFirstName
            // 
            this.EmployeeFirstName.DataPropertyName = "EmployeeFirstName";
            this.EmployeeFirstName.HeaderText = "First Name";
            this.EmployeeFirstName.MinimumWidth = 6;
            this.EmployeeFirstName.Name = "EmployeeFirstName";
            this.EmployeeFirstName.Width = 125;
            // 
            // EmployeeLastName
            // 
            this.EmployeeLastName.DataPropertyName = "EmployeeLastName";
            this.EmployeeLastName.HeaderText = "Last Name";
            this.EmployeeLastName.MinimumWidth = 6;
            this.EmployeeLastName.Name = "EmployeeLastName";
            this.EmployeeLastName.Width = 125;
            // 
            // JobTitle
            // 
            this.JobTitle.DataPropertyName = "JobTitle";
            this.JobTitle.HeaderText = "Job Title";
            this.JobTitle.MinimumWidth = 6;
            this.JobTitle.Name = "JobTitle";
            this.JobTitle.Width = 125;
            // 
            // HourlyWage
            // 
            this.HourlyWage.DataPropertyName = "HourlyWage";
            this.HourlyWage.HeaderText = "Hourly Wage";
            this.HourlyWage.MinimumWidth = 6;
            this.HourlyWage.Name = "HourlyWage";
            this.HourlyWage.Width = 125;
            // 
            // Experience
            // 
            this.Experience.DataPropertyName = "Experience";
            this.Experience.HeaderText = "Experience";
            this.Experience.MinimumWidth = 6;
            this.Experience.Name = "Experience";
            this.Experience.Width = 125;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeGridView);
            this.Name = "Employees";
            this.Size = new System.Drawing.Size(752, 524);
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn HourlyWage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Experience;
    }
}
