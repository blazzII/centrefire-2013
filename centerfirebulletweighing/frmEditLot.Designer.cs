namespace CenterFireBulletWeighing
{
    partial class frmEditLot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditLot));
            this.pnlEditLot = new System.Windows.Forms.Panel();
            this.btnDisplayLot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkScrapped = new System.Windows.Forms.CheckBox();
            this.lblScrapped = new System.Windows.Forms.Label();
            this.lblPullOperator = new System.Windows.Forms.Label();
            this.lblPullDateTime = new System.Windows.Forms.Label();
            this.lblDownTime = new System.Windows.Forms.Label();
            this.lblLotNumber = new System.Windows.Forms.Label();
            this.txtPullOperator = new System.Windows.Forms.TextBox();
            this.txtPullDateTime = new System.Windows.Forms.TextBox();
            this.txtDownTime = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtBarrel = new System.Windows.Forms.TextBox();
            this.txtNumOfPieces = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.txtLoadDateTime = new System.Windows.Forms.TextBox();
            this.cboSelectLot = new System.Windows.Forms.ComboBox();
            this.tblLotsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsLotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLots = new CenterFireBulletWeighing.dsLots();
            this.txtCoreAverageWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelLotEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEditLotTitle = new System.Windows.Forms.Label();
            this.btnEditLotSubmit = new System.Windows.Forms.Button();
            this.lblSelectLot = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tblLotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLotsTableAdapter = new CenterFireBulletWeighing.dsLotsTableAdapters.tblLotsTableAdapter();
            this.pnlEditLot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLotsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLotsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEditLot
            // 
            this.pnlEditLot.BackColor = System.Drawing.Color.LightGray;
            this.pnlEditLot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditLot.Controls.Add(this.btnDisplayLot);
            this.pnlEditLot.Controls.Add(this.label1);
            this.pnlEditLot.Controls.Add(this.chkScrapped);
            this.pnlEditLot.Controls.Add(this.lblScrapped);
            this.pnlEditLot.Controls.Add(this.lblPullOperator);
            this.pnlEditLot.Controls.Add(this.lblPullDateTime);
            this.pnlEditLot.Controls.Add(this.lblDownTime);
            this.pnlEditLot.Controls.Add(this.lblLotNumber);
            this.pnlEditLot.Controls.Add(this.txtPullOperator);
            this.pnlEditLot.Controls.Add(this.txtPullDateTime);
            this.pnlEditLot.Controls.Add(this.txtDownTime);
            this.pnlEditLot.Controls.Add(this.txtPosition);
            this.pnlEditLot.Controls.Add(this.txtBarrel);
            this.pnlEditLot.Controls.Add(this.txtNumOfPieces);
            this.pnlEditLot.Controls.Add(this.txtProduct);
            this.pnlEditLot.Controls.Add(this.txtOperator);
            this.pnlEditLot.Controls.Add(this.txtLoadDateTime);
            this.pnlEditLot.Controls.Add(this.cboSelectLot);
            this.pnlEditLot.Controls.Add(this.txtCoreAverageWeight);
            this.pnlEditLot.Controls.Add(this.label2);
            this.pnlEditLot.Controls.Add(this.label5);
            this.pnlEditLot.Controls.Add(this.btnCancelLotEdit);
            this.pnlEditLot.Controls.Add(this.label6);
            this.pnlEditLot.Controls.Add(this.panel3);
            this.pnlEditLot.Controls.Add(this.lblEditLotTitle);
            this.pnlEditLot.Controls.Add(this.btnEditLotSubmit);
            this.pnlEditLot.Controls.Add(this.lblSelectLot);
            this.pnlEditLot.Controls.Add(this.label9);
            this.pnlEditLot.Controls.Add(this.label10);
            this.pnlEditLot.Controls.Add(this.label11);
            this.pnlEditLot.Controls.Add(this.label12);
            this.pnlEditLot.Location = new System.Drawing.Point(14, 14);
            this.pnlEditLot.Margin = new System.Windows.Forms.Padding(5);
            this.pnlEditLot.Name = "pnlEditLot";
            this.pnlEditLot.Padding = new System.Windows.Forms.Padding(10);
            this.pnlEditLot.Size = new System.Drawing.Size(627, 635);
            this.pnlEditLot.TabIndex = 31;
            // 
            // btnDisplayLot
            // 
            this.btnDisplayLot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayLot.Location = new System.Drawing.Point(483, 3);
            this.btnDisplayLot.Name = "btnDisplayLot";
            this.btnDisplayLot.Size = new System.Drawing.Size(110, 31);
            this.btnDisplayLot.TabIndex = 52;
            this.btnDisplayLot.Text = "Display";
            this.btnDisplayLot.UseVisualStyleBackColor = true;
            this.btnDisplayLot.Click += new System.EventHandler(this.btnDisplayLot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Lot #:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkScrapped
            // 
            this.chkScrapped.AutoSize = true;
            this.chkScrapped.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkScrapped.Location = new System.Drawing.Point(252, 511);
            this.chkScrapped.Name = "chkScrapped";
            this.chkScrapped.Size = new System.Drawing.Size(162, 23);
            this.chkScrapped.TabIndex = 0;
            this.chkScrapped.Text = "mark as scrapped";
            this.chkScrapped.UseVisualStyleBackColor = true;
            this.chkScrapped.Visible = false;
            // 
            // lblScrapped
            // 
            this.lblScrapped.AutoSize = true;
            this.lblScrapped.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScrapped.Location = new System.Drawing.Point(118, 511);
            this.lblScrapped.Name = "lblScrapped";
            this.lblScrapped.Size = new System.Drawing.Size(112, 23);
            this.lblScrapped.TabIndex = 49;
            this.lblScrapped.Text = "Scrapped?:";
            this.lblScrapped.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPullOperator
            // 
            this.lblPullOperator.AutoSize = true;
            this.lblPullOperator.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPullOperator.Location = new System.Drawing.Point(97, 462);
            this.lblPullOperator.Name = "lblPullOperator";
            this.lblPullOperator.Size = new System.Drawing.Size(133, 23);
            this.lblPullOperator.TabIndex = 48;
            this.lblPullOperator.Text = "Pull Operator:";
            this.lblPullOperator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPullDateTime
            // 
            this.lblPullDateTime.AutoSize = true;
            this.lblPullDateTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPullDateTime.Location = new System.Drawing.Point(87, 421);
            this.lblPullDateTime.Name = "lblPullDateTime";
            this.lblPullDateTime.Size = new System.Drawing.Size(143, 23);
            this.lblPullDateTime.TabIndex = 47;
            this.lblPullDateTime.Text = "Pull Date/Time:";
            this.lblPullDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDownTime
            // 
            this.lblDownTime.AutoSize = true;
            this.lblDownTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownTime.Location = new System.Drawing.Point(116, 380);
            this.lblDownTime.Name = "lblDownTime";
            this.lblDownTime.Size = new System.Drawing.Size(114, 23);
            this.lblDownTime.TabIndex = 46;
            this.lblDownTime.Text = "Down Time:";
            this.lblDownTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLotNumber
            // 
            this.lblLotNumber.AutoSize = true;
            this.lblLotNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotNumber.Location = new System.Drawing.Point(249, 54);
            this.lblLotNumber.Name = "lblLotNumber";
            this.lblLotNumber.Size = new System.Drawing.Size(54, 24);
            this.lblLotNumber.TabIndex = 45;
            this.lblLotNumber.Text = "0000";
            this.lblLotNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPullOperator
            // 
            this.txtPullOperator.Location = new System.Drawing.Point(252, 459);
            this.txtPullOperator.Name = "txtPullOperator";
            this.txtPullOperator.Size = new System.Drawing.Size(238, 30);
            this.txtPullOperator.TabIndex = 29;
            this.txtPullOperator.Visible = false;
            // 
            // txtPullDateTime
            // 
            this.txtPullDateTime.Location = new System.Drawing.Point(252, 418);
            this.txtPullDateTime.Name = "txtPullDateTime";
            this.txtPullDateTime.Size = new System.Drawing.Size(238, 30);
            this.txtPullDateTime.TabIndex = 28;
            this.txtPullDateTime.Visible = false;
            // 
            // txtDownTime
            // 
            this.txtDownTime.Location = new System.Drawing.Point(252, 377);
            this.txtDownTime.Name = "txtDownTime";
            this.txtDownTime.Size = new System.Drawing.Size(238, 30);
            this.txtDownTime.TabIndex = 27;
            this.txtDownTime.Visible = false;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(252, 336);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(238, 30);
            this.txtPosition.TabIndex = 26;
            this.txtPosition.Visible = false;
            // 
            // txtBarrel
            // 
            this.txtBarrel.Location = new System.Drawing.Point(252, 295);
            this.txtBarrel.Name = "txtBarrel";
            this.txtBarrel.Size = new System.Drawing.Size(238, 30);
            this.txtBarrel.TabIndex = 25;
            this.txtBarrel.Visible = false;
            // 
            // txtNumOfPieces
            // 
            this.txtNumOfPieces.Location = new System.Drawing.Point(252, 254);
            this.txtNumOfPieces.Name = "txtNumOfPieces";
            this.txtNumOfPieces.Size = new System.Drawing.Size(238, 30);
            this.txtNumOfPieces.TabIndex = 24;
            this.txtNumOfPieces.Visible = false;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(252, 172);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(238, 30);
            this.txtProduct.TabIndex = 22;
            this.txtProduct.Visible = false;
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(252, 131);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(238, 30);
            this.txtOperator.TabIndex = 21;
            this.txtOperator.Visible = false;
            // 
            // txtLoadDateTime
            // 
            this.txtLoadDateTime.Location = new System.Drawing.Point(252, 90);
            this.txtLoadDateTime.Name = "txtLoadDateTime";
            this.txtLoadDateTime.Size = new System.Drawing.Size(238, 30);
            this.txtLoadDateTime.TabIndex = 20;
            this.txtLoadDateTime.Visible = false;
            // 
            // cboSelectLot
            // 
            this.cboSelectLot.DataSource = this.tblLotsBindingSource1;
            this.cboSelectLot.DisplayMember = "lot_ID";
            this.cboSelectLot.FormattingEnabled = true;
            this.cboSelectLot.Location = new System.Drawing.Point(328, 3);
            this.cboSelectLot.Name = "cboSelectLot";
            this.cboSelectLot.Size = new System.Drawing.Size(121, 31);
            this.cboSelectLot.TabIndex = 19;
            this.cboSelectLot.ValueMember = "lot_ID";
            this.cboSelectLot.SelectedIndexChanged += new System.EventHandler(this.cboSelectLot_SelectedIndexChanged);
            // 
            // tblLotsBindingSource1
            // 
            this.tblLotsBindingSource1.DataMember = "tblLots";
            this.tblLotsBindingSource1.DataSource = this.dsLotsBindingSource;
            // 
            // dsLotsBindingSource
            // 
            this.dsLotsBindingSource.DataSource = this.dsLots;
            this.dsLotsBindingSource.Position = 0;
            // 
            // dsLots
            // 
            this.dsLots.DataSetName = "dsLots";
            this.dsLots.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCoreAverageWeight
            // 
            this.txtCoreAverageWeight.Location = new System.Drawing.Point(252, 213);
            this.txtCoreAverageWeight.Name = "txtCoreAverageWeight";
            this.txtCoreAverageWeight.Size = new System.Drawing.Size(238, 30);
            this.txtCoreAverageWeight.TabIndex = 23;
            this.txtCoreAverageWeight.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Avg. Core Weight:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Number of Pieces:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelLotEdit
            // 
            this.btnCancelLotEdit.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelLotEdit.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLotEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelLotEdit.Location = new System.Drawing.Point(529, 589);
            this.btnCancelLotEdit.Name = "btnCancelLotEdit";
            this.btnCancelLotEdit.Size = new System.Drawing.Size(83, 31);
            this.btnCancelLotEdit.TabIndex = 2;
            this.btnCancelLotEdit.Text = "Cancel";
            this.btnCancelLotEdit.UseVisualStyleBackColor = false;
            this.btnCancelLotEdit.Click += new System.EventHandler(this.btnCancelLotEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Load Date/Time:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(18, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 1);
            this.panel3.TabIndex = 20;
            // 
            // lblEditLotTitle
            // 
            this.lblEditLotTitle.AutoSize = true;
            this.lblEditLotTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditLotTitle.ForeColor = System.Drawing.Color.Black;
            this.lblEditLotTitle.Location = new System.Drawing.Point(17, 6);
            this.lblEditLotTitle.Name = "lblEditLotTitle";
            this.lblEditLotTitle.Size = new System.Drawing.Size(119, 33);
            this.lblEditLotTitle.TabIndex = 12;
            this.lblEditLotTitle.Text = "Edit Lot";
            // 
            // btnEditLotSubmit
            // 
            this.btnEditLotSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnEditLotSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLotSubmit.Location = new System.Drawing.Point(107, 567);
            this.btnEditLotSubmit.Name = "btnEditLotSubmit";
            this.btnEditLotSubmit.Size = new System.Drawing.Size(383, 53);
            this.btnEditLotSubmit.TabIndex = 1;
            this.btnEditLotSubmit.Text = "UPDATE LOT";
            this.btnEditLotSubmit.UseVisualStyleBackColor = false;
            this.btnEditLotSubmit.Click += new System.EventHandler(this.btnEditLotSubmit_Click);
            // 
            // lblSelectLot
            // 
            this.lblSelectLot.AutoSize = true;
            this.lblSelectLot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectLot.Location = new System.Drawing.Point(201, 6);
            this.lblSelectLot.Name = "lblSelectLot";
            this.lblSelectLot.Size = new System.Drawing.Size(112, 24);
            this.lblSelectLot.TabIndex = 7;
            this.lblSelectLot.Text = "Select Lot:";
            this.lblSelectLot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(96, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Plating Barrel:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(87, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Plater Position:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(146, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Product:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(134, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Operator:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tblLotsBindingSource
            // 
            this.tblLotsBindingSource.DataMember = "tblLots";
            this.tblLotsBindingSource.DataSource = this.dsLotsBindingSource;
            // 
            // tblLotsTableAdapter
            // 
            this.tblLotsTableAdapter.ClearBeforeFill = true;
            // 
            // frmEditLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 663);
            this.Controls.Add(this.pnlEditLot);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEditLot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Existing Lot";
            this.Load += new System.EventHandler(this.frmEditLot_Load);
            this.pnlEditLot.ResumeLayout(false);
            this.pnlEditLot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLotsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLotsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEditLot;
        private System.Windows.Forms.ComboBox cboSelectLot;
        private System.Windows.Forms.TextBox txtCoreAverageWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelLotEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblEditLotTitle;
        private System.Windows.Forms.Button btnEditLotSubmit;
        private System.Windows.Forms.Label lblSelectLot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource dsLotsBindingSource;
        private dsLots dsLots;
        private System.Windows.Forms.BindingSource tblLotsBindingSource;
        private dsLotsTableAdapters.tblLotsTableAdapter tblLotsTableAdapter;
        private System.Windows.Forms.BindingSource tblLotsBindingSource1;
        private System.Windows.Forms.TextBox txtLoadDateTime;
        private System.Windows.Forms.Label lblPullOperator;
        private System.Windows.Forms.Label lblPullDateTime;
        private System.Windows.Forms.Label lblDownTime;
        private System.Windows.Forms.TextBox txtPullOperator;
        private System.Windows.Forms.TextBox txtPullDateTime;
        private System.Windows.Forms.TextBox txtDownTime;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtBarrel;
        private System.Windows.Forms.TextBox txtNumOfPieces;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.CheckBox chkScrapped;
        private System.Windows.Forms.Label lblScrapped;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisplayLot;
        private System.Windows.Forms.Label lblLotNumber;
    }
}