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
using Marys_Auto.Models;

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
            this.employees1.Visible = false;
            this.customers1.Visible = false;
            this.report1.Visible = false;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.services1.Visible = false;
            this.employees1.Visible = true;
            this.customers1.Visible = false;
            this.report1.Visible = false;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.services1.Visible = false;
            this.employees1.Visible = false;
            this.customers1.Visible = true;
            this.report1.Visible = false;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.services1.Visible = false;
            this.employees1.Visible = false;
            this.customers1.Visible = false;
            this.report1.Visible = true;
        }
    }
}
