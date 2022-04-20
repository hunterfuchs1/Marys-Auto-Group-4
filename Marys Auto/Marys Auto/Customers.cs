using Marys_Auto.Models;
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
    public partial class Customers : UserControl
    {
        public Customers()
        {
            InitializeComponent();
        }
        public void populateData()
        {
            CustomerGridView.AutoGenerateColumns = false;
            using (MarysAutoDBEntities db = new MarysAutoDBEntities())
            {
                CustomerGridView.DataSource = db.Customers.ToList<Customer>();
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            populateData();
        }
    }
}
