using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.IO;

namespace CenterFireBulletWeighing
{
    public partial class frmCBWMainMenu : Form
    {
        OleDbConnection dataconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|centerfirebulletweighing.accdb");
        string platingStartDateTime = String.Empty;
        string platingCheckDateTime = String.Empty;
        string platingEstimatedPullDateTime = String.Empty;
        double lotPieces = 0;
        int totalPauseSeconds;

        public frmCBWMainMenu()
        {
            InitializeComponent();
        }

        private void btnLoadProduct_Click(object sender, EventArgs e)
        {
            this.tblProductsTableAdapter.Fill(this.dsProducts.tblProducts);
            this.tblOperatorsTableAdapter.Fill(this.dsOperators.tblOperators);
            
            clearForm();
            pnlScrap.Visible = false;
            pnlLoadSlip.Visible = false;

            this.dtPlatingStartDate.Value = DateTime.Now;
            this.dtPlatingStartTime.Value = DateTime.Now;
            this.btnScrapLot.Enabled = false;
            this.btnPerformCheck.Enabled = false;
            this.btnPlatingStatus.Enabled = false;
            this.btnProductionReport.Enabled = false;
            this.btnEditLot.Enabled = false;
            this.btnDBA.Enabled = false;
            
            this.pnlLoadProduct.Left = 185; this.pnlLoadProduct.Top = 150;
            this.pnlLoadProduct.Visible = true;

            // Fill position combo box with open positions
            this.cboPlaterPosition.Items.Clear();
            int[] takenpositions = new int[30];
            int x = 0;
                       
            try
            {
                OleDbCommand cmdTakenPositions = new OleDbCommand();
                cmdTakenPositions.CommandType = CommandType.Text;
                cmdTakenPositions.CommandText = "SELECT lot_Position FROM tblLots WHERE lot_PullDateTime IS NULL";
                cmdTakenPositions.Connection = dataconn;
                dataconn.Open();
                OleDbDataReader dR = cmdTakenPositions.ExecuteReader();
                while (dR.Read())
                {
                        takenpositions[x] = Convert.ToInt32(dR["lot_Position"]);
                        x++;
                }
                dR.Close();
                cmdTakenPositions.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Reading Taken Plating Positions: " + ex, "Error");
            }
            finally
            {
                dataconn.Close();
            }
            
            for (int i = 0; i < 31; i++)
            {
                bool takenflag = false;
                foreach (int takenpos in takenpositions)
                {
                    if (i == takenpos)
                    {
                        takenflag = true;
                    }
                }
                if (!takenflag) this.cboPlaterPosition.Items.Add(i); 
            }

        }

        private void frmCBWMainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'centerfirebulletweighingDataSet.tblLots' table. You can move, or remove it, as needed.
            //this.tblLotsTableAdapter1.Fill(this.centerfirebulletweighingDataSet.tblLots);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?  Have you backed up the database?", "Exit", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.btnBackup.Focus();
            }
        }

        private void btnPerformCheck_Click(object sender, EventArgs e)
        {
            dataConnTestBed dataConnTest = new dataConnTestBed();
            dataConnTest.Show();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            // Write New Lot Record in tblLots
            try
            {
                int lotID = Convert.ToInt32(txtLotNumber.Text);
                int lotOperator = Convert.ToInt32(cboOperator.SelectedValue);
                string lotProduct = this.cboProduct.Text;
                int lotBarrelNumber = Convert.ToInt32(cboBarrel.Text);
                int lotPlaterPosition = Convert.ToInt32(cboPlaterPosition.Text);
                double avgCoreWgt = Convert.ToDouble(this.txtAvgCoreWgt.Text);
                double coreWgt = Convert.ToDouble(this.cboLotWgt.Text);
                //Convert to coreWgt to pieces using avgCoreWgt  coreWgt*7000(g/lb.) / avgCoreWgt
                lotPieces = Math.Round(coreWgt * 7000 / avgCoreWgt, 0);

                // DB Command for INSERT
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tblLots (lot_ID, lot_Operator, lot_Product, lot_Barrel, lot_Position, lot_CoreAverageWeight, lot_NumOfPieces, lot_LoadDateTime, lot_DownTime, lot_CheckDateTime, lot_EstimatedPullDateTime) VALUES (" + lotID + ", " + lotOperator + ", '" + lotProduct + "', " + lotBarrelNumber + ", " + lotPlaterPosition + ", " + avgCoreWgt + ", " + lotPieces + ", #" + platingStartDateTime + "#, 0, #" + platingCheckDateTime + "#, #" + platingEstimatedPullDateTime + "#)";
                cmd.Connection = dataconn;

                // DB Command for updating plater position table with new lotID
                OleDbCommand cmdPosition = new OleDbCommand();
                cmdPosition.CommandType = CommandType.Text;
                cmdPosition.CommandText = "UPDATE tblPlaterPositions SET position_LotID = " + lotID + " WHERE position_Number = " + lotPlaterPosition;
                cmdPosition.Connection = dataconn;

                try
                {
                    dataconn.Open();
                    cmd.ExecuteNonQuery();
                    cmdPosition.ExecuteNonQuery();
                    this.btnAddRecord.Text = "Add Lot";

                    // Populate Load Slip for Print
                    this.loadslipLotNumber.Text = this.txtLotNumber.Text;
                    this.loadslipProduct.Text = this.cboProduct.Text;
                    this.loadslipOperator.Text = this.cboOperator.Text;
                    this.loadslipBarrel.Text = this.cboBarrel.Text;
                    this.loadslipPosition.Text = this.cboPlaterPosition.Text;
                    this.loadslipCoreAvgWgt.Text = this.txtAvgCoreWgt.Text;
                    this.loadslipPieces.Text = Convert.ToString(lotPieces);
                    this.loadslipLoadTime.Text = Convert.ToDateTime(platingStartDateTime).ToString("dd MMM yyyy    HH:mm");
                    this.pnlLoadSlip.Left = 185; this.pnlLoadSlip.Top = 150;
                    this.pnlLoadSlip.Visible = true;

                    // save file (jpg) and print load slip
                    Bitmap bmp = new Bitmap(this.pnlLoadSlip.Width, this.pnlLoadSlip.Height);
                    this.pnlLoadSlip.DrawToBitmap(bmp, new Rectangle(0, 0, this.pnlLoadSlip.Width, this.pnlLoadSlip.Height));
                    string loadSlipFile = "LoadSlip" + this.txtLotNumber.Text + ".jpg";
                    bmp.Save(loadSlipFile, System.Drawing.Imaging.ImageFormat.Jpeg);
                    PrintDocument documentToPrint = new PrintDocument();
                    documentToPrint.PrintPage += new PrintPageEventHandler(documentToPrint_PrintPage);
                    documentToPrint.Print();  
                    pnlLoadProduct.Visible = false;
                    MessageBox.Show("Lot #" + this.txtLotNumber.Text + " was successfully added!", "Confirmation");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in INSERTING new lot record OR in Updating position table: " + ex, "Error");
                }
                finally
                {
                    cmd.Dispose();
                    cmdPosition.Dispose();
                    dataconn.Close();
                    clearForm();
                }
                // 
                this.pnlLoadProduct.Visible = false;
                this.btnScrapLot.Enabled = true;
                this.btnPerformCheck.Enabled = true;
                this.btnPlatingStatus.Enabled = true;
                this.btnProductionReport.Enabled = true;
                this.btnEditLot.Enabled = true;
                this.btnDBA.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form Validation Error: " + ex, "Form Entry Error");
            }



        }

        private void documentToPrint_PrintPage(object sender, PrintPageEventArgs e)
        {
            string loadSlipFile = "LoadSlip" + this.txtLotNumber.Text + ".jpg";
            FileStream fs = new FileStream(loadSlipFile, FileMode.Open, FileAccess.Read);
            System.Drawing.Image image = System.Drawing.Image.FromStream(fs);

            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;
            int width = image.Width;
            int height = image.Height;

            //The following makes the image fit the page or close to the page ... based on the PrintPageEventArgs
            //if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
            //{
            //    width = e.MarginBounds.Width;
            //    height = image.Height * e.MarginBounds.Width / image.Width;
            //}
            //else
            //{
            //    height = e.MarginBounds.Height;
            //    width = image.Width * e.MarginBounds.Height / image.Height;
            //}
            System.Drawing.Rectangle destRect = new System.Drawing.Rectangle(x, y, width, height);
            e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
        }

        private void clearForm()
        {
            foreach (System.Windows.Forms.Control ctrControl in this.pnlLoadProduct.Controls)
            {
                //Loop through all controls
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    //Check to see if it's a textbox
                    ((System.Windows.Forms.TextBox)ctrControl).Text = string.Empty;
                    //If it is then set the text to String.Empty (empty textbox)
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    //Next check if it's a dropdown list
                    ((System.Windows.Forms.ComboBox)ctrControl).SelectedIndex = -1;
                    //If it is then set its SelectedIndex to 0
                }
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void txtLotNumber_LostFocus(object sender, EventArgs e)
        {
            if (this.pnlLoadProduct.Visible) //allow escape with button close
            {
                if (this.txtLotNumber.Text != String.Empty)
                {
                    try
                    {
                        int testLotID = Convert.ToInt32(this.txtLotNumber.Text);
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT lot_ID FROM tblLots";
                        cmd.Connection = dataconn;
                        dataconn.Open();
                        OleDbDataReader dR = cmd.ExecuteReader();
                        while (dR.Read())
                        {
                            if (Convert.ToInt32(dR["lot_ID"]) == testLotID)
                            {
                                MessageBox.Show("That lot number is already in use!", "User Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.txtLotNumber.Text = String.Empty;
                                this.txtLotNumber.Focus();
                            }
                        }
                        dR.Close();
                        cmd.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error - in Lost Focus Event");
                    }
                    finally
                    {
                        dataconn.Close();
                    }
                }
                else
                {
                    //MessageBox.Show("Please enter a valid new lot number!", "Error in Lot Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtLotNumber.Focus();
                }
            }
        }

        private void btnDBA_Click_1(object sender, EventArgs e)
        {
            frmDataUpdates dbaForm = new frmDataUpdates();
            dbaForm.Show();
            //this.Hide();
        }

        private void btnDoneAdding_Click(object sender, EventArgs e)
        {
            this.pnlLoadSlip.Visible = false;
            this.pnlLoadProduct.Visible = false;
            this.btnScrapLot.Enabled = true;
            this.btnPerformCheck.Enabled = true;
            this.btnPlatingStatus.Enabled = true;
            this.btnEditLot.Enabled = true;
            this.btnProductionReport.Enabled = true;
            this.btnDBA.Enabled = true;
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProduct.Text != String.Empty)
            {
                try
                {
                    // Code to get the correct Start Date and Time from two separate datetimepickers - control flaw to need two?
                    int spaceLocation1 = Convert.ToString(this.dtPlatingStartDate.Value).IndexOf(" ");  //date from datetimepicker
                    int spaceLocation2 = Convert.ToString(this.dtPlatingStartTime.Value).IndexOf(" ");  //time from datetimepicker
                    platingStartDateTime = Convert.ToString(this.dtPlatingStartDate.Value).Substring(0, spaceLocation1 + 1);  //isolate the date + space
                    platingStartDateTime = platingStartDateTime + Convert.ToString(this.dtPlatingStartTime.Value).Substring(spaceLocation2 + 1, Convert.ToString(this.dtPlatingStartTime.Value).Length - spaceLocation2 - 1);  //isolate the time and add it to the date

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT product_AvgPT FROM tblProducts WHERE product_ID = '" + this.cboProduct.Text + "'";
                    cmd.Connection = dataconn;
                    dataconn.Open();
                    OleDbDataReader dR = cmd.ExecuteReader();
                    dR.Read();
                    platingCheckDateTime = Convert.ToDateTime(platingStartDateTime).AddHours(Convert.ToDouble(dR["product_AvgPT"]) / 2).ToString("dd MMM yyyy    HH:mm");  //half the estimated time
                    this.loadslipCheckDateTime.Text = platingCheckDateTime;
                    platingEstimatedPullDateTime = Convert.ToDateTime(platingStartDateTime).AddHours(Convert.ToDouble(dR["product_AvgPT"])).ToString("dd MMM yyyy    HH:mm");
                    this.loadslipEstimatedCompletion.Text = platingEstimatedPullDateTime;
                    dR.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error - Product AvgPT Lookup");
                }
                finally
                {
                    dataconn.Close();
                }
            }
        }

        private void btnPlatingStatus_Click(object sender, EventArgs e)
        {
            frmStatusReport reports = new frmStatusReport();
            reports.Show();
        }

        private void btnProductionReport_Click(object sender, EventArgs e)
        {
            frmProductionReports reports = new frmProductionReports();
            reports.Show();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string dbpath = Environment.CurrentDirectory + @"\centerfirebulletweighing.accdb";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string dbbackuppath = fbd.SelectedPath.ToString();
                File.Copy(dbpath, dbbackuppath + @"\cfbw" + DateTime.Now.ToString("ddMMMyyyy") + ".accdb", true);
                MessageBox.Show("Back Up Successfull!");
            }
        }

        private void btnScrapLot_Click(object sender, EventArgs e)
        {
            pnlScrap.Left = 185; pnlScrap.Top = 150; // move panel to desired location on screen
                       
            btnLoadProduct.Enabled = false;
            this.tblLotsTableAdapter.FillByCurrentLots(this.dsLots.tblLots);
            pnlLoadProduct.Visible = false;
            pnlLoadSlip.Visible = false;
            pnlScrap.Visible = true;
        }

        private void btnExitScrap_Click(object sender, EventArgs e)
        {
            btnLoadProduct.Enabled = true;
            pnlScrap.Visible = false;
        }

        private void btnScraptheLot_Click(object sender, EventArgs e)
        {
            // update toleranceissue (note) + update scrap count + 'pull lot'
            try
            {
                OleDbCommand cmdScrap = new OleDbCommand();
                cmdScrap.CommandType = CommandType.Text;
                cmdScrap.CommandText = "UPDATE tblLots SET lot_ToleranceIssue = 'Scrapped', lot_PullDateTime = #" + DateTime.Now + "#, lot_Scrap = " + lotPieces + " WHERE lot_ID = " + Convert.ToInt32(this.cboLotToScrap.Text);
                cmdScrap.Connection = dataconn;
                dataconn.Open();
                cmdScrap.ExecuteNonQuery();
                cmdScrap.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Updating the Scrap Notification on a Lot" + ex, "error");
            }
            finally
            {
                dataconn.Close();
            }
            // clean up
            this.btnLoadProduct.Enabled = true;
            this.pnlScrap.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e) // NOTE: **** button1 is the pause button 
        {
            this.pnlPause.Visible = true;
            this.btnPause.Enabled = false;
            this.tblLotsTableAdapter.FillByCurrentLots(this.dsLots.tblLots);
        }

        private void timerPause_Tick(object sender, EventArgs e)
        {
            totalPauseSeconds = totalPauseSeconds + 1;
            int theSeconds = totalPauseSeconds % 60;
            int theMinutes = totalPauseSeconds / 60;
            this.lblPauseTime.Text = string.Format("{0}:{1:00}", theMinutes, theSeconds);
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            int downTime = 0;
            // stop the pause clock
            this.timerPause.Enabled = false;
            //only if significant (what is significant > 1 minute ?)
            if (totalPauseSeconds > 1)
            {
                downTime = totalPauseSeconds / 60;
                updateCheckPullTimes(downTime);
            }
            //cleanup
            this.lblPauseTime.Text = "0";
            totalPauseSeconds = 0;

            this.pnlPause.Visible = false;
            this.btnLoadProduct.Enabled = true;
            this.btnScrapLot.Enabled = true;
            this.btnPause.Enabled = true;
            this.btnPerformCheck.Enabled = true;
            this.btnPlatingStatus.Enabled = true;
            this.btnProductionReport.Enabled = true;
            this.btnEditLot.Enabled = true;
            this.btnDBA.Enabled = true;
        }

        //private void btnManualPause_Click(object sender, EventArgs e)
        //{
        //    int downTime = 0;
        //    if (Int32.TryParse(this.txtManualPauseTime.Text, out downTime))
        //    {
        //        updateCheckPullTimes(downTime);
        //    }
        //    else
        //    {
        //        this.lblPauseMessage.Text = "A valid down time in minutes was not entered!";
        //    }

        //}

        private void updateCheckPullTimes(int dTime)
        {
            // update the tblLot database for lots in the ListBoxActivePause, downtime, checkDateTime, and EstimatedPull
            int totalDownTime = 0;
            string newCheckDateTime = String.Empty;
            string newPullDateTime = String.Empty;
            try
            {
               OleDbCommand cmdGet = new OleDbCommand();
               cmdGet.CommandType = CommandType.Text;
               cmdGet.CommandText = "SELECT lot_ID, lot_DownTime, lot_CheckDateTime, lot_EstimatedPullDateTime FROM tblLots WHERE IsNull(lot_PullDateTime)";
                    
               cmdGet.Connection = dataconn;
               dataconn.Open();
               OleDbDataReader dr = cmdGet.ExecuteReader();
               if (dr.HasRows)
               {
                   while (dr.Read())
                   {
                       // UPDATE SELECTED LOTS ONLY
                       
                       if (lstActivePause.Items.Contains(dr.GetInt32(0)))
                       {    
                        OleDbCommand cmdUpdate = new OleDbCommand();
                        cmdUpdate.CommandType = CommandType.Text;
                        // accumulate downtime dr(1) will be 0 if this is the first pause
                        totalDownTime = dr.GetInt32(1) + dTime;
                            
                        // if checkdatetime is greater than current datetime, adjust 
                        if (dr.GetDateTime(2) > DateTime.Now)
                           newCheckDateTime = dr.GetDateTime(2).AddMinutes(dTime).ToString();
                        else
                           newCheckDateTime = dr.GetDateTime(2).ToString();
                        // update estimated pullDateTime
                        newPullDateTime = dr.GetDateTime(3).AddMinutes(dTime).ToString();
                        cmdUpdate.CommandText = "UPDATE tblLots SET lot_DownTime = " + totalDownTime + ", lot_EstimatedPullDateTime = #" + newPullDateTime + "#, lot_CheckDateTime = #" + newCheckDateTime + "# WHERE lot_ID = " + dr.GetInt32(0);
                            
                        cmdUpdate.Connection = dataconn;
                        cmdUpdate.ExecuteNonQuery();
                        cmdUpdate.Dispose();
                       }
                   }
               }                        
               dr.Close();
               cmdGet.Dispose();
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error in updating the down time on the active lots.  " + ex, "error");
            }
            finally
            {
               dataconn.Close();
            }
            //cleanup
            this.lblPauseTime.Text = "0";
            totalPauseSeconds = 0;

            this.pnlPause.Visible = false;
            this.btnLoadProduct.Enabled = true;
            this.btnScrapLot.Enabled = true;
            this.btnPause.Enabled = true;
            this.btnPerformCheck.Enabled = true;
            this.btnPlatingStatus.Enabled = true;
            this.btnProductionReport.Enabled = true;
            this.btnEditLot.Enabled = true;
            this.btnDBA.Enabled = true;
        }


        private void btnStartPausing_Click(object sender, EventArgs e)
        {
            // enable the timer 
            this.lblPauseTime.Visible = true;
            this.timerPause.Enabled = true;
        }

        private void btnPauseCancel_Click(object sender, EventArgs e)
        {
            this.pnlPause.Visible = false;
        }

        private void btnEditLot_Click(object sender, EventArgs e)
        {
            frmLogin adminLogin = new frmLogin();
            adminLogin.Show();
        }


        private void fillActivePauseListBox(object sender, EventArgs e)
        {
            if (lstPauseSelection.SelectedItem != null)
                lstActivePause.Items.Add(lstPauseSelection.SelectedValue);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            lstActivePause.Items.Clear();
            int i;
            for (i = 0; i < lstPauseSelection.Items.Count;  i++)
            {
                lstPauseSelection.SetSelected(i, true);
                lstActivePause.Items.Add(lstPauseSelection.SelectedValue);                            
            }
            btnSelectAll.Enabled = false;
            lstPauseSelection.SetSelected(i-1, false);

            // Not working on displayed values ******************************
            //object[] objLots = new object[lstPauseSelection.Items.Count];
            //lstPauseSelection.Items.CopyTo(objLots, 0);
            //lstActivePause.Items.AddRange(objLots);
        }

        private void RemoveLot(object sender, EventArgs e)
        {
            lstActivePause.Items.RemoveAt(lstActivePause.SelectedIndex);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

 

      
    }
}
