﻿using System;
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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DepEmp' table. You can move, or remove it, as needed.
            this.DepEmpTableAdapter.FillEmpDep(this.DataSet1.DepEmp);

            this.reportViewer1.RefreshReport();
        }
    }
}
