using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CenterFireBulletWeighing
{
    public partial class frmStatusReport : Form
    {
        public frmStatusReport()
        {
            InitializeComponent();
        }

        private void frmStatusReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsStatusReport.tblLots' table. You can move, or remove it, as needed.
            this.tblLotsTableAdapter.Fill(this.dsStatusReport.tblLots);
            this.reportViewer1.RefreshReport();
            this.tblPlatingCheckTableAdapter.Fill(this.dsPlatingCheck.tblPlatingCheck);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

      

    }
}
