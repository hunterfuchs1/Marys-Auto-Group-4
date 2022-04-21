
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
    public partial class Employees : UserControl
    {
        public Employees()
        {
            InitializeComponent();
        }
        //public void populateData()
        //{
        //    EmployeeGridView.AutoGenerateColumns = false;
        //    using (MarysAutoDBEntities db = new MarysAutoDBEntities())
        //    {
        //        this.EmployeeGridView.DataSource = db.Employees.ToList<Employee>();
                
        //    }
        //}

        private void Employees_Load(object sender, EventArgs e)
        {
            //populateData();

        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marysAutoDataSet);

        }
    }
}
