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
using Microsoft.Reporting.WinForms;

namespace Marys_Auto
{
    public partial class Report : UserControl
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
           
        }

        private void dtgvReport_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        

        public void generateReport()
        {
            using (MarysAutoDB2Entities db = new MarysAutoDB2Entities())
            {
                bindingSource2.DataSource = db.reportDatas.ToList();
                reportViewer2.RefreshReport();
            }
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {
            generateReport();
        }
    }
}
