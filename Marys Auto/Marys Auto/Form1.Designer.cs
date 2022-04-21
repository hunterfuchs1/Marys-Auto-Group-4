
namespace Marys_Auto
{
    partial class mainUserInputForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnWorkOrder = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.workOrder1 = new Marys_Auto.WorkOrder();
            this.report1 = new Marys_Auto.Report();
            this.customers1 = new Marys_Auto.Customers();
            this.employees1 = new Marys_Auto.Employees();
            this.services1 = new Marys_Auto.Services();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Marys_Auto.Properties.Resources.chain_wheel_tire2;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mary\'s Auto Shop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnWorkOrder);
            this.panel2.Controls.Add(this.btnReport);
            this.panel2.Controls.Add(this.btnCustomers);
            this.panel2.Controls.Add(this.btnServices);
            this.panel2.Controls.Add(this.btnEmployees);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 530);
            this.panel2.TabIndex = 1;
            // 
            // btnWorkOrder
            // 
            this.btnWorkOrder.BackColor = System.Drawing.Color.LightCoral;
            this.btnWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkOrder.Image = global::Marys_Auto.Properties.Resources.icons8_briefcase_60;
            this.btnWorkOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkOrder.Location = new System.Drawing.Point(0, 130);
            this.btnWorkOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWorkOrder.Name = "btnWorkOrder";
            this.btnWorkOrder.Size = new System.Drawing.Size(259, 89);
            this.btnWorkOrder.TabIndex = 4;
            this.btnWorkOrder.Text = "Work Order";
            this.btnWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWorkOrder.UseVisualStyleBackColor = false;
            this.btnWorkOrder.Click += new System.EventHandler(this.btnWorkOrder_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Image = global::Marys_Auto.Properties.Resources.icons8_report_64;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(-3, 447);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(0, 0, 29, 0);
            this.btnReport.Size = new System.Drawing.Size(259, 89);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Image = global::Marys_Auto.Properties.Resources.icons8_customer_64;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(0, 343);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(259, 89);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.Tomato;
            this.btnServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.Image = global::Marys_Auto.Properties.Resources.icons8_maintenance_50;
            this.btnServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServices.Location = new System.Drawing.Point(0, 21);
            this.btnServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServices.Name = "btnServices";
            this.btnServices.Padding = new System.Windows.Forms.Padding(5, 0, 25, 0);
            this.btnServices.Size = new System.Drawing.Size(259, 89);
            this.btnServices.TabIndex = 0;
            this.btnServices.Text = "Services";
            this.btnServices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Image = global::Marys_Auto.Properties.Resources.icons8_employees_64;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(3, 236);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(259, 89);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // workOrder1
            // 
            this.workOrder1.AutoSize = true;
            this.workOrder1.Dock = System.Windows.Forms.DockStyle.Top;
            this.workOrder1.Location = new System.Drawing.Point(259, 1634);
            this.workOrder1.Margin = new System.Windows.Forms.Padding(5);
            this.workOrder1.Name = "workOrder1";
            this.workOrder1.Size = new System.Drawing.Size(857, 518);
            this.workOrder1.TabIndex = 6;
            // 
            // report1
            // 
            this.report1.Dock = System.Windows.Forms.DockStyle.Top;
            this.report1.Location = new System.Drawing.Point(259, 1110);
            this.report1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.report1.Name = "report1";
            this.report1.Size = new System.Drawing.Size(857, 524);
            this.report1.TabIndex = 5;
            // 
            // customers1
            // 
            this.customers1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customers1.Location = new System.Drawing.Point(259, 586);
            this.customers1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customers1.Name = "customers1";
            this.customers1.Size = new System.Drawing.Size(857, 524);
            this.customers1.TabIndex = 4;
            // 
            // employees1
            // 
            this.employees1.Dock = System.Windows.Forms.DockStyle.Top;
            this.employees1.Location = new System.Drawing.Point(259, 62);
            this.employees1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employees1.Name = "employees1";
            this.employees1.Size = new System.Drawing.Size(857, 524);
            this.employees1.TabIndex = 3;
            // 
            // services1
            // 
            this.services1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.services1.Location = new System.Drawing.Point(259, 62);
            this.services1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.services1.Name = "services1";
            this.services1.Size = new System.Drawing.Size(857, 530);
            this.services1.TabIndex = 2;
            // 
            // mainUserInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 592);
            this.Controls.Add(this.workOrder1);
            this.Controls.Add(this.report1);
            this.Controls.Add(this.customers1);
            this.Controls.Add(this.employees1);
            this.Controls.Add(this.services1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainUserInputForm";
            this.Text = "Mary\'s Auto";
            this.Load += new System.EventHandler(this.mainUserInputForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnServices;
        private Services services1;
        private Employees employees1;
        private Customers customers1;
        private Report report1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWorkOrder;
        private WorkOrder workOrder1;
    }
}

