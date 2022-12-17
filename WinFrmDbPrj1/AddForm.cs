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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try {
                employeeTableAdapter1.InsertQueryInEmployee(int.Parse(textBox1.Text), textBox2.Text,
                    textBox3.Text, textBox4.Text, decimal.Parse(textBox5.Text),
                    int.Parse(textBox6.Text));
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (Control f in this.groupBox1.Controls)
            {

                if(f is TextBox)
                {
                    f.ResetText();
                }
            }
            textBox1.Focus();
        }

        private void btnInsertDep_Click(object sender, EventArgs e)
        {
            //departmentTableAdapter1.Insert(int.Parse(textBox10.Text), textBox11.Text, textBox12.Text);
            DataSet1TableAdapters.DepartmentTableAdapter dt = new DataSet1TableAdapters.DepartmentTableAdapter();
            dt.Insert(int.Parse(textBox10.Text), textBox11.Text, textBox12.Text);
        }

        
    }
}
