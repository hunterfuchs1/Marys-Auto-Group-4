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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvEmployee = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourlyWageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDataSet = new Marys_Auto.EmployeesDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEFname = new System.Windows.Forms.TextBox();
            this.btnEcancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtELname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEtitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEwage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEexperience = new System.Windows.Forms.TextBox();
            this.btnEupdate = new System.Windows.Forms.Button();
            this.employeesTableAdapter = new Marys_Auto.EmployeesDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvEmployee
            // 
            this.dtgvEmployee.AutoGenerateColumns = false;
            this.dtgvEmployee.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dtgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.employeeFirstNameDataGridViewTextBoxColumn,
            this.employeeLastNameDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn,
            this.hourlyWageDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn});
            this.dtgvEmployee.DataSource = this.employeesBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvEmployee.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvEmployee.Location = new System.Drawing.Point(0, 0);
            this.dtgvEmployee.Name = "dtgvEmployee";
            this.dtgvEmployee.RowHeadersWidth = 51;
            this.dtgvEmployee.RowTemplate.Height = 24;
            this.dtgvEmployee.Size = new System.Drawing.Size(707, 306);
            this.dtgvEmployee.TabIndex = 0;
            this.dtgvEmployee.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgvEmployee_DataError);
            this.dtgvEmployee.DoubleClick += new System.EventHandler(this.dtgvEmployee_DoubleClick);
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "Employee_ID";
            this.EmployeeID.HeaderText = "Employee_ID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Visible = false;
            this.EmployeeID.Width = 125;
            // 
            // employeeFirstNameDataGridViewTextBoxColumn
            // 
            this.employeeFirstNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeFirstName";
            this.employeeFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.employeeFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeFirstNameDataGridViewTextBoxColumn.Name = "employeeFirstNameDataGridViewTextBoxColumn";
            this.employeeFirstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeLastNameDataGridViewTextBoxColumn
            // 
            this.employeeLastNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeLastName";
            this.employeeLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.employeeLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeLastNameDataGridViewTextBoxColumn.Name = "employeeLastNameDataGridViewTextBoxColumn";
            this.employeeLastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.HeaderText = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            this.jobTitleDataGridViewTextBoxColumn.Width = 125;
            // 
            // hourlyWageDataGridViewTextBoxColumn
            // 
            this.hourlyWageDataGridViewTextBoxColumn.DataPropertyName = "HourlyWage";
            this.hourlyWageDataGridViewTextBoxColumn.HeaderText = "Hourly Wage";
            this.hourlyWageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hourlyWageDataGridViewTextBoxColumn.Name = "hourlyWageDataGridViewTextBoxColumn";
            this.hourlyWageDataGridViewTextBoxColumn.Width = 125;
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            this.experienceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            this.experienceDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employeesDataSet;
            // 
            // employeesDataSet
            // 
            this.employeesDataSet.DataSetName = "EmployeesDataSet";
            this.employeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // txtEFname
            // 
            this.txtEFname.Location = new System.Drawing.Point(191, 329);
            this.txtEFname.Name = "txtEFname";
            this.txtEFname.Size = new System.Drawing.Size(180, 22);
            this.txtEFname.TabIndex = 2;
            // 
            // btnEcancel
            // 
            this.btnEcancel.BackColor = System.Drawing.Color.Violet;
            this.btnEcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEcancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEcancel.Location = new System.Drawing.Point(477, 450);
            this.btnEcancel.Name = "btnEcancel";
            this.btnEcancel.Size = new System.Drawing.Size(122, 51);
            this.btnEcancel.TabIndex = 3;
            this.btnEcancel.Text = "CANCEL";
            this.btnEcancel.UseVisualStyleBackColor = false;
            this.btnEcancel.Click += new System.EventHandler(this.btnEcancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // txtELname
            // 
            this.txtELname.Location = new System.Drawing.Point(191, 367);
            this.txtELname.Name = "txtELname";
            this.txtELname.Size = new System.Drawing.Size(180, 22);
            this.txtELname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Job Title";
            // 
            // txtEtitle
            // 
            this.txtEtitle.Location = new System.Drawing.Point(191, 407);
            this.txtEtitle.Name = "txtEtitle";
            this.txtEtitle.Size = new System.Drawing.Size(180, 22);
            this.txtEtitle.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hourly Wage";
            // 
            // txtEwage
            // 
            this.txtEwage.Location = new System.Drawing.Point(191, 447);
            this.txtEwage.Name = "txtEwage";
            this.txtEwage.Size = new System.Drawing.Size(180, 22);
            this.txtEwage.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Experience";
            // 
            // txtEexperience
            // 
            this.txtEexperience.Location = new System.Drawing.Point(191, 491);
            this.txtEexperience.Name = "txtEexperience";
            this.txtEexperience.Size = new System.Drawing.Size(180, 22);
            this.txtEexperience.TabIndex = 2;
            // 
            // btnEupdate
            // 
            this.btnEupdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEupdate.ForeColor = System.Drawing.Color.White;
            this.btnEupdate.Location = new System.Drawing.Point(477, 378);
            this.btnEupdate.Name = "btnEupdate";
            this.btnEupdate.Size = new System.Drawing.Size(122, 51);
            this.btnEupdate.TabIndex = 3;
            this.btnEupdate.Text = "UPDATE";
            this.btnEupdate.UseVisualStyleBackColor = false;
            this.btnEupdate.Click += new System.EventHandler(this.btnEupdate_Click);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.btnEupdate);
            this.Controls.Add(this.btnEcancel);
            this.Controls.Add(this.txtEexperience);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEwage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEtitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtELname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEFname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvEmployee);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Employees";
            this.Size = new System.Drawing.Size(707, 537);
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvEmployee;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeesDataSet employeesDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEFname;
        private System.Windows.Forms.Button btnEcancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtELname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEtitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEwage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEexperience;
        private System.Windows.Forms.Button btnEupdate;
        private EmployeesDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourlyWageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
    }
}
