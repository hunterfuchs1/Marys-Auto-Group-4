using Marys_Auto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marys_Auto
{
    public partial class WorkOrder : UserControl
    {
        public WorkOrder()
        {
            InitializeComponent();
        }
        //public void populateData()
        //{
        //    workOrdergridView.AutoGenerateColumns = false;
        //    using (MarysAutoDBEntities db = new MarysAutoDBEntities())
        //    {
        //        workOrdergridView.DataSource =  db.Invoices.ToList<Invoice>();
        //    }
        //}

        private void WorkOrder_Load(object sender, EventArgs e)
        {
            
            //populateData();
        }

        private void workOrdergridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void workOrdergridView_DoubleClick(object sender, EventArgs e)
        {
            //if(workOrdergridView.CurrentRow.Index != -1)
            //{
            //    //Invoice invoice = new Invoice();
            //    //invoice.Invoice_ID = Convert.ToInt32(workOrdergridView.CurrentRow.Cells["Invoice_ID"].Value);
            //    //using(MarysAutoDBEntities db = new MarysAutoDBEntities())
            //    //{
            //    //    invoice = db.Invoices.Where(x => x.Invoice_ID == invoice.Invoice_ID).FirstOrDefault();
            //    //    estimatedPriceBox.Text = invoice.EstimatePrice.ToString();
            //    //}
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Invoice invoice = new Invoice();
            //invoice.FinalPrice = decimal.Parse(actualPriceBox.Text);
            //using(MarysAutoDBEntities db = new MarysAutoDBEntities())
            //{
            //    var finalPrice = from x in db.Invoices
            //                     where x.Invoice_ID == invoice.Invoice_ID
            //                     select x.Invoice_ID;
            //    finalPrice.
            //}
        }

        private void invoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marysAutoDataSet);

        }
    }
}
