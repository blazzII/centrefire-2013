namespace CenterFireBulletWeighing
{
    partial class frmProductionReports
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
            this.qryProductionReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProductionReport = new CenterFireBulletWeighing.dsProductionReport();
            this.rptViewerProduct = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboProductID = new System.Windows.Forms.ComboBox();
            this.tblProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProducts = new CenterFireBulletWeighing.dsProducts();
            this.tblProductsTableAdapter = new CenterFireBulletWeighing.dsProductsTableAdapters.tblProductsTableAdapter();
            this.cboLot = new System.Windows.Forms.ComboBox();
            this.tblLotsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsLots = new CenterFireBulletWeighing.dsLots();
            this.tblLotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLotsTableAdapter = new CenterFireBulletWeighing.dsLotsTableAdapters.tblLotsTableAdapter();
            this.btnByProduct = new System.Windows.Forms.Button();
            this.btnByLot = new System.Windows.Forms.Button();
            this.btnByOperator = new System.Windows.Forms.Button();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.tblOperatorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOperators = new CenterFireBulletWeighing.dsOperators();
            this.tblOperatorsTableAdapter = new CenterFireBulletWeighing.dsOperatorsTableAdapters.tblOperatorsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFilterByDay = new System.Windows.Forms.Button();
            this.lblPickDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnByYear = new System.Windows.Forms.Button();
            this.cboByYear = new System.Windows.Forms.ComboBox();
            this.qryProductionReportTableAdapter = new CenterFireBulletWeighing.dsProductionReportTableAdapters.qryProductionReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qryProductionReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductionReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLotsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLotsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOperatorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperators)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qryProductionReportBindingSource
            // 
            this.qryProductionReportBindingSource.DataMember = "qryProductionReport";
            this.qryProductionReportBindingSource.DataSource = this.dsProductionReport;
            // 
            // dsProductionReport
            // 
            this.dsProductionReport.DataSetName = "dsProductionReport";
            this.dsProductionReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptViewerProduct
            // 
            reportDataSource1.Name = "dsProductionReport_qryProductionReport";
            reportDataSource1.Value = this.qryProductionReportBindingSource;
            this.rptViewerProduct.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewerProduct.LocalReport.ReportEmbeddedResource = "CenterFireBulletWeighing.Report2.rdlc";
            this.rptViewerProduct.Location = new System.Drawing.Point(10, 173);
            this.rptViewerProduct.Name = "rptViewerProduct";
            this.rptViewerProduct.Size = new System.Drawing.Size(1200, 953);
            this.rptViewerProduct.TabIndex = 0;
            // 
            // cboProductID
            // 
            this.cboProductID.BackColor = System.Drawing.Color.LightGray;
            this.cboProductID.DataSource = this.tblProductsBindingSource;
            this.cboProductID.DisplayMember = "product_ID";
            this.cboProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductID.ForeColor = System.Drawing.Color.Black;
            this.cboProductID.FormattingEnabled = true;
            this.cboProductID.Location = new System.Drawing.Point(412, 23);
            this.cboProductID.Name = "cboProductID";
            this.cboProductID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboProductID.Size = new System.Drawing.Size(150, 24);
            this.cboProductID.TabIndex = 1;
            this.cboProductID.ValueMember = "product_ID";
            // 
            // tblProductsBindingSource
            // 
            this.tblProductsBindingSource.DataMember = "tblProducts";
            this.tblProductsBindingSource.DataSource = this.dsProductsBindingSource;
            // 
            // dsProductsBindingSource
            // 
            this.dsProductsBindingSource.DataSource = this.dsProducts;
            this.dsProductsBindingSource.Position = 0;
            // 
            // dsProducts
            // 
            this.dsProducts.DataSetName = "dsProducts";
            this.dsProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductsTableAdapter
            // 
            this.tblProductsTableAdapter.ClearBeforeFill = true;
            // 
            // cboLot
            // 
            this.cboLot.BackColor = System.Drawing.Color.LightGray;
            this.cboLot.DataSource = this.tblLotsBindingSource1;
            this.cboLot.DisplayMember = "lot_ID";
            this.cboLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLot.ForeColor = System.Drawing.Color.Black;
            this.cboLot.FormattingEnabled = true;
            this.cboLot.Location = new System.Drawing.Point(412, 53);
            this.cboLot.Name = "cboLot";
            this.cboLot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboLot.Size = new System.Drawing.Size(150, 24);
            this.cboLot.TabIndex = 4;
            this.cboLot.ValueMember = "lot_ID";
            // 
            // tblLotsBindingSource1
            // 
            this.tblLotsBindingSource1.DataMember = "tblLots";
            this.tblLotsBindingSource1.DataSource = this.dsLots;
            // 
            // dsLots
            // 
            this.dsLots.DataSetName = "dsLots";
            this.dsLots.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLotsBindingSource
            // 
            this.tblLotsBindingSource.DataMember = "tblLots";
            this.tblLotsBindingSource.DataSource = this.dsLots;
            // 
            // tblLotsTableAdapter
            // 
            this.tblLotsTableAdapter.ClearBeforeFill = true;
            // 
            // btnByProduct
            // 
            this.btnByProduct.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByProduct.ForeColor = System.Drawing.Color.Black;
            this.btnByProduct.Location = new System.Drawing.Point(568, 22);
            this.btnByProduct.Name = "btnByProduct";
            this.btnByProduct.Size = new System.Drawing.Size(129, 24);
            this.btnByProduct.TabIndex = 6;
            this.btnByProduct.Text = "Filter by Product";
            this.btnByProduct.UseVisualStyleBackColor = true;
            this.btnByProduct.Click += new System.EventHandler(this.btnByProduct_Click);
            // 
            // btnByLot
            // 
            this.btnByLot.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByLot.ForeColor = System.Drawing.Color.Black;
            this.btnByLot.Location = new System.Drawing.Point(568, 52);
            this.btnByLot.Name = "btnByLot";
            this.btnByLot.Size = new System.Drawing.Size(129, 24);
            this.btnByLot.TabIndex = 7;
            this.btnByLot.Text = "Filter by Lot #";
            this.btnByLot.UseVisualStyleBackColor = true;
            this.btnByLot.Click += new System.EventHandler(this.btnByLot_Click);
            // 
            // btnByOperator
            // 
            this.btnByOperator.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByOperator.ForeColor = System.Drawing.Color.Black;
            this.btnByOperator.Location = new System.Drawing.Point(568, 82);
            this.btnByOperator.Name = "btnByOperator";
            this.btnByOperator.Size = new System.Drawing.Size(129, 24);
            this.btnByOperator.TabIndex = 10;
            this.btnByOperator.Text = "by Pull Operator";
            this.btnByOperator.UseVisualStyleBackColor = true;
            this.btnByOperator.Click += new System.EventHandler(this.btnByOperator_Click);
            // 
            // cboOperator
            // 
            this.cboOperator.BackColor = System.Drawing.Color.LightGray;
            this.cboOperator.DataSource = this.tblOperatorsBindingSource;
            this.cboOperator.DisplayMember = "operator_Name";
            this.cboOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperator.ForeColor = System.Drawing.Color.Black;
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Location = new System.Drawing.Point(412, 83);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboOperator.Size = new System.Drawing.Size(150, 24);
            this.cboOperator.TabIndex = 8;
            this.cboOperator.ValueMember = "operator_ID";
            // 
            // tblOperatorsBindingSource
            // 
            this.tblOperatorsBindingSource.DataMember = "tblOperators";
            this.tblOperatorsBindingSource.DataSource = this.dsOperators;
            // 
            // dsOperators
            // 
            this.dsOperators.DataSetName = "dsOperators";
            this.dsOperators.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOperatorsTableAdapter
            // 
            this.tblOperatorsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btnFilterByDay);
            this.panel1.Controls.Add(this.lblPickDate);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnByYear);
            this.panel1.Controls.Add(this.cboByYear);
            this.panel1.Controls.Add(this.cboOperator);
            this.panel1.Controls.Add(this.btnByOperator);
            this.panel1.Controls.Add(this.cboProductID);
            this.panel1.Controls.Add(this.cboLot);
            this.panel1.Controls.Add(this.btnByLot);
            this.panel1.Controls.Add(this.btnByProduct);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 155);
            this.panel1.TabIndex = 11;
            // 
            // btnFilterByDay
            // 
            this.btnFilterByDay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterByDay.ForeColor = System.Drawing.Color.Black;
            this.btnFilterByDay.Location = new System.Drawing.Point(221, 59);
            this.btnFilterByDay.Name = "btnFilterByDay";
            this.btnFilterByDay.Size = new System.Drawing.Size(129, 57);
            this.btnFilterByDay.TabIndex = 16;
            this.btnFilterByDay.Text = "RUN REPORT";
            this.btnFilterByDay.UseVisualStyleBackColor = true;
            this.btnFilterByDay.Click += new System.EventHandler(this.btnFilterByDay_Click);
            // 
            // lblPickDate
            // 
            this.lblPickDate.AutoSize = true;
            this.lblPickDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickDate.ForeColor = System.Drawing.Color.White;
            this.lblPickDate.Location = new System.Drawing.Point(11, 13);
            this.lblPickDate.Name = "lblPickDate";
            this.lblPickDate.Size = new System.Drawing.Size(231, 22);
            this.lblPickDate.TabIndex = 15;
            this.lblPickDate.Text = "Daily Production Report";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // btnByYear
            // 
            this.btnByYear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByYear.ForeColor = System.Drawing.Color.Black;
            this.btnByYear.Location = new System.Drawing.Point(568, 112);
            this.btnByYear.Name = "btnByYear";
            this.btnByYear.Size = new System.Drawing.Size(129, 24);
            this.btnByYear.TabIndex = 13;
            this.btnByYear.Text = "Filter By Year";
            this.btnByYear.UseVisualStyleBackColor = true;
            this.btnByYear.Click += new System.EventHandler(this.btnByYear_Click);
            // 
            // cboByYear
            // 
            this.cboByYear.BackColor = System.Drawing.Color.LightGray;
            this.cboByYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboByYear.ForeColor = System.Drawing.Color.Black;
            this.cboByYear.FormattingEnabled = true;
            this.cboByYear.Items.AddRange(new object[] {
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.cboByYear.Location = new System.Drawing.Point(490, 113);
            this.cboByYear.Name = "cboByYear";
            this.cboByYear.Size = new System.Drawing.Size(72, 24);
            this.cboByYear.TabIndex = 12;
            // 
            // qryProductionReportTableAdapter
            // 
            this.qryProductionReportTableAdapter.ClearBeforeFill = true;
            // 
            // frmProductionReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 828);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rptViewerProduct);
            this.Name = "frmProductionReports";
            this.Text = "Production Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProductionReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qryProductionReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductionReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLotsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLotsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOperatorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperators)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewerProduct;
        private System.Windows.Forms.BindingSource qryProductionReportBindingSource;
        private dsProductionReport dsProductionReport;
        private CenterFireBulletWeighing.dsProductionReportTableAdapters.qryProductionReportTableAdapter qryProductionReportTableAdapter;
        private System.Windows.Forms.ComboBox cboProductID;
        private System.Windows.Forms.BindingSource dsProductsBindingSource;
        private dsProducts dsProducts;
        private System.Windows.Forms.BindingSource tblProductsBindingSource;
        private CenterFireBulletWeighing.dsProductsTableAdapters.tblProductsTableAdapter tblProductsTableAdapter;
        private System.Windows.Forms.ComboBox cboLot;
        private dsLots dsLots;
        private System.Windows.Forms.BindingSource tblLotsBindingSource;
        private CenterFireBulletWeighing.dsLotsTableAdapters.tblLotsTableAdapter tblLotsTableAdapter;
        private System.Windows.Forms.Button btnByProduct;
        private System.Windows.Forms.Button btnByLot;
        private System.Windows.Forms.Button btnByOperator;
        private System.Windows.Forms.ComboBox cboOperator;
        private dsOperators dsOperators;
        private System.Windows.Forms.BindingSource tblOperatorsBindingSource;
        private CenterFireBulletWeighing.dsOperatorsTableAdapters.tblOperatorsTableAdapter tblOperatorsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboByYear;
        private System.Windows.Forms.Button btnByYear;
        private System.Windows.Forms.BindingSource tblLotsBindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPickDate;
        private System.Windows.Forms.Button btnFilterByDay;
    }
}