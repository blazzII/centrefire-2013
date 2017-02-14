using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace CenterFireBulletWeighing
{
    public partial class frmEditLot : Form
    {
        OleDbConnection dataconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|centerfirebulletweighing.accdb");

        public frmEditLot()
        {
            InitializeComponent();
        }

        private void frmEditLot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsLots.tblLots' table. You can move, or remove it, as needed.
            this.tblLotsTableAdapter.Fill(this.dsLots.tblLots);
            this.cboSelectLot.Select();
        }

        private void cboSelectLot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditLotSubmit_Click(object sender, EventArgs e)
        {
            int loadOp = 0; // Load Operator
            int pullOp = 0; // Pull Operator
            string loadDateTime = String.Empty;
            string pullDateTime = String.Empty;

            // Set Scrapped variable if necessary
            string scrapcheck = "";
            if (chkScrapped.Checked) scrapcheck = "Scrapped";

            dataconn.Open(); // Open Data Connection

            // get Operator Number
            if (txtOperator.Text != "")
            {
                OleDbCommand cmdGetLoadOperator = new OleDbCommand();
                cmdGetLoadOperator.CommandType = CommandType.Text;
                cmdGetLoadOperator.CommandText = "SELECT operator_ID FROM tblOperators WHERE operator_Name = '" + txtOperator.Text + "'";
                cmdGetLoadOperator.Connection = dataconn;
                OleDbDataReader dRLoader = cmdGetLoadOperator.ExecuteReader();
                try
                {
                    dRLoader.Read();
                    loadOp = Convert.ToInt32(dRLoader["operator_ID"]);
                }
                catch (Exception exNames)
                {
                    loadOp = 0;
                }
                finally
                {
                    dRLoader.Close();
                }

            }
            if (txtPullOperator.Text != "")
            {
                OleDbCommand cmdGetPullOperator = new OleDbCommand();
                cmdGetPullOperator.CommandType = CommandType.Text;
                cmdGetPullOperator.CommandText = "SELECT operator_ID FROM tblOperators WHERE operator_Name = '" + txtPullOperator.Text + "'";
                cmdGetPullOperator.Connection = dataconn;
                OleDbDataReader dRPuller = cmdGetPullOperator.ExecuteReader();
                try
                {
                    dRPuller.Read();
                    pullOp = Convert.ToInt32(dRPuller["operator_ID"]);
                }
                catch (Exception exNames)
                {
                    pullOp = 0;
                }
                finally
                {
                    dRPuller.Close();
                }

            }
            // END get operator names
            //DateTime var;
            //if (!DateTime.TryParse(txtLoadDateTime.Text, out var) || !DateTime.TryParse(txtPullDateTime.Text, out var))
            //{
            //    // Validate Edits
            //    MessageBox.Show("Enter a valid Date/Times [FORMAT]");
            //}
                loadDateTime = txtLoadDateTime.Text;
                pullDateTime = txtPullDateTime.Text;
                // UPDATE
                OleDbCommand cmdUpdate = new OleDbCommand();
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = "UPDATE tblLots SET lot_LoadDateTime = #" + loadDateTime + "#, lot_Operator = " + Convert.ToInt32(loadOp) + ", lot_Product = '" + txtProduct.Text + "', lot_CoreAverageWeight = " + Convert.ToDouble(txtCoreAverageWeight.Text) + ", lot_NumOfPieces = " + Convert.ToInt32(txtNumOfPieces.Text) + ", lot_Barrel = " + Convert.ToInt32(txtBarrel.Text) + ", lot_Position = " + Convert.ToInt32(txtPosition.Text) + ", lot_Downtime = " + Convert.ToInt32(txtDownTime.Text) + ", lot_PullDateTime = #" + pullDateTime + "#, lot_PullOperator = " + Convert.ToInt32(pullOp) + ", lot_ToleranceIssue = '" + scrapcheck + "' WHERE lot_ID = " + Convert.ToInt32(this.lblLotNumber.Text);
                //MessageBox.Show(cmdUpdate.CommandText);
                cmdUpdate.Connection = dataconn;
                cmdUpdate.ExecuteNonQuery();
                cmdUpdate.Dispose();
            dataconn.Close();
            this.Close();
        }

        private void btnCancelLotEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDisplayLot_Click(object sender, EventArgs e)
        {
            string loadOperator = "";
            string pullOperator = "";
            //popluate fields
            try
            {
                OleDbCommand cmdLotInfo = new OleDbCommand();
                cmdLotInfo.CommandType = CommandType.Text;
                cmdLotInfo.CommandText = "SELECT * FROM tblLots WHERE lot_ID = " + this.cboSelectLot.SelectedValue;
                cmdLotInfo.Connection = dataconn;
                dataconn.Open();
                OleDbDataReader dR = cmdLotInfo.ExecuteReader();
                dR.Read();

                // get Operator Names
                if (Convert.ToString(dR["lot_Operator"]) != "")
                {
                    OleDbCommand cmdGetLoadOperator = new OleDbCommand();
                    cmdGetLoadOperator.CommandType = CommandType.Text;
                    cmdGetLoadOperator.CommandText = "SELECT operator_Name FROM tblOperators WHERE operator_ID = " + Convert.ToString(dR["lot_Operator"]);
                    cmdGetLoadOperator.Connection = dataconn;
                    OleDbDataReader dRLoader = cmdGetLoadOperator.ExecuteReader();
                    try
                    {
                        dRLoader.Read();
                        loadOperator = Convert.ToString(dRLoader["operator_Name"]);
                    }
                    catch (Exception exNames)
                    {
                        loadOperator = "Unknown";
                    }
                    finally
                    {
                        dRLoader.Close();
                    }

                }
                if (Convert.ToString(dR["lot_PullOperator"]) != "")
                {
                    OleDbCommand cmdGetPullOperator = new OleDbCommand();
                    cmdGetPullOperator.CommandType = CommandType.Text;
                    cmdGetPullOperator.CommandText = "SELECT operator_Name FROM tblOperators WHERE operator_ID = " + Convert.ToString(dR["lot_PullOperator"]);
                    cmdGetPullOperator.Connection = dataconn;
                    OleDbDataReader dRPuller = cmdGetPullOperator.ExecuteReader();
                    try
                    {
                        dRPuller.Read();
                        pullOperator = Convert.ToString(dRPuller["operator_Name"]);
                    }
                    catch (Exception exNames)
                    {
                        pullOperator = "Unknown";
                    }
                    finally
                    {
                        dRPuller.Close();
                    }

                }
                // end get operator names

                this.lblLotNumber.Text = Convert.ToString(dR["lot_ID"]);
                this.txtLoadDateTime.Text = Convert.ToString(dR["lot_LoadDateTime"]);
                this.txtOperator.Text = loadOperator;
                this.txtProduct.Text = Convert.ToString(dR["lot_Product"]);
                this.txtCoreAverageWeight.Text = Convert.ToString(dR["lot_CoreAverageWeight"]);
                double lotWeight = Convert.ToDouble(dR["lot_NumOfPieces"]) * Convert.ToDouble(dR["lot_CoreAverageWeight"]) / 7000; // using avgCoreWgt  coreWgt*7000(g/lb.) / avgCoreWgt
                this.txtNumOfPieces.Text = lotWeight.ToString("0");
                this.txtBarrel.Text = Convert.ToString(dR["lot_Barrel"]);
                this.txtPosition.Text = Convert.ToString(dR["lot_Position"]);
                this.txtDownTime.Text = Convert.ToString(dR["lot_DownTime"]);
                this.txtPullDateTime.Text = Convert.ToString(dR["lot_PullDateTime"]);
                this.txtPullOperator.Text = pullOperator;
                if (Convert.ToString(dR["lot_ToleranceIssue"]) == "Scrapped")
                    this.chkScrapped.Checked = true;
                dR.Close();
                cmdLotInfo.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Reading Selected Lot Information: " + ex, "Error");
            }
            finally
            {
                this.txtLoadDateTime.Visible = true;
                this.txtOperator.Visible = true;
                this.txtProduct.Visible = true;
                this.txtCoreAverageWeight.Visible = true;
                this.txtNumOfPieces.Visible = true;
                this.txtBarrel.Visible = true;
                this.txtPosition.Visible = true;
                this.txtDownTime.Visible = true;
                this.txtPullDateTime.Visible = true;
                this.txtPullOperator.Visible = true;
                this.chkScrapped.Visible = true;
                dataconn.Close();
            }
        }


    }
}
