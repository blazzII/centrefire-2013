namespace CenterFireBulletWeighing
{
    partial class frmStatusReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblLotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsStatusReport = new CenterFireBulletWeighing.dsStatusReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblLotsTableAdapter = new CenterFireBulletWeighing.dsStatusReportTableAdapters.tblLotsTableAdapter();
            this.tblPlatingCheckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPlatingCheck = new CenterFireBulletWeighing.dsPlatingCheck();
            this.tblPlatingCheckTableAdapter = new CenterFireBulletWeighing.dsPlatingCheckTableAdapters.tblPlatingCheckTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblLotsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatusReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlatingCheckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlatingCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLotsBindingSource
            // 
            this.tblLotsBindingSource.DataMember = "tblLots";
            this.tblLotsBindingSource.DataSource = this.dsStatusReport;
            // 
            // dsStatusReport
            // 
            this.dsStatusReport.DataSetName = "dsStatusReport";
            this.dsStatusReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsStatusReport_tblLots";
            reportDataSource1.Value = this.tblLotsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CenterFireBulletWeighing.rptStatusReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1010, 835);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblLotsTableAdapter
            // 
            this.tblLotsTableAdapter.ClearBeforeFill = true;
            // 
            // tblPlatingCheckBindingSource
            // 
            this.tblPlatingCheckBindingSource.DataMember = "tblPlatingCheck";
            this.tblPlatingCheckBindingSource.DataSource = this.dsPlatingCheck;
            // 
            // dsPlatingCheck
            // 
            this.dsPlatingCheck.DataSetName = "dsPlatingCheck";
            this.dsPlatingCheck.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPlatingCheckTableAdapter
            // 
            this.tblPlatingCheckTableAdapter.ClearBeforeFill = true;
            // 
            // frmStatusReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 835);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmStatusReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plating Status Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStatusReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblLotsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatusReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlatingCheckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlatingCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tblPlatingCheckBindingSource;
        private dsPlatingCheck dsPlatingCheck;
        private CenterFireBulletWeighing.dsPlatingCheckTableAdapters.tblPlatingCheckTableAdapter tblPlatingCheckTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblLotsBindingSource;
        private dsStatusReport dsStatusReport;
        private CenterFireBulletWeighing.dsStatusReportTableAdapters.tblLotsTableAdapter tblLotsTableAdapter;
    }
}