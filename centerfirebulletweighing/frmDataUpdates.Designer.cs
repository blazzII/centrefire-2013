namespace CenterFireBulletWeighing
{
    partial class frmDataUpdates
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
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlHorizontalLine = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOperators = new System.Windows.Forms.Button();
            this.btnUpdateOperators = new System.Windows.Forms.Button();
            this.dgOperators = new System.Windows.Forms.DataGridView();
            this.operatorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOperatorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOperators = new CenterFireBulletWeighing.dsOperators();
            this.tblOperatorsTableAdapter = new CenterFireBulletWeighing.dsOperatorsTableAdapters.tblOperatorsTableAdapter();
            this.picWorld = new System.Windows.Forms.PictureBox();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnLots = new System.Windows.Forms.Button();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_AvgPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAvgCoreWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCoreLowerToleranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCoreUpperToleranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPlatedTargetAverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPlatedLowerToleranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPlatedUpperToleranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCoreUnitsPerLBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPlatedUnitsPerLBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProducts = new CenterFireBulletWeighing.dsProducts();
            this.tblProductsTableAdapter = new CenterFireBulletWeighing.dsProductsTableAdapters.tblProductsTableAdapter();
            this.btnUpdateProducts = new System.Windows.Forms.Button();
            this.dgLots = new System.Windows.Forms.DataGridView();
            this.lotIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotBarrelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotOperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lot_NumOfPieces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotLoadDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lot_CheckDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lot_EstimatedPullDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lot_PullDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lot_AvgGPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lot_Scrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lot_ToleranceIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLots = new CenterFireBulletWeighing.dsLots();
            this.btnPlatingPositions = new System.Windows.Forms.Button();
            this.dgPositions = new System.Windows.Forms.DataGridView();
            this.positionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionLotIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPlaterPositionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPositionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPositions = new CenterFireBulletWeighing.dsPositions();
            this.tblPlaterPositionsTableAdapter = new CenterFireBulletWeighing.dsPositionsTableAdapters.tblPlaterPositionsTableAdapter();
            this.btnPositions = new System.Windows.Forms.Button();
            this.tblLotsTableAdapter = new CenterFireBulletWeighing.dsLotsTableAdapters.tblLotsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgOperators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOperatorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLotsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlaterPositionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPositionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.White;
            this.lblSubTitle.Location = new System.Drawing.Point(106, 9);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(269, 25);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Database Administration";
            // 
            // pnlHorizontalLine
            // 
            this.pnlHorizontalLine.BackColor = System.Drawing.Color.Black;
            this.pnlHorizontalLine.Location = new System.Drawing.Point(17, 43);
            this.pnlHorizontalLine.Name = "pnlHorizontalLine";
            this.pnlHorizontalLine.Size = new System.Drawing.Size(867, 1);
            this.pnlHorizontalLine.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(774, 52);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 31);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOperators
            // 
            this.btnOperators.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperators.Location = new System.Drawing.Point(28, 50);
            this.btnOperators.Name = "btnOperators";
            this.btnOperators.Size = new System.Drawing.Size(121, 37);
            this.btnOperators.TabIndex = 10;
            this.btnOperators.Text = "Operators";
            this.btnOperators.UseVisualStyleBackColor = true;
            this.btnOperators.Click += new System.EventHandler(this.btnOperators_Click);
            // 
            // btnUpdateOperators
            // 
            this.btnUpdateOperators.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOperators.Location = new System.Drawing.Point(580, 52);
            this.btnUpdateOperators.Name = "btnUpdateOperators";
            this.btnUpdateOperators.Size = new System.Drawing.Size(188, 31);
            this.btnUpdateOperators.TabIndex = 1;
            this.btnUpdateOperators.Text = "Submit Updates";
            this.btnUpdateOperators.UseVisualStyleBackColor = true;
            this.btnUpdateOperators.Visible = false;
            this.btnUpdateOperators.Click += new System.EventHandler(this.btnUpdateOperators_Click);
            // 
            // dgOperators
            // 
            this.dgOperators.AllowUserToOrderColumns = true;
            this.dgOperators.AutoGenerateColumns = false;
            this.dgOperators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOperators.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operatorIDDataGridViewTextBoxColumn,
            this.operatorNameDataGridViewTextBoxColumn});
            this.dgOperators.DataSource = this.tblOperatorsBindingSource;
            this.dgOperators.Location = new System.Drawing.Point(28, 107);
            this.dgOperators.Name = "dgOperators";
            this.dgOperators.Size = new System.Drawing.Size(462, 566);
            this.dgOperators.TabIndex = 0;
            this.dgOperators.Visible = false;
            // 
            // operatorIDDataGridViewTextBoxColumn
            // 
            this.operatorIDDataGridViewTextBoxColumn.DataPropertyName = "operator_ID";
            this.operatorIDDataGridViewTextBoxColumn.HeaderText = "operator_ID";
            this.operatorIDDataGridViewTextBoxColumn.Name = "operatorIDDataGridViewTextBoxColumn";
            // 
            // operatorNameDataGridViewTextBoxColumn
            // 
            this.operatorNameDataGridViewTextBoxColumn.DataPropertyName = "operator_Name";
            this.operatorNameDataGridViewTextBoxColumn.HeaderText = "operator_Name";
            this.operatorNameDataGridViewTextBoxColumn.Name = "operatorNameDataGridViewTextBoxColumn";
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
            // picWorld
            // 
            this.picWorld.Image = global::CenterFireBulletWeighing.Properties.Resources.internetWorld;
            this.picWorld.Location = new System.Drawing.Point(18, 6);
            this.picWorld.Name = "picWorld";
            this.picWorld.Size = new System.Drawing.Size(82, 37);
            this.picWorld.TabIndex = 12;
            this.picWorld.TabStop = false;
            // 
            // btnProducts
            // 
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Location = new System.Drawing.Point(155, 50);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(121, 37);
            this.btnProducts.TabIndex = 13;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnLots
            // 
            this.btnLots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLots.Location = new System.Drawing.Point(838, 6);
            this.btnLots.Name = "btnLots";
            this.btnLots.Size = new System.Drawing.Size(46, 23);
            this.btnLots.TabIndex = 14;
            this.btnLots.Text = "Lots";
            this.btnLots.UseVisualStyleBackColor = true;
            this.btnLots.Visible = false;
            // 
            // dgProducts
            // 
            this.dgProducts.AllowUserToOrderColumns = true;
            this.dgProducts.AutoGenerateColumns = false;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.product_AvgPT,
            this.productAvgCoreWeightDataGridViewTextBoxColumn,
            this.productCoreLowerToleranceDataGridViewTextBoxColumn,
            this.productCoreUpperToleranceDataGridViewTextBoxColumn,
            this.productPlatedTargetAverageDataGridViewTextBoxColumn,
            this.productPlatedLowerToleranceDataGridViewTextBoxColumn,
            this.productPlatedUpperToleranceDataGridViewTextBoxColumn,
            this.productCoreUnitsPerLBDataGridViewTextBoxColumn,
            this.productPlatedUnitsPerLBDataGridViewTextBoxColumn});
            this.dgProducts.DataSource = this.tblProductsBindingSource;
            this.dgProducts.Location = new System.Drawing.Point(28, 107);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.Size = new System.Drawing.Size(971, 566);
            this.dgProducts.TabIndex = 16;
            this.dgProducts.Visible = false;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // product_AvgPT
            // 
            this.product_AvgPT.DataPropertyName = "product_AvgPT";
            this.product_AvgPT.HeaderText = "Average Plating Time";
            this.product_AvgPT.Name = "product_AvgPT";
            // 
            // productAvgCoreWeightDataGridViewTextBoxColumn
            // 
            this.productAvgCoreWeightDataGridViewTextBoxColumn.DataPropertyName = "product_AvgCoreWeight";
            this.productAvgCoreWeightDataGridViewTextBoxColumn.HeaderText = "Avg Core Weight";
            this.productAvgCoreWeightDataGridViewTextBoxColumn.Name = "productAvgCoreWeightDataGridViewTextBoxColumn";
            // 
            // productCoreLowerToleranceDataGridViewTextBoxColumn
            // 
            this.productCoreLowerToleranceDataGridViewTextBoxColumn.DataPropertyName = "product_CoreLowerTolerance";
            this.productCoreLowerToleranceDataGridViewTextBoxColumn.HeaderText = "Core LCL";
            this.productCoreLowerToleranceDataGridViewTextBoxColumn.Name = "productCoreLowerToleranceDataGridViewTextBoxColumn";
            // 
            // productCoreUpperToleranceDataGridViewTextBoxColumn
            // 
            this.productCoreUpperToleranceDataGridViewTextBoxColumn.DataPropertyName = "product_CoreUpperTolerance";
            this.productCoreUpperToleranceDataGridViewTextBoxColumn.HeaderText = "Core UCL";
            this.productCoreUpperToleranceDataGridViewTextBoxColumn.Name = "productCoreUpperToleranceDataGridViewTextBoxColumn";
            // 
            // productPlatedTargetAverageDataGridViewTextBoxColumn
            // 
            this.productPlatedTargetAverageDataGridViewTextBoxColumn.DataPropertyName = "product_PlatedTargetAverage";
            this.productPlatedTargetAverageDataGridViewTextBoxColumn.HeaderText = "Plated Avg Wgt";
            this.productPlatedTargetAverageDataGridViewTextBoxColumn.Name = "productPlatedTargetAverageDataGridViewTextBoxColumn";
            // 
            // productPlatedLowerToleranceDataGridViewTextBoxColumn
            // 
            this.productPlatedLowerToleranceDataGridViewTextBoxColumn.DataPropertyName = "product_PlatedLowerTolerance";
            this.productPlatedLowerToleranceDataGridViewTextBoxColumn.HeaderText = "Plated LCL";
            this.productPlatedLowerToleranceDataGridViewTextBoxColumn.Name = "productPlatedLowerToleranceDataGridViewTextBoxColumn";
            // 
            // productPlatedUpperToleranceDataGridViewTextBoxColumn
            // 
            this.productPlatedUpperToleranceDataGridViewTextBoxColumn.DataPropertyName = "product_PlatedUpperTolerance";
            this.productPlatedUpperToleranceDataGridViewTextBoxColumn.HeaderText = "Plated UCL";
            this.productPlatedUpperToleranceDataGridViewTextBoxColumn.Name = "productPlatedUpperToleranceDataGridViewTextBoxColumn";
            // 
            // productCoreUnitsPerLBDataGridViewTextBoxColumn
            // 
            this.productCoreUnitsPerLBDataGridViewTextBoxColumn.DataPropertyName = "product_CoreUnitsPerLB";
            this.productCoreUnitsPerLBDataGridViewTextBoxColumn.HeaderText = "Core Units/LB";
            this.productCoreUnitsPerLBDataGridViewTextBoxColumn.Name = "productCoreUnitsPerLBDataGridViewTextBoxColumn";
            // 
            // productPlatedUnitsPerLBDataGridViewTextBoxColumn
            // 
            this.productPlatedUnitsPerLBDataGridViewTextBoxColumn.DataPropertyName = "product_PlatedUnitsPerLB";
            this.productPlatedUnitsPerLBDataGridViewTextBoxColumn.HeaderText = "Plated Units/LB";
            this.productPlatedUnitsPerLBDataGridViewTextBoxColumn.Name = "productPlatedUnitsPerLBDataGridViewTextBoxColumn";
            // 
            // tblProductsBindingSource
            // 
            this.tblProductsBindingSource.DataMember = "tblProducts";
            this.tblProductsBindingSource.DataSource = this.dsProducts;
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
            // btnUpdateProducts
            // 
            this.btnUpdateProducts.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProducts.Location = new System.Drawing.Point(580, 52);
            this.btnUpdateProducts.Name = "btnUpdateProducts";
            this.btnUpdateProducts.Size = new System.Drawing.Size(188, 31);
            this.btnUpdateProducts.TabIndex = 17;
            this.btnUpdateProducts.Text = "Submit Updates";
            this.btnUpdateProducts.UseVisualStyleBackColor = true;
            this.btnUpdateProducts.Visible = false;
            this.btnUpdateProducts.Click += new System.EventHandler(this.btnUpdateProducts_Click);
            // 
            // dgLots
            // 
            this.dgLots.AllowUserToOrderColumns = true;
            this.dgLots.AutoGenerateColumns = false;
            this.dgLots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lotIDDataGridViewTextBoxColumn,
            this.lotProductDataGridViewTextBoxColumn,
            this.lotBarrelDataGridViewTextBoxColumn,
            this.lotPositionDataGridViewTextBoxColumn,
            this.lotOperatorDataGridViewTextBoxColumn,
            this.lot_NumOfPieces,
            this.lotLoadDateTimeDataGridViewTextBoxColumn,
            this.lot_CheckDateTime,
            this.lot_EstimatedPullDateTime,
            this.lot_PullDateTime,
            this.lot_AvgGPH,
            this.lot_Scrap,
            this.lot_ToleranceIssue});
            this.dgLots.DataSource = this.tblLotsBindingSource;
            this.dgLots.Location = new System.Drawing.Point(28, 107);
            this.dgLots.Name = "dgLots";
            this.dgLots.Size = new System.Drawing.Size(1249, 584);
            this.dgLots.TabIndex = 19;
            this.dgLots.Visible = false;
            // 
            // lotIDDataGridViewTextBoxColumn
            // 
            this.lotIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.lotIDDataGridViewTextBoxColumn.DataPropertyName = "lot_ID";
            this.lotIDDataGridViewTextBoxColumn.Frozen = true;
            this.lotIDDataGridViewTextBoxColumn.HeaderText = "Lot #";
            this.lotIDDataGridViewTextBoxColumn.Name = "lotIDDataGridViewTextBoxColumn";
            this.lotIDDataGridViewTextBoxColumn.Width = 21;
            // 
            // lotProductDataGridViewTextBoxColumn
            // 
            this.lotProductDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.lotProductDataGridViewTextBoxColumn.DataPropertyName = "lot_Product";
            this.lotProductDataGridViewTextBoxColumn.HeaderText = "Product";
            this.lotProductDataGridViewTextBoxColumn.Name = "lotProductDataGridViewTextBoxColumn";
            this.lotProductDataGridViewTextBoxColumn.Width = 21;
            // 
            // lotBarrelDataGridViewTextBoxColumn
            // 
            this.lotBarrelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lotBarrelDataGridViewTextBoxColumn.DataPropertyName = "lot_Barrel";
            this.lotBarrelDataGridViewTextBoxColumn.HeaderText = "Barrel";
            this.lotBarrelDataGridViewTextBoxColumn.Name = "lotBarrelDataGridViewTextBoxColumn";
            this.lotBarrelDataGridViewTextBoxColumn.Width = 59;
            // 
            // lotPositionDataGridViewTextBoxColumn
            // 
            this.lotPositionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lotPositionDataGridViewTextBoxColumn.DataPropertyName = "lot_Position";
            this.lotPositionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.lotPositionDataGridViewTextBoxColumn.Name = "lotPositionDataGridViewTextBoxColumn";
            this.lotPositionDataGridViewTextBoxColumn.Width = 69;
            // 
            // lotOperatorDataGridViewTextBoxColumn
            // 
            this.lotOperatorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.lotOperatorDataGridViewTextBoxColumn.DataPropertyName = "lot_Operator";
            this.lotOperatorDataGridViewTextBoxColumn.HeaderText = "Operator";
            this.lotOperatorDataGridViewTextBoxColumn.Name = "lotOperatorDataGridViewTextBoxColumn";
            this.lotOperatorDataGridViewTextBoxColumn.Width = 21;
            // 
            // lot_NumOfPieces
            // 
            this.lot_NumOfPieces.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.lot_NumOfPieces.DataPropertyName = "lot_NumOfPieces";
            this.lot_NumOfPieces.HeaderText = "Pieces";
            this.lot_NumOfPieces.Name = "lot_NumOfPieces";
            this.lot_NumOfPieces.Width = 21;
            // 
            // lotLoadDateTimeDataGridViewTextBoxColumn
            // 
            this.lotLoadDateTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.lotLoadDateTimeDataGridViewTextBoxColumn.DataPropertyName = "lot_LoadDateTime";
            this.lotLoadDateTimeDataGridViewTextBoxColumn.HeaderText = "Load";
            this.lotLoadDateTimeDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.lotLoadDateTimeDataGridViewTextBoxColumn.Name = "lotLoadDateTimeDataGridViewTextBoxColumn";
            this.lotLoadDateTimeDataGridViewTextBoxColumn.Width = 21;
            // 
            // lot_CheckDateTime
            // 
            this.lot_CheckDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.lot_CheckDateTime.DataPropertyName = "lot_CheckDateTime";
            this.lot_CheckDateTime.HeaderText = "Check";
            this.lot_CheckDateTime.Name = "lot_CheckDateTime";
            this.lot_CheckDateTime.Width = 21;
            // 
            // lot_EstimatedPullDateTime
            // 
            this.lot_EstimatedPullDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.lot_EstimatedPullDateTime.DataPropertyName = "lot_EstimatedPullDateTime";
            this.lot_EstimatedPullDateTime.HeaderText = "Est. Pull";
            this.lot_EstimatedPullDateTime.Name = "lot_EstimatedPullDateTime";
            this.lot_EstimatedPullDateTime.Width = 21;
            // 
            // lot_PullDateTime
            // 
            this.lot_PullDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.lot_PullDateTime.DataPropertyName = "lot_PullDateTime";
            this.lot_PullDateTime.HeaderText = "Pulled";
            this.lot_PullDateTime.Name = "lot_PullDateTime";
            this.lot_PullDateTime.Width = 21;
            // 
            // lot_AvgGPH
            // 
            this.lot_AvgGPH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.lot_AvgGPH.DataPropertyName = "lot_AvgGPH";
            this.lot_AvgGPH.HeaderText = "Avg. GPH";
            this.lot_AvgGPH.Name = "lot_AvgGPH";
            this.lot_AvgGPH.Width = 21;
            // 
            // lot_Scrap
            // 
            this.lot_Scrap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.lot_Scrap.DataPropertyName = "lot_Scrap";
            this.lot_Scrap.HeaderText = "Scrap";
            this.lot_Scrap.Name = "lot_Scrap";
            this.lot_Scrap.Width = 21;
            // 
            // lot_ToleranceIssue
            // 
            this.lot_ToleranceIssue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.lot_ToleranceIssue.DataPropertyName = "lot_ToleranceIssue";
            this.lot_ToleranceIssue.HeaderText = "Notes";
            this.lot_ToleranceIssue.Name = "lot_ToleranceIssue";
            this.lot_ToleranceIssue.Width = 21;
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
            // btnPlatingPositions
            // 
            this.btnPlatingPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlatingPositions.Location = new System.Drawing.Point(282, 50);
            this.btnPlatingPositions.Name = "btnPlatingPositions";
            this.btnPlatingPositions.Size = new System.Drawing.Size(158, 37);
            this.btnPlatingPositions.TabIndex = 21;
            this.btnPlatingPositions.Text = "Plating Positions";
            this.btnPlatingPositions.UseVisualStyleBackColor = true;
            this.btnPlatingPositions.Click += new System.EventHandler(this.btnPlatingPositions_Click);
            // 
            // dgPositions
            // 
            this.dgPositions.AutoGenerateColumns = false;
            this.dgPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionNumberDataGridViewTextBoxColumn,
            this.positionLotIDDataGridViewTextBoxColumn});
            this.dgPositions.DataSource = this.tblPlaterPositionsBindingSource;
            this.dgPositions.Location = new System.Drawing.Point(28, 107);
            this.dgPositions.Name = "dgPositions";
            this.dgPositions.Size = new System.Drawing.Size(248, 584);
            this.dgPositions.TabIndex = 22;
            this.dgPositions.Visible = false;
            // 
            // positionNumberDataGridViewTextBoxColumn
            // 
            this.positionNumberDataGridViewTextBoxColumn.DataPropertyName = "position_Number";
            this.positionNumberDataGridViewTextBoxColumn.HeaderText = "Plating Position";
            this.positionNumberDataGridViewTextBoxColumn.Name = "positionNumberDataGridViewTextBoxColumn";
            // 
            // positionLotIDDataGridViewTextBoxColumn
            // 
            this.positionLotIDDataGridViewTextBoxColumn.DataPropertyName = "position_LotID";
            this.positionLotIDDataGridViewTextBoxColumn.HeaderText = "Lot";
            this.positionLotIDDataGridViewTextBoxColumn.Name = "positionLotIDDataGridViewTextBoxColumn";
            // 
            // tblPlaterPositionsBindingSource
            // 
            this.tblPlaterPositionsBindingSource.DataMember = "tblPlaterPositions";
            this.tblPlaterPositionsBindingSource.DataSource = this.dsPositionsBindingSource;
            // 
            // dsPositionsBindingSource
            // 
            this.dsPositionsBindingSource.DataSource = this.dsPositions;
            this.dsPositionsBindingSource.Position = 0;
            // 
            // dsPositions
            // 
            this.dsPositions.DataSetName = "dsPositions";
            this.dsPositions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPlaterPositionsTableAdapter
            // 
            this.tblPlaterPositionsTableAdapter.ClearBeforeFill = true;
            // 
            // btnPositions
            // 
            this.btnPositions.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPositions.Location = new System.Drawing.Point(580, 50);
            this.btnPositions.Name = "btnPositions";
            this.btnPositions.Size = new System.Drawing.Size(188, 35);
            this.btnPositions.TabIndex = 23;
            this.btnPositions.Text = "Submit Updates";
            this.btnPositions.UseVisualStyleBackColor = true;
            this.btnPositions.Visible = false;
            this.btnPositions.Click += new System.EventHandler(this.btnPositions_Click);
            // 
            // tblLotsTableAdapter
            // 
            this.tblLotsTableAdapter.ClearBeforeFill = true;
            // 
            // frmDataUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1377, 792);
            this.Controls.Add(this.btnPositions);
            this.Controls.Add(this.dgPositions);
            this.Controls.Add(this.btnPlatingPositions);
            this.Controls.Add(this.dgLots);
            this.Controls.Add(this.btnUpdateProducts);
            this.Controls.Add(this.dgProducts);
            this.Controls.Add(this.dgOperators);
            this.Controls.Add(this.btnUpdateOperators);
            this.Controls.Add(this.btnLots);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.picWorld);
            this.Controls.Add(this.btnOperators);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlHorizontalLine);
            this.Controls.Add(this.lblSubTitle);
            this.Name = "frmDataUpdates";
            this.Text = "Database Administration Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOperators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOperatorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLotsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlaterPositionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPositionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPositions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlHorizontalLine;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOperators;
        private System.Windows.Forms.DataGridView dgOperators;
        private dsOperators dsOperators;
        private System.Windows.Forms.BindingSource tblOperatorsBindingSource;
        private CenterFireBulletWeighing.dsOperatorsTableAdapters.tblOperatorsTableAdapter tblOperatorsTableAdapter;
        private System.Windows.Forms.Button btnUpdateOperators;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox picWorld;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnLots;
        private System.Windows.Forms.DataGridView dgProducts;
        private dsProducts dsProducts;
        private System.Windows.Forms.BindingSource tblProductsBindingSource;
        private CenterFireBulletWeighing.dsProductsTableAdapters.tblProductsTableAdapter tblProductsTableAdapter;
        private System.Windows.Forms.Button btnUpdateProducts;
        private System.Windows.Forms.DataGridView dgLots;
        private dsLots dsLots;
        private System.Windows.Forms.BindingSource tblLotsBindingSource;
        private CenterFireBulletWeighing.dsLotsTableAdapters.tblLotsTableAdapter tblLotsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPlatingPositions;
        private System.Windows.Forms.DataGridView dgPositions;
        private System.Windows.Forms.BindingSource dsPositionsBindingSource;
        private dsPositions dsPositions;
        private System.Windows.Forms.BindingSource tblPlaterPositionsBindingSource;
        private CenterFireBulletWeighing.dsPositionsTableAdapters.tblPlaterPositionsTableAdapter tblPlaterPositionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionLotIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPositions;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotBarrelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotOperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot_NumOfPieces;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotLoadDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot_CheckDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot_EstimatedPullDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot_PullDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot_AvgGPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot_Scrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot_ToleranceIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_AvgPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAvgCoreWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCoreLowerToleranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCoreUpperToleranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPlatedTargetAverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPlatedLowerToleranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPlatedUpperToleranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCoreUnitsPerLBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPlatedUnitsPerLBDataGridViewTextBoxColumn;
    }
}