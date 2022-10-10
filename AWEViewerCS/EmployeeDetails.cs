using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AWEViewerCS
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeDetailsDataSet.vEmployeeDetails". При необходимости она может быть перемещена или удалена.
            this.vEmployeeDetailsTableAdapter.Fill(this.employeeDetailsDataSet.vEmployeeDetails);

        }

        private void closeToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
