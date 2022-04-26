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
    public partial class Employees : UserControl
    {
        public Employees()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=Abdalla;Initial Catalog=MarysAutoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void Employees_Load(object sender, EventArgs e)
        {
            loadEmployeeData();
        }
        public void loadEmployeeData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Employees";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet table = new DataSet();
                adapter.Fill(table, "Employees");
                dtgvEmployee.DataSource = table.Tables["Employees"].DefaultView;
            }
        }
    }
}
