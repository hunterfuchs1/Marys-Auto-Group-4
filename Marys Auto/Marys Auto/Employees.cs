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
using Marys_Auto.Models;

namespace Marys_Auto
{
    public partial class Employees : UserControl
    {
        public Employees()
        {
            InitializeComponent();
        }
        //string connectionString = "Data Source=Abdalla;Initial Catalog=MarysAutoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void Employees_Load(object sender, EventArgs e)
        {
            //loadEmployeeData();
            populateEmployeeData();
        }

        public void populateEmployeeData()
        {
            dtgvEmployee.AutoGenerateColumns = false;
            using (MarysAutoDB2Entities db = new MarysAutoDB2Entities())
            {
                dtgvEmployee.DataSource = db.Employees.ToList<Employee>();

            }
        }
        Employee employee = new Employee();
        private void btnEupdate_Click(object sender, EventArgs e)
        {
            employee.EmployeeFirstName = txtEFname.Text.Trim();
            employee.EmployeeLastName = txtELname.Text.Trim();
            employee.JobTitle = txtEtitle.Text.Trim();
            employee.HourlyWage = decimal.Parse(txtEwage.Text.Trim());
            employee.Experience = int.Parse(txtEexperience.Text.Trim());
            
            using (MarysAutoDB2Entities db = new MarysAutoDB2Entities())
            {
                if (employee.Employee_ID == 0)
                {
                    db.Employees.Add(employee);
                }
                else
                {
                    db.Entry(employee).State = EntityState.Modified;
                }
                db.SaveChanges();
            }
            Clear();
            populateEmployeeData();
            MessageBox.Show("Successfully updated!");
        }
        public void Clear()
        {
            txtEFname.Text = "";
            txtELname.Text = "";
            txtEtitle.Text = "";
            txtEwage.Text = "";
            txtEexperience.Text = "";
           
        }

        private void dtgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvEmployee.CurrentRow.Index != -1)
            {
                employee.Employee_ID = Convert.ToInt32(dtgvEmployee.CurrentRow.Cells["EmployeeID"].Value);
                using (MarysAutoDB2Entities db = new MarysAutoDB2Entities())
                {
                    employee = db.Employees.Where(x => x.Employee_ID == employee.Employee_ID).FirstOrDefault();
                    txtEFname.Text = employee.EmployeeFirstName;
                    txtELname.Text = employee.EmployeeLastName;
                    txtEtitle.Text = employee.JobTitle;
                    txtEwage.Text = employee.HourlyWage.ToString();
                    txtEexperience.Text = employee.Experience.ToString();
                    

                }
            }
        }

        private void dtgvEmployee_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        //public void loadEmployeeData()
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();
        //        string query = "SELECT * FROM Employees";
        //        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //        DataSet table = new DataSet();
        //        adapter.Fill(table, "Employees");
        //        dtgvEmployee.DataSource = table.Tables["Employees"].DefaultView;
        //    }
        //}
    }
}
