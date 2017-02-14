namespace CenterFireBulletWeighing
{
    partial class frmCBWMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCBWMainMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.picMainMenu = new System.Windows.Forms.PictureBox();
            this.pnlLoadProduct = new System.Windows.Forms.Panel();
            this.cboLotWgt = new System.Windows.Forms.ComboBox();
            this.pnlPause = new System.Windows.Forms.Panel();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblLotSelection = new System.Windows.Forms.Label();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.lstActivePause = new System.Windows.Forms.ListBox();
            this.lstPauseSelection = new System.Windows.Forms.ListBox();
            this.tblLotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLots = new CenterFireBulletWeighing.dsLots();
            this.btnStartPausing = new System.Windows.Forms.Button();
            this.lblPauseSelectionTitle = new System.Windows.Forms.Label();
            this.lblPauseTime = new System.Windows.Forms.Label();
            this.lblPauseLabel = new System.Windows.Forms.Label();
            this.btnResume = new System.Windows.Forms.Button();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtAvgCoreWgt = new System.Windows.Forms.TextBox();
            this.lblAvgCoreWgt = new System.Windows.Forms.Label();
            this.lblCoreWeight = new System.Windows.Forms.Label();
            this.btnDoneAdding = new System.Windows.Forms.Button();
            this.dtPlatingStartTime = new System.Windows.Forms.DateTimePicker();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.cboBarrel = new System.Windows.Forms.ComboBox();
            this.cboPlaterPosition = new System.Windows.Forms.ComboBox();
            this.dtPlatingStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblLoadDate = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.tblProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProducts = new CenterFireBulletWeighing.dsProducts();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoadTitle = new System.Windows.Forms.Label();
            this.txtLotNumber = new System.Windows.Forms.TextBox();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.tblOperatorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsOperatorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOperators = new CenterFireBulletWeighing.dsOperators();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.lblLotNumber = new System.Windows.Forms.Label();
            this.lblPlatingBarrelLabel = new System.Windows.Forms.Label();
            this.lblPlaterPositionLabel = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.tblOperatorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centerfirebulletweighingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadProduct = new System.Windows.Forms.Button();
            this.btnPerformCheck = new System.Windows.Forms.Button();
            this.btnDBA = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tblOperatorsTableAdapter = new CenterFireBulletWeighing.dsOperatorsTableAdapters.tblOperatorsTableAdapter();
            this.tblLotsTableAdapter = new CenterFireBulletWeighing.dsLotsTableAdapters.tblLotsTableAdapter();
            this.tblProductsTableAdapter = new CenterFireBulletWeighing.dsProductsTableAdapters.tblProductsTableAdapter();
            this.btnProductionReport = new System.Windows.Forms.Button();
            this.btnPlatingStatus = new System.Windows.Forms.Button();
            this.pnlLoadSlip = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loadslipCheckDateTime = new System.Windows.Forms.Label();
            this.loadslipEstimatedCompletion = new System.Windows.Forms.Label();
            this.loadslipPieces = new System.Windows.Forms.Label();
            this.loadslipCoreAvgWgt = new System.Windows.Forms.Label();
            this.loadslipLoadTime = new System.Windows.Forms.Label();
            this.loadslipPosition = new System.Windows.Forms.Label();
            this.loadslipBarrel = new System.Windows.Forms.Label();
            this.loadslipPiecesLabel = new System.Windows.Forms.Label();
            this.loadslipCoreAvgWeightLabel = new System.Windows.Forms.Label();
            this.loadslipLoadTimeLabel = new System.Windows.Forms.Label();
            this.loadslipPositionLabel = new System.Windows.Forms.Label();
            this.loadslipBarrelLabel = new System.Windows.Forms.Label();
            this.loadslipOperator = new System.Windows.Forms.Label();
            this.loadslipOperatorLabel = new System.Windows.Forms.Label();
            this.loadslipProduct = new System.Windows.Forms.Label();
            this.loadslipProductLabel = new System.Windows.Forms.Label();
            this.loadslipLotNumber = new System.Windows.Forms.Label();
            this.loadslipLotNumberLabel = new System.Windows.Forms.Label();
            this.loadslipTitle = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnScrapLot = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.pnlScrap = new System.Windows.Forms.Panel();
            this.btnExitScrap = new System.Windows.Forms.Button();
            this.btnScraptheLot = new System.Windows.Forms.Button();
            this.lblScrapLot = new System.Windows.Forms.Label();
            this.cboLotToScrap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dsLotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.centerfirebulletweighingDataSet = new CenterFireBulletWeighing.dsFillByActiveLots();
            this.timerPause = new System.Windows.Forms.Timer(this.components);
            this.btnEditLot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).BeginInit();
            this.pnlLoadProduct.SuspendLayout();
            this.pnlPause.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLotsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOperatorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperatorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOperatorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerfirebulletweighingDataSetBindingSource)).BeginInit();
            this.pnlLoadSlip.SuspendLayout();
            this.pnlScrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerfirebulletweighingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(143, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(667, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Centerfire Bullet Weighing System";
            // 
            // picMainMenu
            // 
            this.picMainMenu.Image = global::CenterFireBulletWeighing.Properties.Resources.mycomputer;
            this.picMainMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMainMenu.InitialImage")));
            this.picMainMenu.Location = new System.Drawing.Point(19, 8);
            this.picMainMenu.Name = "picMainMenu";
            this.picMainMenu.Size = new System.Drawing.Size(118, 130);
            this.picMainMenu.TabIndex = 1;
            this.picMainMenu.TabStop = false;
            // 
            // pnlLoadProduct
            // 
            this.pnlLoadProduct.BackColor = System.Drawing.Color.LightGray;
            this.pnlLoadProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLoadProduct.Controls.Add(this.cboLotWgt);
            this.pnlLoadProduct.Controls.Add(this.txtAvgCoreWgt);
            this.pnlLoadProduct.Controls.Add(this.lblAvgCoreWgt);
            this.pnlLoadProduct.Controls.Add(this.lblCoreWeight);
            this.pnlLoadProduct.Controls.Add(this.btnDoneAdding);
            this.pnlLoadProduct.Controls.Add(this.dtPlatingStartTime);
            this.pnlLoadProduct.Controls.Add(this.btnResetForm);
            this.pnlLoadProduct.Controls.Add(this.cboBarrel);
            this.pnlLoadProduct.Controls.Add(this.cboPlaterPosition);
            this.pnlLoadProduct.Controls.Add(this.dtPlatingStartDate);
            this.pnlLoadProduct.Controls.Add(this.lblLoadDate);
            this.pnlLoadProduct.Controls.Add(this.cboProduct);
            this.pnlLoadProduct.Controls.Add(this.panel1);
            this.pnlLoadProduct.Controls.Add(this.lblLoadTitle);
            this.pnlLoadProduct.Controls.Add(this.txtLotNumber);
            this.pnlLoadProduct.Controls.Add(this.cboOperator);
            this.pnlLoadProduct.Controls.Add(this.btnAddRecord);
            this.pnlLoadProduct.Controls.Add(this.lblLotNumber);
            this.pnlLoadProduct.Controls.Add(this.lblPlatingBarrelLabel);
            this.pnlLoadProduct.Controls.Add(this.lblPlaterPositionLabel);
            this.pnlLoadProduct.Controls.Add(this.lblProduct);
            this.pnlLoadProduct.Controls.Add(this.lblOperator);
            this.pnlLoadProduct.Location = new System.Drawing.Point(195, 103);
            this.pnlLoadProduct.Margin = new System.Windows.Forms.Padding(5);
            this.pnlLoadProduct.Name = "pnlLoadProduct";
            this.pnlLoadProduct.Padding = new System.Windows.Forms.Padding(10);
            this.pnlLoadProduct.Size = new System.Drawing.Size(519, 502);
            this.pnlLoadProduct.TabIndex = 2;
            this.pnlLoadProduct.Visible = false;
            // 
            // cboLotWgt
            // 
            this.cboLotWgt.FormattingEnabled = true;
            this.cboLotWgt.Items.AddRange(new object[] {
            "240",
            "275",
            "300",
            "325",
            "350"});
            this.cboLotWgt.Location = new System.Drawing.Point(266, 281);
            this.cboLotWgt.Name = "cboLotWgt";
            this.cboLotWgt.Size = new System.Drawing.Size(106, 29);
            this.cboLotWgt.TabIndex = 11;
            // 
            // pnlPause
            // 
            this.pnlPause.BackColor = System.Drawing.Color.IndianRed;
            this.pnlPause.Controls.Add(this.lblSelected);
            this.pnlPause.Controls.Add(this.lblLotSelection);
            this.pnlPause.Controls.Add(this.btnSelectAll);
            this.pnlPause.Controls.Add(this.lstActivePause);
            this.pnlPause.Controls.Add(this.lstPauseSelection);
            this.pnlPause.Controls.Add(this.btnStartPausing);
            this.pnlPause.Controls.Add(this.lblPauseSelectionTitle);
            this.pnlPause.Controls.Add(this.lblPauseTime);
            this.pnlPause.Controls.Add(this.lblPauseLabel);
            this.pnlPause.Controls.Add(this.btnResume);
            this.pnlPause.Controls.Add(this.shapeContainer3);
            this.pnlPause.Location = new System.Drawing.Point(180, 149);
            this.pnlPause.Name = "pnlPause";
            this.pnlPause.Size = new System.Drawing.Size(359, 502);
            this.pnlPause.TabIndex = 28;
            this.pnlPause.Visible = false;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.ForeColor = System.Drawing.Color.White;
            this.lblSelected.Location = new System.Drawing.Point(214, 50);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(136, 22);
            this.lblSelected.TabIndex = 15;
            this.lblSelected.Text = "Selected Lots";
            // 
            // lblLotSelection
            // 
            this.lblLotSelection.AutoSize = true;
            this.lblLotSelection.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotSelection.ForeColor = System.Drawing.Color.White;
            this.lblLotSelection.Location = new System.Drawing.Point(20, 50);
            this.lblLotSelection.Name = "lblLotSelection";
            this.lblLotSelection.Size = new System.Drawing.Size(199, 22);
            this.lblLotSelection.TabIndex = 14;
            this.lblLotSelection.Text = "Select Lots to Pause";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(23, 71);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(155, 27);
            this.btnSelectAll.TabIndex = 13;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // lstActivePause
            // 
            this.lstActivePause.FormattingEnabled = true;
            this.lstActivePause.ItemHeight = 21;
            this.lstActivePause.Location = new System.Drawing.Point(201, 71);
            this.lstActivePause.Name = "lstActivePause";
            this.lstActivePause.Size = new System.Drawing.Size(135, 277);
            this.lstActivePause.TabIndex = 11;
            this.lstActivePause.DoubleClick += new System.EventHandler(this.RemoveLot);
            // 
            // lstPauseSelection
            // 
            this.lstPauseSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstPauseSelection.DataSource = this.tblLotsBindingSource;
            this.lstPauseSelection.DisplayMember = "lot_ID";
            this.lstPauseSelection.FormattingEnabled = true;
            this.lstPauseSelection.ItemHeight = 21;
            this.lstPauseSelection.Location = new System.Drawing.Point(23, 100);
            this.lstPauseSelection.Name = "lstPauseSelection";
            this.lstPauseSelection.Size = new System.Drawing.Size(155, 256);
            this.lstPauseSelection.TabIndex = 10;
            this.lstPauseSelection.ValueMember = "lot_ID";
            this.lstPauseSelection.DoubleClick += new System.EventHandler(this.fillActivePauseListBox);
            // 
            // tblLotsBindingSource
            // 
            this.tblLotsBindingSource.DataMember = "tblLots";
            this.tblLotsBindingSource.DataSource = this.dsLots;
            // 
            // dsLots
            // 
            this.dsLots.DataSetName = "dsLots";
            this.dsLots.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnStartPausing
            // 
            this.btnStartPausing.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPausing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartPausing.Location = new System.Drawing.Point(23, 375);
            this.btnStartPausing.Name = "btnStartPausing";
            this.btnStartPausing.Size = new System.Drawing.Size(155, 62);
            this.btnStartPausing.TabIndex = 9;
            this.btnStartPausing.Text = "Start";
            this.btnStartPausing.UseVisualStyleBackColor = true;
            this.btnStartPausing.Click += new System.EventHandler(this.btnStartPausing_Click);
            // 
            // lblPauseSelectionTitle
            // 
            this.lblPauseSelectionTitle.AutoSize = true;
            this.lblPauseSelectionTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPauseSelectionTitle.ForeColor = System.Drawing.Color.White;
            this.lblPauseSelectionTitle.Location = new System.Drawing.Point(11, 4);
            this.lblPauseSelectionTitle.Name = "lblPauseSelectionTitle";
            this.lblPauseSelectionTitle.Size = new System.Drawing.Size(253, 32);
            this.lblPauseSelectionTitle.TabIndex = 8;
            this.lblPauseSelectionTitle.Text = "Lot Pause Control";
            // 
            // lblPauseTime
            // 
            this.lblPauseTime.AutoSize = true;
            this.lblPauseTime.BackColor = System.Drawing.Color.Snow;
            this.lblPauseTime.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPauseTime.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPauseTime.Location = new System.Drawing.Point(172, 454);
            this.lblPauseTime.Name = "lblPauseTime";
            this.lblPauseTime.Size = new System.Drawing.Size(41, 45);
            this.lblPauseTime.TabIndex = 4;
            this.lblPauseTime.Text = "0";
            // 
            // lblPauseLabel
            // 
            this.lblPauseLabel.AutoSize = true;
            this.lblPauseLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPauseLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPauseLabel.Location = new System.Drawing.Point(103, 460);
            this.lblPauseLabel.Name = "lblPauseLabel";
            this.lblPauseLabel.Size = new System.Drawing.Size(76, 29);
            this.lblPauseLabel.TabIndex = 3;
            this.lblPauseLabel.Text = "Time:";
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResume.Location = new System.Drawing.Point(201, 375);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(135, 62);
            this.btnResume.TabIndex = 0;
            this.btnResume.Text = "Stop/Exit";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4});
            this.shapeContainer3.Size = new System.Drawing.Size(359, 502);
            this.shapeContainer3.TabIndex = 12;
            this.shapeContainer3.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.White;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 19;
            this.lineShape4.X2 = 311;
            this.lineShape4.Y1 = 36;
            this.lineShape4.Y2 = 36;
            // 
            // txtAvgCoreWgt
            // 
            this.txtAvgCoreWgt.Location = new System.Drawing.Point(266, 238);
            this.txtAvgCoreWgt.Name = "txtAvgCoreWgt";
            this.txtAvgCoreWgt.Size = new System.Drawing.Size(107, 29);
            this.txtAvgCoreWgt.TabIndex = 10;
            // 
            // lblAvgCoreWgt
            // 
            this.lblAvgCoreWgt.AutoSize = true;
            this.lblAvgCoreWgt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgCoreWgt.Location = new System.Drawing.Point(14, 241);
            this.lblAvgCoreWgt.Name = "lblAvgCoreWgt";
            this.lblAvgCoreWgt.Size = new System.Drawing.Size(223, 23);
            this.lblAvgCoreWgt.TabIndex = 34;
            this.lblAvgCoreWgt.Text = "Enter Avg. Core Weight:";
            this.lblAvgCoreWgt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCoreWeight
            // 
            this.lblCoreWeight.AutoSize = true;
            this.lblCoreWeight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoreWeight.Location = new System.Drawing.Point(73, 284);
            this.lblCoreWeight.Name = "lblCoreWeight";
            this.lblCoreWeight.Size = new System.Drawing.Size(164, 23);
            this.lblCoreWeight.TabIndex = 33;
            this.lblCoreWeight.Text = "Enter Lot Weight:";
            this.lblCoreWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDoneAdding
            // 
            this.btnDoneAdding.BackColor = System.Drawing.Color.IndianRed;
            this.btnDoneAdding.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneAdding.ForeColor = System.Drawing.Color.White;
            this.btnDoneAdding.Location = new System.Drawing.Point(410, 456);
            this.btnDoneAdding.Name = "btnDoneAdding";
            this.btnDoneAdding.Size = new System.Drawing.Size(83, 31);
            this.btnDoneAdding.TabIndex = 15;
            this.btnDoneAdding.Text = "Cancel";
            this.btnDoneAdding.UseVisualStyleBackColor = false;
            this.btnDoneAdding.Click += new System.EventHandler(this.btnDoneAdding_Click);
            // 
            // dtPlatingStartTime
            // 
            this.dtPlatingStartTime.CustomFormat = "HH:mm";
            this.dtPlatingStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPlatingStartTime.Location = new System.Drawing.Point(387, 106);
            this.dtPlatingStartTime.MaxDate = new System.DateTime(2048, 6, 24, 0, 0, 0, 0);
            this.dtPlatingStartTime.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtPlatingStartTime.Name = "dtPlatingStartTime";
            this.dtPlatingStartTime.ShowUpDown = true;
            this.dtPlatingStartTime.Size = new System.Drawing.Size(75, 29);
            this.dtPlatingStartTime.TabIndex = 7;
            // 
            // btnResetForm
            // 
            this.btnResetForm.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.Location = new System.Drawing.Point(321, 456);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(83, 31);
            this.btnResetForm.TabIndex = 16;
            this.btnResetForm.TabStop = false;
            this.btnResetForm.Text = "Clear";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // cboBarrel
            // 
            this.cboBarrel.FormattingEnabled = true;
            this.cboBarrel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cboBarrel.Location = new System.Drawing.Point(266, 324);
            this.cboBarrel.Name = "cboBarrel";
            this.cboBarrel.Size = new System.Drawing.Size(54, 29);
            this.cboBarrel.TabIndex = 12;
            // 
            // cboPlaterPosition
            // 
            this.cboPlaterPosition.FormattingEnabled = true;
            this.cboPlaterPosition.Location = new System.Drawing.Point(266, 367);
            this.cboPlaterPosition.Name = "cboPlaterPosition";
            this.cboPlaterPosition.Size = new System.Drawing.Size(54, 29);
            this.cboPlaterPosition.TabIndex = 13;
            // 
            // dtPlatingStartDate
            // 
            this.dtPlatingStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPlatingStartDate.Location = new System.Drawing.Point(266, 106);
            this.dtPlatingStartDate.MaxDate = new System.DateTime(2048, 6, 24, 0, 0, 0, 0);
            this.dtPlatingStartDate.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtPlatingStartDate.Name = "dtPlatingStartDate";
            this.dtPlatingStartDate.Size = new System.Drawing.Size(115, 29);
            this.dtPlatingStartDate.TabIndex = 6;
            // 
            // lblLoadDate
            // 
            this.lblLoadDate.AutoSize = true;
            this.lblLoadDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadDate.Location = new System.Drawing.Point(81, 112);
            this.lblLoadDate.Name = "lblLoadDate";
            this.lblLoadDate.Size = new System.Drawing.Size(156, 23);
            this.lblLoadDate.TabIndex = 22;
            this.lblLoadDate.Text = "Load Date/Time:";
            this.lblLoadDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboProduct
            // 
            this.cboProduct.DataSource = this.tblProductsBindingSource;
            this.cboProduct.DisplayMember = "product_ID";
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(266, 195);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(196, 29);
            this.cboProduct.TabIndex = 9;
            this.cboProduct.ValueMember = "product_ID";
            this.cboProduct.SelectedIndexChanged += new System.EventHandler(this.cboProduct_SelectedIndexChanged);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(18, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 1);
            this.panel1.TabIndex = 20;
            // 
            // lblLoadTitle
            // 
            this.lblLoadTitle.AutoSize = true;
            this.lblLoadTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadTitle.ForeColor = System.Drawing.Color.Black;
            this.lblLoadTitle.Location = new System.Drawing.Point(19, 13);
            this.lblLoadTitle.Name = "lblLoadTitle";
            this.lblLoadTitle.Size = new System.Drawing.Size(84, 24);
            this.lblLoadTitle.TabIndex = 12;
            this.lblLoadTitle.Text = "Add Lot";
            // 
            // txtLotNumber
            // 
            this.txtLotNumber.Location = new System.Drawing.Point(266, 63);
            this.txtLotNumber.Name = "txtLotNumber";
            this.txtLotNumber.Size = new System.Drawing.Size(107, 29);
            this.txtLotNumber.TabIndex = 5;
            this.txtLotNumber.LostFocus += new System.EventHandler(this.txtLotNumber_LostFocus);
            // 
            // cboOperator
            // 
            this.cboOperator.DataSource = this.tblOperatorsBindingSource1;
            this.cboOperator.DisplayMember = "operator_Name";
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Location = new System.Drawing.Point(266, 152);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(196, 29);
            this.cboOperator.TabIndex = 8;
            this.cboOperator.ValueMember = "operator_ID";
            // 
            // tblOperatorsBindingSource1
            // 
            this.tblOperatorsBindingSource1.DataMember = "tblOperators";
            this.tblOperatorsBindingSource1.DataSource = this.dsOperatorsBindingSource;
            // 
            // dsOperatorsBindingSource
            // 
            this.dsOperatorsBindingSource.DataSource = this.dsOperators;
            this.dsOperatorsBindingSource.Position = 0;
            // 
            // dsOperators
            // 
            this.dsOperators.DataSetName = "dsOperators";
            this.dsOperators.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRecord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.Location = new System.Drawing.Point(18, 412);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(475, 38);
            this.btnAddRecord.TabIndex = 14;
            this.btnAddRecord.Text = "ADD LOT";
            this.btnAddRecord.UseVisualStyleBackColor = false;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // lblLotNumber
            // 
            this.lblLotNumber.AutoSize = true;
            this.lblLotNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotNumber.Location = new System.Drawing.Point(78, 69);
            this.lblLotNumber.Name = "lblLotNumber";
            this.lblLotNumber.Size = new System.Drawing.Size(159, 23);
            this.lblLotNumber.TabIndex = 7;
            this.lblLotNumber.Text = "Enter New Lot #:";
            this.lblLotNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlatingBarrelLabel
            // 
            this.lblPlatingBarrelLabel.AutoSize = true;
            this.lblPlatingBarrelLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatingBarrelLabel.Location = new System.Drawing.Point(103, 327);
            this.lblPlatingBarrelLabel.Name = "lblPlatingBarrelLabel";
            this.lblPlatingBarrelLabel.Size = new System.Drawing.Size(134, 23);
            this.lblPlatingBarrelLabel.TabIndex = 4;
            this.lblPlatingBarrelLabel.Text = "Plating Barrel:";
            this.lblPlatingBarrelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlaterPositionLabel
            // 
            this.lblPlaterPositionLabel.AutoSize = true;
            this.lblPlaterPositionLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaterPositionLabel.Location = new System.Drawing.Point(94, 370);
            this.lblPlaterPositionLabel.Name = "lblPlaterPositionLabel";
            this.lblPlaterPositionLabel.Size = new System.Drawing.Size(143, 23);
            this.lblPlaterPositionLabel.TabIndex = 3;
            this.lblPlaterPositionLabel.Text = "Plater Position:";
            this.lblPlaterPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(92, 198);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(145, 23);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Select Product:";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(80, 155);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(157, 23);
            this.lblOperator.TabIndex = 0;
            this.lblOperator.Text = "Select Operator:";
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tblOperatorsBindingSource
            // 
            this.tblOperatorsBindingSource.DataMember = "tblOperators";
            this.tblOperatorsBindingSource.DataSource = this.dsOperators;
            // 
            // btnLoadProduct
            // 
            this.btnLoadProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadProduct.Location = new System.Drawing.Point(10, 149);
            this.btnLoadProduct.Name = "btnLoadProduct";
            this.btnLoadProduct.Size = new System.Drawing.Size(142, 68);
            this.btnLoadProduct.TabIndex = 0;
            this.btnLoadProduct.Text = "ADD";
            this.btnLoadProduct.UseVisualStyleBackColor = true;
            this.btnLoadProduct.Click += new System.EventHandler(this.btnLoadProduct_Click);
            // 
            // btnPerformCheck
            // 
            this.btnPerformCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerformCheck.Location = new System.Drawing.Point(10, 298);
            this.btnPerformCheck.Name = "btnPerformCheck";
            this.btnPerformCheck.Size = new System.Drawing.Size(142, 68);
            this.btnPerformCheck.TabIndex = 1;
            this.btnPerformCheck.Text = "CHECK";
            this.btnPerformCheck.UseVisualStyleBackColor = true;
            this.btnPerformCheck.Click += new System.EventHandler(this.btnPerformCheck_Click);
            // 
            // btnDBA
            // 
            this.btnDBA.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBA.Location = new System.Drawing.Point(30, 525);
            this.btnDBA.Name = "btnDBA";
            this.btnDBA.Size = new System.Drawing.Size(122, 33);
            this.btnDBA.TabIndex = 3;
            this.btnDBA.Text = "Edit Other";
            this.btnDBA.UseVisualStyleBackColor = true;
            this.btnDBA.Click += new System.EventHandler(this.btnDBA_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(10, 649);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 59);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tblOperatorsTableAdapter
            // 
            this.tblOperatorsTableAdapter.ClearBeforeFill = true;
            // 
            // tblLotsTableAdapter
            // 
            this.tblLotsTableAdapter.ClearBeforeFill = true;
            // 
            // tblProductsTableAdapter
            // 
            this.tblProductsTableAdapter.ClearBeforeFill = true;
            // 
            // btnProductionReport
            // 
            this.btnProductionReport.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductionReport.Location = new System.Drawing.Point(30, 427);
            this.btnProductionReport.Name = "btnProductionReport";
            this.btnProductionReport.Size = new System.Drawing.Size(122, 33);
            this.btnProductionReport.TabIndex = 23;
            this.btnProductionReport.Text = "Reports";
            this.btnProductionReport.UseVisualStyleBackColor = true;
            this.btnProductionReport.Click += new System.EventHandler(this.btnProductionReport_Click);
            // 
            // btnPlatingStatus
            // 
            this.btnPlatingStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlatingStatus.Location = new System.Drawing.Point(30, 378);
            this.btnPlatingStatus.Name = "btnPlatingStatus";
            this.btnPlatingStatus.Size = new System.Drawing.Size(122, 33);
            this.btnPlatingStatus.TabIndex = 22;
            this.btnPlatingStatus.Text = "Status";
            this.btnPlatingStatus.UseVisualStyleBackColor = true;
            this.btnPlatingStatus.Click += new System.EventHandler(this.btnPlatingStatus_Click);
            // 
            // pnlLoadSlip
            // 
            this.pnlLoadSlip.BackColor = System.Drawing.Color.White;
            this.pnlLoadSlip.Controls.Add(this.label4);
            this.pnlLoadSlip.Controls.Add(this.label3);
            this.pnlLoadSlip.Controls.Add(this.loadslipCheckDateTime);
            this.pnlLoadSlip.Controls.Add(this.loadslipEstimatedCompletion);
            this.pnlLoadSlip.Controls.Add(this.loadslipPieces);
            this.pnlLoadSlip.Controls.Add(this.loadslipCoreAvgWgt);
            this.pnlLoadSlip.Controls.Add(this.loadslipLoadTime);
            this.pnlLoadSlip.Controls.Add(this.loadslipPosition);
            this.pnlLoadSlip.Controls.Add(this.loadslipBarrel);
            this.pnlLoadSlip.Controls.Add(this.loadslipPiecesLabel);
            this.pnlLoadSlip.Controls.Add(this.loadslipCoreAvgWeightLabel);
            this.pnlLoadSlip.Controls.Add(this.loadslipLoadTimeLabel);
            this.pnlLoadSlip.Controls.Add(this.loadslipPositionLabel);
            this.pnlLoadSlip.Controls.Add(this.loadslipBarrelLabel);
            this.pnlLoadSlip.Controls.Add(this.loadslipOperator);
            this.pnlLoadSlip.Controls.Add(this.loadslipOperatorLabel);
            this.pnlLoadSlip.Controls.Add(this.loadslipProduct);
            this.pnlLoadSlip.Controls.Add(this.loadslipProductLabel);
            this.pnlLoadSlip.Controls.Add(this.loadslipLotNumber);
            this.pnlLoadSlip.Controls.Add(this.loadslipLotNumberLabel);
            this.pnlLoadSlip.Controls.Add(this.loadslipTitle);
            this.pnlLoadSlip.Controls.Add(this.shapeContainer1);
            this.pnlLoadSlip.Location = new System.Drawing.Point(583, 93);
            this.pnlLoadSlip.Name = "pnlLoadSlip";
            this.pnlLoadSlip.Size = new System.Drawing.Size(402, 367);
            this.pnlLoadSlip.TabIndex = 6;
            this.pnlLoadSlip.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Est. Finish:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Check:";
            // 
            // loadslipCheckDateTime
            // 
            this.loadslipCheckDateTime.AutoSize = true;
            this.loadslipCheckDateTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipCheckDateTime.Location = new System.Drawing.Point(151, 274);
            this.loadslipCheckDateTime.Name = "loadslipCheckDateTime";
            this.loadslipCheckDateTime.Size = new System.Drawing.Size(192, 19);
            this.loadslipCheckDateTime.TabIndex = 19;
            this.loadslipCheckDateTime.Text = "dd MMM yyyy    HH:mm";
            // 
            // loadslipEstimatedCompletion
            // 
            this.loadslipEstimatedCompletion.AutoSize = true;
            this.loadslipEstimatedCompletion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipEstimatedCompletion.Location = new System.Drawing.Point(151, 293);
            this.loadslipEstimatedCompletion.Name = "loadslipEstimatedCompletion";
            this.loadslipEstimatedCompletion.Size = new System.Drawing.Size(192, 19);
            this.loadslipEstimatedCompletion.TabIndex = 0;
            this.loadslipEstimatedCompletion.Text = "dd MMM yyyy    HH:mm";
            // 
            // loadslipPieces
            // 
            this.loadslipPieces.AutoSize = true;
            this.loadslipPieces.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipPieces.Location = new System.Drawing.Point(168, 218);
            this.loadslipPieces.Name = "loadslipPieces";
            this.loadslipPieces.Size = new System.Drawing.Size(45, 19);
            this.loadslipPieces.TabIndex = 18;
            this.loadslipPieces.Text = "0000";
            // 
            // loadslipCoreAvgWgt
            // 
            this.loadslipCoreAvgWgt.AutoSize = true;
            this.loadslipCoreAvgWgt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipCoreAvgWgt.Location = new System.Drawing.Point(168, 195);
            this.loadslipCoreAvgWgt.Name = "loadslipCoreAvgWgt";
            this.loadslipCoreAvgWgt.Size = new System.Drawing.Size(59, 19);
            this.loadslipCoreAvgWgt.TabIndex = 17;
            this.loadslipCoreAvgWgt.Text = "000.00";
            // 
            // loadslipLoadTime
            // 
            this.loadslipLoadTime.AutoSize = true;
            this.loadslipLoadTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipLoadTime.Location = new System.Drawing.Point(168, 172);
            this.loadslipLoadTime.Name = "loadslipLoadTime";
            this.loadslipLoadTime.Size = new System.Drawing.Size(97, 19);
            this.loadslipLoadTime.TabIndex = 16;
            this.loadslipLoadTime.Text = "XXXXXXXX";
            // 
            // loadslipPosition
            // 
            this.loadslipPosition.AutoSize = true;
            this.loadslipPosition.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipPosition.Location = new System.Drawing.Point(168, 149);
            this.loadslipPosition.Name = "loadslipPosition";
            this.loadslipPosition.Size = new System.Drawing.Size(27, 19);
            this.loadslipPosition.TabIndex = 15;
            this.loadslipPosition.Text = "00";
            // 
            // loadslipBarrel
            // 
            this.loadslipBarrel.AutoSize = true;
            this.loadslipBarrel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipBarrel.Location = new System.Drawing.Point(168, 126);
            this.loadslipBarrel.Name = "loadslipBarrel";
            this.loadslipBarrel.Size = new System.Drawing.Size(27, 19);
            this.loadslipBarrel.TabIndex = 14;
            this.loadslipBarrel.Text = "00";
            // 
            // loadslipPiecesLabel
            // 
            this.loadslipPiecesLabel.AutoSize = true;
            this.loadslipPiecesLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipPiecesLabel.Location = new System.Drawing.Point(87, 218);
            this.loadslipPiecesLabel.Name = "loadslipPiecesLabel";
            this.loadslipPiecesLabel.Size = new System.Drawing.Size(64, 19);
            this.loadslipPiecesLabel.TabIndex = 13;
            this.loadslipPiecesLabel.Text = "Pieces:";
            // 
            // loadslipCoreAvgWeightLabel
            // 
            this.loadslipCoreAvgWeightLabel.AutoSize = true;
            this.loadslipCoreAvgWeightLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipCoreAvgWeightLabel.Location = new System.Drawing.Point(35, 195);
            this.loadslipCoreAvgWeightLabel.Name = "loadslipCoreAvgWeightLabel";
            this.loadslipCoreAvgWeightLabel.Size = new System.Drawing.Size(116, 19);
            this.loadslipCoreAvgWeightLabel.TabIndex = 12;
            this.loadslipCoreAvgWeightLabel.Text = "Core Avg Wgt:";
            // 
            // loadslipLoadTimeLabel
            // 
            this.loadslipLoadTimeLabel.AutoSize = true;
            this.loadslipLoadTimeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipLoadTimeLabel.Location = new System.Drawing.Point(62, 172);
            this.loadslipLoadTimeLabel.Name = "loadslipLoadTimeLabel";
            this.loadslipLoadTimeLabel.Size = new System.Drawing.Size(89, 19);
            this.loadslipLoadTimeLabel.TabIndex = 10;
            this.loadslipLoadTimeLabel.Text = "Load Time:";
            // 
            // loadslipPositionLabel
            // 
            this.loadslipPositionLabel.AutoSize = true;
            this.loadslipPositionLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipPositionLabel.Location = new System.Drawing.Point(79, 149);
            this.loadslipPositionLabel.Name = "loadslipPositionLabel";
            this.loadslipPositionLabel.Size = new System.Drawing.Size(72, 19);
            this.loadslipPositionLabel.TabIndex = 9;
            this.loadslipPositionLabel.Text = "Position:";
            // 
            // loadslipBarrelLabel
            // 
            this.loadslipBarrelLabel.AutoSize = true;
            this.loadslipBarrelLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipBarrelLabel.Location = new System.Drawing.Point(93, 126);
            this.loadslipBarrelLabel.Name = "loadslipBarrelLabel";
            this.loadslipBarrelLabel.Size = new System.Drawing.Size(58, 19);
            this.loadslipBarrelLabel.TabIndex = 8;
            this.loadslipBarrelLabel.Text = "Barrel:";
            // 
            // loadslipOperator
            // 
            this.loadslipOperator.AutoSize = true;
            this.loadslipOperator.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipOperator.Location = new System.Drawing.Point(168, 103);
            this.loadslipOperator.Name = "loadslipOperator";
            this.loadslipOperator.Size = new System.Drawing.Size(97, 19);
            this.loadslipOperator.TabIndex = 7;
            this.loadslipOperator.Text = "XXXXXXXX";
            // 
            // loadslipOperatorLabel
            // 
            this.loadslipOperatorLabel.AutoSize = true;
            this.loadslipOperatorLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipOperatorLabel.Location = new System.Drawing.Point(32, 103);
            this.loadslipOperatorLabel.Name = "loadslipOperatorLabel";
            this.loadslipOperatorLabel.Size = new System.Drawing.Size(119, 19);
            this.loadslipOperatorLabel.TabIndex = 6;
            this.loadslipOperatorLabel.Text = "Load Operator:";
            // 
            // loadslipProduct
            // 
            this.loadslipProduct.AutoSize = true;
            this.loadslipProduct.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipProduct.Location = new System.Drawing.Point(168, 80);
            this.loadslipProduct.Name = "loadslipProduct";
            this.loadslipProduct.Size = new System.Drawing.Size(80, 19);
            this.loadslipProduct.TabIndex = 5;
            this.loadslipProduct.Text = "XXX XXX";
            // 
            // loadslipProductLabel
            // 
            this.loadslipProductLabel.AutoSize = true;
            this.loadslipProductLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipProductLabel.Location = new System.Drawing.Point(80, 80);
            this.loadslipProductLabel.Name = "loadslipProductLabel";
            this.loadslipProductLabel.Size = new System.Drawing.Size(71, 19);
            this.loadslipProductLabel.TabIndex = 4;
            this.loadslipProductLabel.Text = "Product:";
            // 
            // loadslipLotNumber
            // 
            this.loadslipLotNumber.AutoSize = true;
            this.loadslipLotNumber.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipLotNumber.Location = new System.Drawing.Point(168, 57);
            this.loadslipLotNumber.Name = "loadslipLotNumber";
            this.loadslipLotNumber.Size = new System.Drawing.Size(45, 19);
            this.loadslipLotNumber.TabIndex = 3;
            this.loadslipLotNumber.Text = "0000";
            // 
            // loadslipLotNumberLabel
            // 
            this.loadslipLotNumberLabel.AutoSize = true;
            this.loadslipLotNumberLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipLotNumberLabel.Location = new System.Drawing.Point(53, 56);
            this.loadslipLotNumberLabel.Name = "loadslipLotNumberLabel";
            this.loadslipLotNumberLabel.Size = new System.Drawing.Size(98, 19);
            this.loadslipLotNumberLabel.TabIndex = 2;
            this.loadslipLotNumberLabel.Text = "Lot Number:";
            // 
            // loadslipTitle
            // 
            this.loadslipTitle.AutoSize = true;
            this.loadslipTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadslipTitle.Location = new System.Drawing.Point(26, 10);
            this.loadslipTitle.Name = "loadslipTitle";
            this.loadslipTitle.Size = new System.Drawing.Size(98, 24);
            this.loadslipTitle.TabIndex = 0;
            this.loadslipTitle.Text = "Load Slip";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(402, 367);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 10;
            this.lineShape2.X2 = 300;
            this.lineShape2.Y1 = 240;
            this.lineShape2.Y2 = 240;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 10;
            this.lineShape1.X2 = 300;
            this.lineShape1.Y1 = 40;
            this.lineShape1.Y2 = 40;
            // 
            // btnScrapLot
            // 
            this.btnScrapLot.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScrapLot.Location = new System.Drawing.Point(30, 225);
            this.btnScrapLot.Name = "btnScrapLot";
            this.btnScrapLot.Size = new System.Drawing.Size(122, 30);
            this.btnScrapLot.TabIndex = 24;
            this.btnScrapLot.Text = "Scrap";
            this.btnScrapLot.UseVisualStyleBackColor = true;
            this.btnScrapLot.Click += new System.EventHandler(this.btnScrapLot_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(10, 580);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(142, 49);
            this.btnBackup.TabIndex = 25;
            this.btnBackup.Text = "Backup DB";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // pnlScrap
            // 
            this.pnlScrap.BackColor = System.Drawing.Color.LightGray;
            this.pnlScrap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScrap.Controls.Add(this.btnExitScrap);
            this.pnlScrap.Controls.Add(this.btnScraptheLot);
            this.pnlScrap.Controls.Add(this.lblScrapLot);
            this.pnlScrap.Controls.Add(this.cboLotToScrap);
            this.pnlScrap.Controls.Add(this.label1);
            this.pnlScrap.Controls.Add(this.shapeContainer2);
            this.pnlScrap.Location = new System.Drawing.Point(180, 563);
            this.pnlScrap.Name = "pnlScrap";
            this.pnlScrap.Size = new System.Drawing.Size(519, 177);
            this.pnlScrap.TabIndex = 26;
            this.pnlScrap.Visible = false;
            // 
            // btnExitScrap
            // 
            this.btnExitScrap.BackColor = System.Drawing.Color.IndianRed;
            this.btnExitScrap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitScrap.ForeColor = System.Drawing.Color.White;
            this.btnExitScrap.Location = new System.Drawing.Point(433, 132);
            this.btnExitScrap.Name = "btnExitScrap";
            this.btnExitScrap.Size = new System.Drawing.Size(72, 31);
            this.btnExitScrap.TabIndex = 27;
            this.btnExitScrap.Text = "E&xit";
            this.btnExitScrap.UseVisualStyleBackColor = false;
            this.btnExitScrap.Click += new System.EventHandler(this.btnExitScrap_Click);
            // 
            // btnScraptheLot
            // 
            this.btnScraptheLot.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScraptheLot.Location = new System.Drawing.Point(37, 129);
            this.btnScraptheLot.Name = "btnScraptheLot";
            this.btnScraptheLot.Size = new System.Drawing.Size(372, 31);
            this.btnScraptheLot.TabIndex = 31;
            this.btnScraptheLot.Text = "Scrap Lot";
            this.btnScraptheLot.UseVisualStyleBackColor = true;
            this.btnScraptheLot.Click += new System.EventHandler(this.btnScraptheLot_Click);
            // 
            // lblScrapLot
            // 
            this.lblScrapLot.AutoSize = true;
            this.lblScrapLot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScrapLot.Location = new System.Drawing.Point(33, 81);
            this.lblScrapLot.Name = "lblScrapLot";
            this.lblScrapLot.Size = new System.Drawing.Size(186, 23);
            this.lblScrapLot.TabIndex = 30;
            this.lblScrapLot.Text = "Select Lot to Scrap:";
            this.lblScrapLot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboLotToScrap
            // 
            this.cboLotToScrap.DataSource = this.tblLotsBindingSource;
            this.cboLotToScrap.DisplayMember = "lot_ID";
            this.cboLotToScrap.FormattingEnabled = true;
            this.cboLotToScrap.Location = new System.Drawing.Point(225, 80);
            this.cboLotToScrap.Name = "cboLotToScrap";
            this.cboLotToScrap.Size = new System.Drawing.Size(184, 29);
            this.cboLotToScrap.TabIndex = 29;
            this.cboLotToScrap.ValueMember = "lot_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Scrap Lot";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3});
            this.shapeContainer2.Size = new System.Drawing.Size(517, 175);
            this.shapeContainer2.TabIndex = 28;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 14;
            this.lineShape3.X2 = 489;
            this.lineShape3.Y1 = 53;
            this.lineShape3.Y2 = 53;
            // 
            // dsLotsBindingSource
            // 
            this.dsLotsBindingSource.DataSource = this.dsLots;
            this.dsLotsBindingSource.Position = 0;
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(30, 258);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(122, 30);
            this.btnPause.TabIndex = 27;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.button1_Click);
            // 
            // centerfirebulletweighingDataSet
            // 
            this.centerfirebulletweighingDataSet.DataSetName = "centerfirebulletweighingDataSet";
            this.centerfirebulletweighingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timerPause
            // 
            this.timerPause.Interval = 1000;
            this.timerPause.Tick += new System.EventHandler(this.timerPause_Tick);
            // 
            // btnEditLot
            // 
            this.btnEditLot.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLot.Location = new System.Drawing.Point(31, 476);
            this.btnEditLot.Name = "btnEditLot";
            this.btnEditLot.Size = new System.Drawing.Size(121, 33);
            this.btnEditLot.TabIndex = 29;
            this.btnEditLot.Text = "Edit Lot";
            this.btnEditLot.UseVisualStyleBackColor = true;
            this.btnEditLot.Click += new System.EventHandler(this.btnEditLot_Click);
            // 
            // frmCBWMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(816, 734);
            this.Controls.Add(this.btnEditLot);
            this.Controls.Add(this.pnlPause);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.pnlScrap);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnScrapLot);
            this.Controls.Add(this.pnlLoadSlip);
            this.Controls.Add(this.btnProductionReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlatingStatus);
            this.Controls.Add(this.btnDBA);
            this.Controls.Add(this.btnPerformCheck);
            this.Controls.Add(this.btnLoadProduct);
            this.Controls.Add(this.pnlLoadProduct);
            this.Controls.Add(this.picMainMenu);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCBWMainMenu";
            this.Padding = new System.Windows.Forms.Padding(27);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centerfire Bullet Weighing System - Version 1.2 - July 2013";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCBWMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).EndInit();
            this.pnlLoadProduct.ResumeLayout(false);
            this.pnlLoadProduct.PerformLayout();
            this.pnlPause.ResumeLayout(false);
            this.pnlPause.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLotsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOperatorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperatorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOperatorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerfirebulletweighingDataSetBindingSource)).EndInit();
            this.pnlLoadSlip.ResumeLayout(false);
            this.pnlLoadSlip.PerformLayout();
            this.pnlScrap.ResumeLayout(false);
            this.pnlScrap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerfirebulletweighingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picMainMenu;
        private System.Windows.Forms.Panel pnlLoadProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Button btnLoadProduct;
        private System.Windows.Forms.Label lblPlatingBarrelLabel;
        private System.Windows.Forms.Label lblPlaterPositionLabel;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Label lblLotNumber;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.BindingSource centerfirebulletweighingDataSetBindingSource;
        private System.Windows.Forms.Button btnPerformCheck;
        private System.Windows.Forms.Button btnDBA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLoadTitle;
        private System.Windows.Forms.TextBox txtLotNumber;
        private System.Windows.Forms.Panel panel1;
        private dsOperators dsOperators;
        private System.Windows.Forms.BindingSource dsOperatorsBindingSource;
        private CenterFireBulletWeighing.dsOperatorsTableAdapters.tblOperatorsTableAdapter tblOperatorsTableAdapter;
        private System.Windows.Forms.BindingSource tblOperatorsBindingSource;
        private dsLots dsLots;
        private System.Windows.Forms.BindingSource tblLotsBindingSource;
        private CenterFireBulletWeighing.dsLotsTableAdapters.tblLotsTableAdapter tblLotsTableAdapter;
        private System.Windows.Forms.Label lblLoadDate;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.DateTimePicker dtPlatingStartDate;
        private System.Windows.Forms.BindingSource dsProductsBindingSource;
        private dsProducts dsProducts;
        private System.Windows.Forms.BindingSource tblProductsBindingSource;
        private CenterFireBulletWeighing.dsProductsTableAdapters.tblProductsTableAdapter tblProductsTableAdapter;
        private System.Windows.Forms.ComboBox cboPlaterPosition;
        private System.Windows.Forms.ComboBox cboBarrel;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.BindingSource tblOperatorsBindingSource1;
        private System.Windows.Forms.DateTimePicker dtPlatingStartTime;
        private System.Windows.Forms.Button btnDoneAdding;
        private System.Windows.Forms.Label lblCoreWeight;
        private System.Windows.Forms.Button btnPlatingStatus;
        private System.Windows.Forms.TextBox txtAvgCoreWgt;
        private System.Windows.Forms.Label lblAvgCoreWgt;
        private System.Windows.Forms.Button btnProductionReport;
        private System.Windows.Forms.Panel pnlLoadSlip;
        private System.Windows.Forms.Label loadslipLotNumberLabel;
        private System.Windows.Forms.Label loadslipTitle;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label loadslipLoadTimeLabel;
        private System.Windows.Forms.Label loadslipPositionLabel;
        private System.Windows.Forms.Label loadslipBarrelLabel;
        private System.Windows.Forms.Label loadslipOperator;
        private System.Windows.Forms.Label loadslipOperatorLabel;
        private System.Windows.Forms.Label loadslipProduct;
        private System.Windows.Forms.Label loadslipProductLabel;
        private System.Windows.Forms.Label loadslipLotNumber;
        private System.Windows.Forms.Label loadslipPieces;
        private System.Windows.Forms.Label loadslipCoreAvgWgt;
        private System.Windows.Forms.Label loadslipLoadTime;
        private System.Windows.Forms.Label loadslipPosition;
        private System.Windows.Forms.Label loadslipBarrel;
        private System.Windows.Forms.Label loadslipPiecesLabel;
        private System.Windows.Forms.Label loadslipCoreAvgWeightLabel;
        private System.Windows.Forms.Label loadslipCheckDateTime;
        private System.Windows.Forms.Label loadslipEstimatedCompletion;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLotWgt;
        private System.Windows.Forms.Button btnScrapLot;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Panel pnlScrap;
        private System.Windows.Forms.Label lblScrapLot;
        private System.Windows.Forms.ComboBox cboLotToScrap;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.BindingSource dsLotsBindingSource;
        private System.Windows.Forms.Button btnExitScrap;
        private System.Windows.Forms.Button btnScraptheLot;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Panel pnlPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Label lblPauseLabel;
        private System.Windows.Forms.Label lblPauseTime;
        private System.Windows.Forms.Timer timerPause;
        private System.Windows.Forms.Label lblPauseSelectionTitle;
        private System.Windows.Forms.Button btnEditLot;
        private System.Windows.Forms.Button btnStartPausing;
        private System.Windows.Forms.ListBox lstPauseSelection;
        private dsFillByActiveLots centerfirebulletweighingDataSet;
        private System.Windows.Forms.ListBox lstActivePause;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblLotSelection;
        private System.Windows.Forms.Button btnSelectAll;
    }
}

