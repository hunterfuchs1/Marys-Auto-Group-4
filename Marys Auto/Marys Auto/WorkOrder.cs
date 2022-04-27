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
       // string connectionString = "Data Source=Abdalla;Initial Catalog=MarysAutoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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

            //populateData();
            //loadWOData();
            populateWOData();
            
        }


        //public void loadWOData()
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();
        //        string query = "SELECT * FROM Invoice";
        //        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //        DataSet table = new DataSet();
        //        adapter.Fill(table, "Invoice");
        //        invoiceDataGridView.DataSource = table.Tables["Invoice"].DefaultView;
        //    }
        //}

        //private void workOrdergridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        //{
        //    e.Cancel = true;
        //}

        //private void workOrdergridView_DoubleClick(object sender, EventArgs e)
        //{
        //    //if(workOrdergridView.CurrentRow.Index != -1)
        //    //{
        //    //    //Invoice invoice = new Invoice();
        //    //    //invoice.Invoice_ID = Convert.ToInt32(workOrdergridView.CurrentRow.Cells["Invoice_ID"].Value);
        //    //    //using(MarysAutoDBEntities db = new MarysAutoDBEntities())
        //    //    //{
        //    //    //    invoice = db.Invoices.Where(x => x.Invoice_ID == invoice.Invoice_ID).FirstOrDefault();
        //    //    //    estimatedPriceBox.Text = invoice.EstimatePrice.ToString();
        //    //    //}
        //    //}
        //}

        private void btnUpdate_Click(object sender, EventArgs e)
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
            MessageBox.Show("Successfully updated!");
            actualPriceBox.Text = "";
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
        Invoice invoice = new Invoice();
        private void invoiceDataGridView_DoubleClick(object sender, EventArgs e)
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

        private void invoiceDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
