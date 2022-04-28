using Marys_Auto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
       
        public void populateWOData()
        {
            invoiceDataGridView.AutoGenerateColumns = false;
            using (MarysAutoDB2Entities db = new MarysAutoDB2Entities())
            {
                invoiceDataGridView.DataSource = db.Invoices.ToList<Invoice>();
            }
        }

        private void WorkOrder_Load(object sender, EventArgs e)
        {
            populateWOData();
        }

        public void updateRecord()
        {
            invoice.FinalPrice = decimal.Parse(actualPriceBox.Text.Trim());

            using (MarysAutoDB2Entities db = new MarysAutoDB2Entities())
            {
                if (invoice.Invoice_ID == 0)
                {
                    db.Invoices.Add(invoice);
                }
                else
                {
                    db.Entry(invoice).State = EntityState.Modified;
                }
                db.SaveChanges();
            }
            populateWOData();
            actualPriceBox.Text = "$0.00";
            MessageBox.Show("Successfully updated!","Record Updated",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        Invoice invoice = new Invoice();
        private void invoiceDataGridView_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void invoiceDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnWOdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Record Deletion",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (MarysAutoDB2Entities db = new MarysAutoDB2Entities())
                {
                    var entry = db.Entry(invoice);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Invoices.Attach(invoice);
                        db.Invoices.Remove(invoice);
                        db.SaveChanges();
                        populateWOData();
                        actualPriceBox.Text = "";
                        MessageBox.Show("Deleted Successfully","Deletion Confirmed",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnWorkupdate_Click(object sender, EventArgs e)
        {
            updateRecord();
        }

        private void btnWOcancel_Click(object sender, EventArgs e)
        {
            actualPriceBox.Text = "$0.00";
        }

        private void invoiceDataGridView_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void invoiceDataGridView_DoubleClick_1(object sender, EventArgs e)
        {
            if (invoiceDataGridView.CurrentRow.Index != -1)
            {
                invoice.Invoice_ID = Convert.ToInt32(invoiceDataGridView.CurrentRow.Cells["InvoiceID"].Value);
                using (MarysAutoDB2Entities db = new MarysAutoDB2Entities())
                {
                    invoice = db.Invoices.Where(x => x.Invoice_ID == invoice.Invoice_ID).FirstOrDefault();
                    actualPriceBox.Text = invoice.FinalPrice.ToString();
                }
            }
        }
    }
}
