
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Marys_Auto.Models;
using System.Data.SqlClient;

namespace Marys_Auto
{
    public partial class Customers : UserControl
    {
        public Customers()
        {
            InitializeComponent();
            //populateCustomerData();
        }
        string connectionString = "Data Source=Abdalla;Initial Catalog=MarysAutoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        private void Customers_Load(object sender, EventArgs e)
        {
            //populateCustomerData();
            //string connectionString = "Data Source=Abdalla;Initial Catalog=MarysAutoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    conn.Open();
            //    string query = "SELECT * FROM Customers";
            //    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            //    DataSet data = new DataSet();
            //    dataAdapter.Fill(data, "Customers");
            //    customersDataGridView.DataSource = dataAdapter;
            //}
            loadCustomerData();
            

        }

        public void loadCustomerData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Customers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet table = new DataSet();
                adapter.Fill(table, "Customers");
                customersDataGridView.DataSource = table.Tables["Customers"].DefaultView;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            //customer.CustomerFirstName = txtCusFname.Text.Trim();
            //customer.CustomerLastName = txtCusLname.Text.Trim();
            //customer.CustomerStreetAddress = txtCusAddress.Text.Trim();
            //customer.CustomerCity = txtCusCity.Text.Trim();
            //customer.CustomerState = txtCusState.Text.Trim();
            //customer.CustomerZipCode = txtCusZip.Text.Trim();
            //customer.CustomerPhoneAreaCode = txtCusAreaCode.Text.Trim();
            //customer.CustomerPhoneNumber = txtCusPhone.Text.Trim();
            //using (MarysAutoDBEntities db = new MarysAutoDBEntities())
            //{
            //    if(customer.Customer_ID == 0)
            //    {
            //        db.Customers.Add(customer);
            //    }
            //    else
            //    {
            //        db.Entry(customer).State = EntityState.Modified;
            //    }
            //    db.SaveChanges();
            //}
            Clear();
            //populateCustomerData();
            MessageBox.Show("Successfully updated!");

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

        private void customersDataGridView_DoubleClick(object sender, EventArgs e)
        {
            //if(customersDataGridView.CurrentRow.Index != -1)
            //{
            //    customer.Customer_ID = Convert.ToInt32(customersDataGridView.CurrentRow.Cells["Customer_ID"].Value);
            //    using (MarysAutoDBEntities db = new MarysAutoDBEntities())
            //    {
            //        customer = db.Customers.Where(x => x.Customer_ID == customer.Customer_ID).FirstOrDefault();
            //        txtCusFname.Text = customer.CustomerFirstName;
            //        txtCusLname.Text = customer.CustomerLastName;
            //        txtCusAddress.Text = customer.CustomerStreetAddress;
            //        txtCusCity.Text = customer.CustomerCity;
            //        txtCusState.Text = customer.CustomerState;
            //        txtCusZip.Text = customer.CustomerZipCode;
            //        txtCusAreaCode.Text = customer.CustomerPhoneAreaCode;
            //        txtCusPhone.Text = customer.CustomerPhoneNumber;

            //    }

            //    btnSave.Text = "Update";
            //    btnDelete.Enabled = true;
            //}
            
        }


    }
}
