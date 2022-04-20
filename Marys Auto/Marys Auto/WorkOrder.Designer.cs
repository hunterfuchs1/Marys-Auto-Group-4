namespace Marys_Auto
{
    partial class WorkOrder
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
            this.workOrdergridView = new System.Windows.Forms.DataGridView();
            this.actualPriceBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.estimatedPriceBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Invoice_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.workOrdergridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // workOrdergridView
            // 
            this.workOrdergridView.AllowUserToDeleteRows = false;
            this.workOrdergridView.AutoGenerateColumns = false;
            this.workOrdergridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workOrdergridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Invoice_ID,
            this.Date,
            this.Vehicle_ID,
            this.Employee_ID,
            this.EstimatePrice,
            this.FinalPrice,
            this.invoiceIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.vehicleIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.estimatePriceDataGridViewTextBoxColumn,
            this.finalPriceDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.vehicleDataGridViewTextBoxColumn});
            this.workOrdergridView.DataSource = this.invoiceBindingSource;
            this.workOrdergridView.Location = new System.Drawing.Point(3, 3);
            this.workOrdergridView.Name = "workOrdergridView";
            this.workOrdergridView.Size = new System.Drawing.Size(558, 322);
            this.workOrdergridView.TabIndex = 0;
            this.workOrdergridView.DoubleClick += new System.EventHandler(this.workOrdergridView_DoubleClick);
            // 
            // actualPriceBox
            // 
            this.actualPriceBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.actualPriceBox.Location = new System.Drawing.Point(394, 359);
            this.actualPriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.actualPriceBox.Name = "actualPriceBox";
            this.actualPriceBox.Size = new System.Drawing.Size(64, 20);
            this.actualPriceBox.TabIndex = 32;
            this.actualPriceBox.Text = "$0.00";
            this.actualPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 362);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Actual Price";
            // 
            // estimatedPriceBox
            // 
            this.estimatedPriceBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.estimatedPriceBox.Location = new System.Drawing.Point(150, 356);
            this.estimatedPriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.estimatedPriceBox.Name = "estimatedPriceBox";
            this.estimatedPriceBox.Size = new System.Drawing.Size(64, 20);
            this.estimatedPriceBox.TabIndex = 31;
            this.estimatedPriceBox.Text = "$0.00";
            this.estimatedPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(56, 359);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Estimated Price";
            // 
            // Invoice_ID
            // 
            this.Invoice_ID.DataPropertyName = "Invoice_ID";
            this.Invoice_ID.HeaderText = "Invoice ID";
            this.Invoice_ID.Name = "Invoice_ID";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Vehicle_ID
            // 
            this.Vehicle_ID.DataPropertyName = "Vehicle_ID";
            this.Vehicle_ID.HeaderText = "Vehicle ID";
            this.Vehicle_ID.Name = "Vehicle_ID";
            // 
            // Employee_ID
            // 
            this.Employee_ID.DataPropertyName = "Employee_ID";
            this.Employee_ID.HeaderText = "Employee ID";
            this.Employee_ID.Name = "Employee_ID";
            // 
            // EstimatePrice
            // 
            this.EstimatePrice.DataPropertyName = "EstimatePrice";
            this.EstimatePrice.HeaderText = "Estimate Price";
            this.EstimatePrice.Name = "EstimatePrice";
            // 
            // FinalPrice
            // 
            this.FinalPrice.DataPropertyName = "FinalPrice";
            this.FinalPrice.HeaderText = "Final Price";
            this.FinalPrice.Name = "FinalPrice";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(227, 395);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(177, 23);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "Invoice_ID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "Invoice_ID";
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // estimatePriceDataGridViewTextBoxColumn
            // 
            this.estimatePriceDataGridViewTextBoxColumn.DataPropertyName = "EstimatePrice";
            this.estimatePriceDataGridViewTextBoxColumn.HeaderText = "EstimatePrice";
            this.estimatePriceDataGridViewTextBoxColumn.Name = "estimatePriceDataGridViewTextBoxColumn";
            // 
            // finalPriceDataGridViewTextBoxColumn
            // 
            this.finalPriceDataGridViewTextBoxColumn.DataPropertyName = "FinalPrice";
            this.finalPriceDataGridViewTextBoxColumn.HeaderText = "FinalPrice";
            this.finalPriceDataGridViewTextBoxColumn.Name = "finalPriceDataGridViewTextBoxColumn";
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.Visible = false;
            // 
            // vehicleDataGridViewTextBoxColumn
            // 
            this.vehicleDataGridViewTextBoxColumn.DataPropertyName = "Vehicle";
            this.vehicleDataGridViewTextBoxColumn.HeaderText = "Vehicle";
            this.vehicleDataGridViewTextBoxColumn.Name = "vehicleDataGridViewTextBoxColumn";
            this.vehicleDataGridViewTextBoxColumn.Visible = false;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(Marys_Auto.Models.Invoice);
            // 
            // WorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.actualPriceBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.estimatedPriceBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.workOrdergridView);
            this.Name = "WorkOrder";
            this.Size = new System.Drawing.Size(564, 426);
            this.Load += new System.EventHandler(this.WorkOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workOrdergridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView workOrdergridView;
        private System.Windows.Forms.TextBox actualPriceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox estimatedPriceBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdate;
    }
}
