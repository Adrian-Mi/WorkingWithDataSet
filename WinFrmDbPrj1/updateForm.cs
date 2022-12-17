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
    public partial class updateForm : Form
    {
        public int myId;
        public updateForm()
        {
            InitializeComponent();
        }

        private void updateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dataSet1.Employee);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            myId = int.Parse(textBox1.Text);
            employeeTableAdapter.UpdateQueryEmployee(textBox2.Text, textBox3.Text, textBox4.Text
                , decimal.Parse(textBox5.Text), int.Parse(textBox6.Text), myId);
            DataSet1TableAdapters.EmployeeTableAdapter dt = new DataSet1TableAdapters.EmployeeTableAdapter();

            //dt.UpdateQueryEmployee(textBox2.Text, textBox3.Text, textBox4.Text
            //  , decimal.Parse(textBox5.Text), int.Parse(textBox6.Text), myId);
            this.employeeTableAdapter.Fill(this.dataSet1.Employee);
            MessageBox.Show("Record was updated.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            int c = dataGridView1.CurrentCell.ColumnIndex;
            int myId = int.Parse(dataGridView1.Rows[r].Cells[0].Value.ToString());

            textBox1.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();

            int count = dataGridView1.Rows.Count;
            if(c==6 && r<=count-2)
            {
                if(MessageBox.Show("آیا از خذف رکورد مطمئن هستید؟","هشدار",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    employeeTableAdapter.DeleteQueryEmployee(myId);
                    this.employeeTableAdapter.Fill(this.dataSet1.Employee);
                    foreach(Control f in this.groupBox1.Controls)
                    {
                        if(f is TextBox)
                        {
                            f.ResetText();
                        }
                    }
                }
            }

            //myId = int.Parse(dataGridView1.SelectedRows[r].Cells[0].ToString());
            //MessageBox.Show(myId.ToString());           

        }

      
    }
}
