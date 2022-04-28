using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Marys_Auto;

namespace Marys_Auto
{
    public partial class mainUserInputForm : Form
    {
        public mainUserInputForm()
        {
            InitializeComponent();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            this.services1.Visible = true;
            this.customers1.Visible = false;
            this.report1.Visible = false;
            this.workOrder1.Visible = false;
            this.employees1.Visible = false;
            this.panel1.BackColor = Color.Tomato;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.services1.Visible = false;
            this.customers1.Visible = false;
            this.report1.Visible = false;
            this.workOrder1.Visible = false;
            this.employees1.Visible = true;
            employees1.populateEmployeeData();
            this.panel1.BackColor = Color.SkyBlue;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.services1.Visible = false;
            this.customers1.Visible = true;
            this.report1.Visible = false;
            this.workOrder1.Visible = false;
            this.employees1.Visible = false;
            customers1.populateCustomerData();
            this.panel1.BackColor = Color.CadetBlue;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.services1.Visible = false;
            this.customers1.Visible = false;
            this.report1.Visible = true;
            this.workOrder1.Visible = false;
            this.employees1.Visible = false;
            report1.generateReport();
            this.panel1.BackColor = Color.SteelBlue;

        }

        private void btnWorkOrder_Click(object sender, EventArgs e)
        {
            this.services1.Visible = false;
            this.customers1.Visible = false;
            this.report1.Visible = false;
            this.workOrder1.Visible = true;
            this.employees1.Visible = false;
            workOrder1.populateWOData();
            this.panel1.BackColor = Color.LightCoral;
        }
        private void mainUserInputForm_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
