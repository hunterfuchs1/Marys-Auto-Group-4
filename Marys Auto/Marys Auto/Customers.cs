
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Marys_Auto.Models;

namespace Marys_Auto
{
    public partial class Customers : UserControl
    {
        public Customers()
        {
            InitializeComponent();
        }
        //public void populateCustomerData()
        //{
        //    CustomerGridView.AutoGenerateColumns = false;
        //    using (MarysAuto_DBEntities db = new MarysAuto_DBEntities())
        //    {
        //        CustomerGridView.DataSource = db.Customers.ToList<Customer>();
        //    }
        //}

        private void Customers_Load(object sender, EventArgs e)
        {
            //populateCustomerData();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marysAutoDataSet);

        }
    }
}
