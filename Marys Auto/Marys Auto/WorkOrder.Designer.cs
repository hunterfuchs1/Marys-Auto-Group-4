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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.actualPriceBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnWOdelete = new System.Windows.Forms.Button();
            this.btnWorkupdate = new System.Windows.Forms.Button();
            this.btnWOcancel = new System.Windows.Forms.Button();
            this.invoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // actualPriceBox
            // 
            this.actualPriceBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.actualPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualPriceBox.Location = new System.Drawing.Point(333, 408);
            this.actualPriceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actualPriceBox.Multiline = true;
            this.actualPriceBox.Name = "actualPriceBox";
            this.actualPriceBox.Size = new System.Drawing.Size(88, 29);
            this.actualPriceBox.TabIndex = 32;
            this.actualPriceBox.Text = "$0.00";
            this.actualPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "Final Price";
            // 
            // btnWOdelete
            // 
            this.btnWOdelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnWOdelete.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnWOdelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWOdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWOdelete.ForeColor = System.Drawing.Color.White;
            this.btnWOdelete.Location = new System.Drawing.Point(308, 469);
            this.btnWOdelete.Name = "btnWOdelete";
            this.btnWOdelete.Size = new System.Drawing.Size(122, 51);
            this.btnWOdelete.TabIndex = 36;
            this.btnWOdelete.Text = "DELETE";
            this.btnWOdelete.UseVisualStyleBackColor = false;
            this.btnWOdelete.Click += new System.EventHandler(this.btnWOdelete_Click);
            // 
            // btnWorkupdate
            // 
            this.btnWorkupdate.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnWorkupdate.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.btnWorkupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWorkupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkupdate.ForeColor = System.Drawing.Color.White;
            this.btnWorkupdate.Location = new System.Drawing.Point(153, 469);
            this.btnWorkupdate.Name = "btnWorkupdate";
            this.btnWorkupdate.Size = new System.Drawing.Size(122, 51);
            this.btnWorkupdate.TabIndex = 37;
            this.btnWorkupdate.Text = "UPDATE";
            this.btnWorkupdate.UseVisualStyleBackColor = false;
            this.btnWorkupdate.Click += new System.EventHandler(this.btnWorkupdate_Click);
            // 
            // btnWOcancel
            // 
            this.btnWOcancel.BackColor = System.Drawing.Color.Bisque;
            this.btnWOcancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnWOcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWOcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWOcancel.ForeColor = System.Drawing.Color.DimGray;
            this.btnWOcancel.Location = new System.Drawing.Point(463, 469);
            this.btnWOcancel.Name = "btnWOcancel";
            this.btnWOcancel.Size = new System.Drawing.Size(122, 51);
            this.btnWOcancel.TabIndex = 38;
            this.btnWOcancel.Text = "CANCEL";
            this.btnWOcancel.UseVisualStyleBackColor = false;
            this.btnWOcancel.Click += new System.EventHandler(this.btnWOcancel_Click);
            // 
            // invoiceDataGridView
            // 
            this.invoiceDataGridView.AutoGenerateColumns = false;
            this.invoiceDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.invoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceID,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.customerIDDataGridViewTextBoxColumn,
            this.serviceIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.customerDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn11,
            this.serviceDataGridViewTextBoxColumn});
            this.invoiceDataGridView.DataSource = this.invoiceBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.invoiceDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.invoiceDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.invoiceDataGridView.Location = new System.Drawing.Point(0, 0);
            this.invoiceDataGridView.Name = "invoiceDataGridView";
            this.invoiceDataGridView.RowHeadersWidth = 51;
            this.invoiceDataGridView.RowTemplate.Height = 24;
            this.invoiceDataGridView.Size = new System.Drawing.Size(701, 388);
            this.invoiceDataGridView.TabIndex = 39;
            this.invoiceDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.invoiceDataGridView_DataError_1);
            this.invoiceDataGridView.DoubleClick += new System.EventHandler(this.invoiceDataGridView_DoubleClick_1);
            // 
            // InvoiceID
            // 
            this.InvoiceID.DataPropertyName = "Invoice_ID";
            this.InvoiceID.HeaderText = "Invoice_ID";
            this.InvoiceID.MinimumWidth = 6;
            this.InvoiceID.Name = "InvoiceID";
            this.InvoiceID.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Date";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Employee_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Employee_ID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "Service_ID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "Service_ID";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EstimatePrice";
            this.dataGridViewTextBoxColumn9.HeaderText = "EstimatePrice";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FinalPrice";
            this.dataGridViewTextBoxColumn10.HeaderText = "FinalPrice";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Visible = false;
            this.customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Employee";
            this.dataGridViewTextBoxColumn11.HeaderText = "Employee";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Service";
            this.serviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.Visible = false;
            this.serviceDataGridViewTextBoxColumn.Width = 125;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(Marys_Auto.Models.Invoice);
            // 
            // WorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.Controls.Add(this.invoiceDataGridView);
            this.Controls.Add(this.btnWOcancel);
            this.Controls.Add(this.btnWorkupdate);
            this.Controls.Add(this.btnWOdelete);
            this.Controls.Add(this.actualPriceBox);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkOrder";
            this.Size = new System.Drawing.Size(701, 537);
            this.Load += new System.EventHandler(this.WorkOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox actualPriceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnWOdelete;
        private System.Windows.Forms.Button btnWorkupdate;
        private System.Windows.Forms.Button btnWOcancel;
        private System.Windows.Forms.DataGridView invoiceDataGridView;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
    }
}
