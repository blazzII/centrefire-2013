using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CenterFireBulletWeighing
{
    public partial class frmDataUpdates : Form
    {
       
        public frmDataUpdates()
        {
            InitializeComponent();
        }
 
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dba_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPositions.tblPlaterPositions' table. You can move, or remove it, as needed.
            this.tblPlaterPositionsTableAdapter.Fill(this.dsPositions.tblPlaterPositions);
            //this.tblLotsTableAdapter.Fill(this.dsLots.tblLots);
            this.tblProductsTableAdapter.Fill(this.dsProducts.tblProducts);
            this.tblOperatorsTableAdapter.Fill(this.dsOperators.tblOperators);
        
        }

        private void btnUpdateOperators_Click(object sender, EventArgs e)
        {
            this.tblOperatorsTableAdapter.Update(this.dsOperators.tblOperators);
            this.dgOperators.Visible = false;
            this.btnUpdateOperators.Visible = false;
        }

        private void btnOperators_Click(object sender, EventArgs e)
        {
            this.dgProducts.Visible = false;
            this.dgOperators.Visible = true;
            this.dgLots.Visible = false;
            this.dgPositions.Visible = false;
            this.btnUpdateOperators.Visible = true;
            this.btnUpdateProducts.Visible = false;
            //this.btnUpdateLots.Visible = false;
            this.btnPositions.Visible = false;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.dgOperators.Visible = false;
            this.dgProducts.Visible = true;
            this.dgLots.Visible = false;
            this.dgPositions.Visible = false;
            this.btnUpdateOperators.Visible = false;
            this.btnUpdateProducts.Visible = true;
            //this.btnUpdateLots.Visible = false;
            this.btnPositions.Visible = false;
        }

        private void btnUpdateProducts_Click(object sender, EventArgs e)
        {
            this.tblProductsTableAdapter.Update(this.dsProducts.tblProducts);
            this.dgProducts.Visible = false;
            this.btnUpdateProducts.Visible = false;
        }

        //private void btnUpdateLots_Click(object sender, EventArgs e)
        //{
            //this.tblLotsTableAdapter.Update(this.dsLots.tblLots);
            //this.dgLots.Visible = false;
            //this.btnUpdateLots.Visible = false;
        //}

        //private void btnLots_Click(object sender, EventArgs e)
        //{
            //this.dgOperators.Visible = false;
            //this.dgProducts.Visible = false;
            //this.dgLots.Visible = true;
            //this.dgPositions.Visible = false;
            //this.btnUpdateOperators.Visible = false;
            //this.btnUpdateProducts.Visible = false;
            //this.btnUpdateLots.Visible = true;
            //this.btnPositions.Visible = false;
        //}

        private void btnPlatingPositions_Click(object sender, EventArgs e)
        {
            this.dgOperators.Visible = false;
            this.dgProducts.Visible = false;
            this.dgLots.Visible = false;
            this.dgPositions.Visible = true;
            this.btnUpdateOperators.Visible = false;
            this.btnUpdateProducts.Visible = false;
            //this.btnUpdateLots.Visible = false;
            this.btnPositions.Visible = true;
        }

        private void btnPositions_Click(object sender, EventArgs e)
        {
            this.tblPlaterPositionsTableAdapter.Update(this.dsPositions.tblPlaterPositions);
            this.dgPositions.Visible = false;
            this.btnPositions.Visible = false;
 
        }

   

       
    }
}
