using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrmDbPrj1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dataSet1.Employee);
            // TODO: This line of code loads data into the 'dataSet1.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dataSet1.Department);

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            f.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.dataSet1.Employee);
            this.departmentTableAdapter.Fill(this.dataSet1.Department);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new updateForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportForm f = new ReportForm();
            f.ShowDialog();
        }
    }
}
