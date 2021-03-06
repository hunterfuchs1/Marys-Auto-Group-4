
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
using System.Data.SqlClient;

namespace Marys_Auto
{
    public partial class Customers : UserControl
    {
        public Customers()
        {
            InitializeComponent();
        }
        
        
        private void Customers_Load(object sender, EventArgs e)
        {
            populateCustomerData();
        }

        public void populateCustomerData()
        {
            customersDataGridView.AutoGenerateColumns = false;
            using (MarysAutoDB2Entities db = new MarysAutoDB2Entities())
            {
                customersDataGridView.DataSource = db.Customers.ToList<Customer>();

            }
        }

        Customer customer = new Customer();
        private void btnSave_Click(object sender, EventArgs e)
        {

            customer.CustomerFirstName = txtCusFname.Text.Trim();
            customer.CustomerLastName = txtCusLname.Text.Trim();
            customer.CustomerStreetAddress = txtCusAddress.Text.Trim();
            customer.CustomerCity = txtCusCity.Text.Trim();
            customer.CustomerState = txtCusState.Text.Trim();
            customer.CustomerZipCode = txtCusZip.Text.Trim();
            customer.CustomerPhoneAreaCode = txtCusAreaCode.Text.Trim();
            customer.CustomerPhoneNumber = txtCusPhone.Text.Trim();
            using (MarysAutoDB2Entities db = new MarysAutoDB2Entities())
            {
                if (customer.Customer_ID == 0)
                {
                    db.Customers.Add(customer);
                }
                else
                {
                    db.Entry(customer).State = EntityState.Modified;
                }
                db.SaveChanges();
            }
            Clear();
            populateCustomerData();
            MessageBox.Show("Successfully updated!", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void Clear()
        {
            txtCusFname.Text = "";
            txtCusLname.Text = "";
            txtCusAddress.Text = "";
            txtCusCity.Text = "";
            txtCusState.Text = "";
            txtCusZip.Text = "";
            txtCusAreaCode.Text = "";
            txtCusPhone.Text = "";
        }

        private void customersDataGridView_DoubleClick_1(object sender, EventArgs e)
        {
            if (customersDataGridView.CurrentRow.Index != -1)
            {
                customer.Customer_ID = Convert.ToInt32(customersDataGridView.CurrentRow.Cells["CustomerID"].Value);
                using (MarysAutoDB2Entities db = new MarysAutoDB2Entities())
                {
                    customer = db.Customers.Where(x => x.Customer_ID == customer.Customer_ID).FirstOrDefault();
                    txtCusFname.Text = customer.CustomerFirstName;
                    txtCusLname.Text = customer.CustomerLastName;
                    txtCusAddress.Text = customer.CustomerStreetAddress;
                    txtCusCity.Text = customer.CustomerCity;
                    txtCusState.Text = customer.CustomerState;
                    txtCusZip.Text = customer.CustomerZipCode;
                    txtCusAreaCode.Text = customer.CustomerPhoneAreaCode;
                    txtCusPhone.Text = customer.CustomerPhoneNumber;

                }
            }
        }

        private void customersDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
