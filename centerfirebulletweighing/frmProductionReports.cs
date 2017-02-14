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
    public partial class frmProductionReports : Form
    {
        public frmProductionReports()
        {
            InitializeComponent();
        }

        private void frmProductionReports_Load(object sender, EventArgs e)
        {
            // Fill combo boxes for selection
            this.tblOperatorsTableAdapter.Fill(this.dsOperators.tblOperators);
            this.tblLotsTableAdapter.Fill(this.dsLots.tblLots);
            this.tblProductsTableAdapter.Fill(this.dsProducts.tblProducts);

            // Initial Fill of Report
            this.qryProductionReportTableAdapter.Fill(this.dsProductionReport.qryProductionReport);
            this.rptViewerProduct.RefreshReport();
        }


        private void btnByLot_Click(object sender, EventArgs e)
        {
            this.qryProductionReportTableAdapter.FillByLot(this.dsProductionReport.qryProductionReport, Convert.ToInt32(this.cboLot.Text));
            this.rptViewerProduct.RefreshReport();

        }

        private void btnByProduct_Click(object sender, EventArgs e)
        {
            this.qryProductionReportTableAdapter.FillByProduct(this.dsProductionReport.qryProductionReport, this.cboProductID.Text);
            this.rptViewerProduct.RefreshReport();

        }

        private void btnByOperator_Click(object sender, EventArgs e)
        {
            this.qryProductionReportTableAdapter.FillByOperator(this.dsProductionReport.qryProductionReport, Convert.ToInt32(this.cboOperator.SelectedValue));
            this.rptViewerProduct.RefreshReport();

        }

        private void btnByYear_Click(object sender, EventArgs e)
        {
            this.qryProductionReportTableAdapter.FillDataByYear(this.dsProductionReport.qryProductionReport, this.cboByYear.Text);
            this.rptViewerProduct.RefreshReport();

        }

        
        private void btnFilterByDay_Click(object sender, EventArgs e)
        {
            this.qryProductionReportTableAdapter.FillByDate(this.dsProductionReport.qryProductionReport, this.dateTimePicker1.Value.Date);
            this.rptViewerProduct.RefreshReport();
        }

        

    
    }
}
