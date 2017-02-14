using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Data.OleDb;

namespace CenterFireBulletWeighing
{
    public partial class dataConnTestBed : Form
    {
        SerialPort _sp;                 // main serial_port object
        DateTime currentTime;
        DateTime firstTime;
        DateTime estimatedCompletionDateTime;
        string platingMessage = string.Empty;

        double SCALE_STABLIZATION_TIME = 3.3; //this may vary from scale to scale - AV53 - recording stablizations
        int MIN_SAMPLES = 7;            //minimum number of samples (should be set to standard - the more the better for the histogram
        int NUMBER_OF_BINS = 7;         // MOVE THIS DOWN - for histogram construct - the number of equal sized bins for the horizontal graph

        OleDbConnection dataconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|centerfirebulletweighing.accdb");

        private delegate void SetTextDeleg(string text);

        public dataConnTestBed()
        {
            InitializeComponent();
        }

        private void dataConnTestBed_Load(object sender, EventArgs e)
        {
            // fill combo boxes
            this.tblLotsTableAdapter.FillByCurrentLots(this.dsLots.tblLots);
            this.tblOperatorsTableAdapter.Fill(this.dsOperators.tblOperators);


            // initialize action buttons
            this.btnContinue.Visible = false;
            this.btnPrint.Visible = false;
            this.btnReset.Visible = true;

            // the following is for testing com ports only
            foreach (string s in SerialPort.GetPortNames())
                this.availablePorts.Items.Add(s);

            _sp = new SerialPort("COM1", 2400, Parity.None, 7, StopBits.One);
            _sp.Handshake = Handshake.XOnXOff;
            _sp.DataReceived += new SerialDataReceivedEventHandler(sp_dr);
            _sp.ReadTimeout = 2000;  // 2 seconds
            //_sp.WriteTimeout = 500;
            _sp.Open();

            // Get Product in case the default item in the lotID combo box does not need to be changed
            getProductSpecs();

        }

        private void dataConnTestBed_Unload(object sender, EventArgs e)
        {
            _sp.Close();
        }

        void sp_dr(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(500);
                string data = _sp.ReadLine();
                this.BeginInvoke(new SetTextDeleg(si_dr), new object[] { data });
            }
            catch (TimeoutException)
            {
                MessageBox.Show("The operation timed out.  Please check the scale.", "Operation Error");
            } 
        }

        private void si_dr(string data)
        {
           currentTime = DateTime.Now;
           TimeSpan span = currentTime.Subtract(firstTime);
           if (span.Seconds < SCALE_STABLIZATION_TIME)
           {
            double averageWeight = (Convert.ToDouble(data.Trim()) + Convert.ToDouble(listBox1.Items[listBox1.Items.Count - 1])) / 2;
            listBox1.Items.RemoveAt(listBox1.Items.Count-1);
            this.listBox1.Items.Add(Convert.ToString(averageWeight)); //this is for without container
           }
           else
           {
            //string theWeight = Convert.ToString(Convert.ToDouble(data.Trim()) - Convert.ToDouble(lblPreviousWeight.Text)); //container
            //this.listBox1.Items.Add(theWeight); //  TARE container
            this.listBox1.Items.Add(data.Trim());
            this.lblBulletCount.Text = Convert.ToString(Convert.ToInt32(lblBulletCount.Text) + 1);
            this.lblSampleCount2.Text = this.lblBulletCount.Text;
            firstTime = DateTime.Now;
            //lblPreviousWeight.Text = data.Trim(); //container
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Reset Button
            listBox1.Items.Clear();
            lblBulletCount.Text = "0";
            pnlHistogram.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _sp.Close();
            this.Close();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete the selected sample?","Delete Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                lblBulletCount.Text = Convert.ToString(listBox1.Items.Count);
                this.lblSampleCount2.Text = lblBulletCount.Text;
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            _sp.Close();  // Close down the Serial Port

            if (listBox1.Items.Count >= MIN_SAMPLES)
            {
                DateTime platingDateTime = Convert.ToDateTime(DateTime.Now.ToString("dd MMM yyyy   HH:mm"));
                double[] platingsample = new double[listBox1.Items.Count];               
                
                // Populate platingSample array
                for(int i=0;i<=(listBox1.Items.Count-1);i++)
                {
                  // Array population
                    string temp = Convert.ToString(listBox1.Items[i]);
                    temp = temp.Trim();
                    platingsample[i] = Convert.ToDouble(temp);
                }
                
                // statistics construct ************** MAJOR PART ******************************
                sampleStatistics(platingsample);

                // finalize the labels shown on the Histogram Panel
                this.lblDateTime.Text = platingDateTime.ToString("dd MMM yyyy   HH:mm");
                this.lblL.Text = this.cboLot.Text;
                this.lblOp.Text = this.cboOperator.Text;
                this.pnlHistogram.Visible = true;
                this.btnReset.Enabled = false;
                this.btnRecord.Enabled = false;
            }
            else
            {
                MessageBox.Show("Invalid operator or lot or not enough valid samples were recorded!", "Error");
            }
        }

        public void sampleStatistics(double[] Values)
        {
            double sumOfValuesSquared = 0;
            double sumOfValues = 0;
            double binWidth = 0;
            double sampleAverage = 0;
            //double sampleMedian = 0;
            double sampleStdev = 0;
            double A2;  //A2 factor - using sample Range
            double d2;  //d2 factor - estimate of process standard deviation
            double LCL;
            double UCL;
            //double threeSigmaLCL;
            //double threeSigmaUCL;
            double avgCoreWeight = 0;   // Product's Average Core Weight as measured on LOAD
            double avgPlatingTime = 0;
            double gph = 0; // plating rate
            double targetLCL = 0;
            double targetUCL = 0;
            double targetAverage = 0;

            int lotID = Convert.ToInt32(cboLot.SelectedValue);
            int platingOperator = Convert.ToInt32(cboOperator.SelectedValue);
            
            //Sample Statistics - mean, median, stdev, low, high
            foreach (double item in Values) {sumOfValues += item;}
            sampleAverage = sumOfValues / Values.Length;
            lblSampleAverage.Text = Convert.ToString(Math.Round(sampleAverage, 2));
            lblSampleAverage2.Text = lblSampleAverage.Text;

            //sampleMedian = Math.Round(Values.Length / 2,0); // this is location only

            foreach (double item in Values) { sumOfValuesSquared += Math.Pow(item, 2); }
            sampleStdev =  Math.Sqrt((sumOfValuesSquared - Math.Pow(sumOfValues, 2) / Values.Length) / (Values.Length - 1));
            lblStdev.Text =  Convert.ToString(Math.Round(sampleStdev,2));

            lblLow.Text = Convert.ToString(Math.Round(Values.Min(),2));
            lblHigh.Text = Convert.ToString(Math.Round(Values.Max(),2));

            //Sample Statistics continued - LCL, UCL and Stated Tolerance LCL, UCL 
            // two methods show here for getting LCL, UCL
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dataconn;
            dataconn.Open();
            cmd.CommandText = "SELECT A2, d2 FROM tblControlChartFactors WHERE n = " + Values.Length;
            OleDbDataReader dR = cmd.ExecuteReader();
            dR.Read();
              A2 = Convert.ToDouble(dR["A2"]);
              d2 = Convert.ToDouble(dR["d2"]);
            dR.Close();
            cmd.Dispose();
            dataconn.Close();
            //LCL = sampleAverage - A2 * (Values.Max() - Values.Min());
            //UCL = sampleAverage + A2 * (Values.Max() - Values.Min());
            LCL = sampleAverage - (3 * (Values.Max() - Values.Min()) / d2);
            UCL = sampleAverage + (3 * (Values.Max() - Values.Min()) / d2);
            this.lblLCL.Text = Convert.ToString(Math.Round(LCL, 2));
            this.lblUCL.Text = Convert.ToString(Math.Round(UCL, 2));
            this.lblLCL2.Text = Convert.ToString(Math.Round(LCL, 2));  // a copy
            this.lblUCL2.Text = Convert.ToString(Math.Round(UCL, 2));  // a copy

            // 3 sigma calculations
            //threeSigmaLCL = sampleAverage - (3 * sampleStdev);
            //threeSigmaUCL = sampleAverage + (3 * sampleStdev);
            //this.lbl3sigmaLower.Text = Convert.ToString(Math.Round(threeSigmaLCL, 2));
            //this.lbl3sigmaUpper.Text = Convert.ToString(Math.Round(threeSigmaUCL, 2));


            // Retrieve TARGET mean, LCL, UCL, GPH for given product line
            if (this.lblProduct.Text != String.Empty)
            {
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.Connection = dataconn;
                dataconn.Open();
                cmd2.CommandText = "SELECT * FROM tblProducts WHERE product_ID = '" + this.lblProduct.Text + "'";
                OleDbDataReader dR2 = cmd2.ExecuteReader();
                dR2.Read();
                  avgPlatingTime = Convert.ToDouble(dR2["product_AvgPT"]);
                  targetLCL = Convert.ToDouble(dR2["product_PlatedLowerTolerance"]);
                  targetUCL = Convert.ToDouble(dR2["product_PlatedUpperTolerance"]);
                  targetAverage = Convert.ToDouble(dR2["product_PlatedTargetAverage"]);
                dR2.Close();
                cmd2.Dispose();
                dataconn.Close();
                // Label Output for Tolerances
                this.lblTargetLCL.Text = Convert.ToString(targetLCL);
                this.lblTargetLCL2.Text = Convert.ToString(targetLCL);
                this.lblTargetUCL.Text = Convert.ToString(targetUCL);
                this.lblTargetUCL2.Text = Convert.ToString(targetUCL);
                this.lblTargetAverage.Text = Convert.ToString(targetAverage);
            }
            
            //Retrieve Start Date/Time for Loaded Lot
                OleDbCommand cmdLoadTime = new OleDbCommand();
                cmdLoadTime.CommandType = CommandType.Text;
                cmdLoadTime.Connection = dataconn;
                dataconn.Open();
                cmdLoadTime.CommandText = "SELECT lot_LoadDateTime, lot_CoreAverageWeight FROM tblLots WHERE lot_ID = " + this.cboLot.Text;
                OleDbDataReader dRcmdLoadTime = cmdLoadTime.ExecuteReader();
                dRcmdLoadTime.Read();
                  DateTime lotLoadTime = Convert.ToDateTime(dRcmdLoadTime["lot_LoadDateTime"]);
                  avgCoreWeight = Convert.ToDouble(dRcmdLoadTime["lot_CoreAverageWeight"]);
                  dRcmdLoadTime.Close();
                cmdLoadTime.Dispose();
                dataconn.Close();

            // Calculate Status Information - message to operator and for database record
            TimeSpan ts = DateTime.Now - lotLoadTime;  // plating time in time
            double platingTimeInHours = ts.TotalMinutes / 60;
            gph = Math.Round((sampleAverage - avgCoreWeight) / platingTimeInHours,4);
            this.lblGPH.Text = Convert.ToString(gph);
            double estimatedTimeRemaining = ((platingTimeInHours)/(sampleAverage-avgCoreWeight))*(targetAverage-sampleAverage); // in hours
            estimatedCompletionDateTime = DateTime.Now.AddHours(estimatedTimeRemaining);

            string operatorMsg = String.Empty;
            // Calculate a tenth of an hour plating in grains ( 6 minutes tolerance for operations )
            double OP_TOLERANCE = gph * .10; // in grains so .5 gph would be .05 grains
            
            // First check to see if lot should be pulled now 
            if (sampleAverage >= targetAverage-OP_TOLERANCE)
            {
                operatorMsg = "PULL LOT";
                platingMessage = "Pulled";
                this.btnPrint.Visible = true;
                this.btnReset.Visible = false;
                this.btnExit.Enabled = false;

                // Now check to see if the lot is OUT OF TOLERANCE
                if (LCL < targetLCL || UCL > targetUCL)
                {
                    operatorMsg = operatorMsg + ", CONTACT YOUR SUPERVISOR";
                    platingMessage = "Flagged";
                }

            }
            // Else give option to pull if it is lower but within tolerance
            else if (sampleAverage >= targetLCL - OP_TOLERANCE)
            {
                operatorMsg = "WITHIN TOLERANCE - PULL NOW or PULL AT: " + estimatedCompletionDateTime.ToString("HH:mm   dd MMM yyyy"); 
                platingMessage = "Option to Pull";
                this.btnPrint.Visible = true;
                this.btnContinue.Visible = true;
            }
            // Otherwise show estimated pull date and time
            else
            {
                operatorMsg = "ESTIMATED PULL: " + estimatedCompletionDateTime.ToString("HH:mm   dd MMM yyyy");
                platingMessage = "Continued Plating";
            }
            
            this.txtMsg.Text = operatorMsg;

            // Make platingCheckID which is the lot number + the average sample weight **************************************************************
            string platingCheckID = Convert.ToString(lotID) + DateTime.Now.ToString("ddMMMyyyyHHmm");


            #region Write Plating Check Record + Samples to Database
            // WRITE Plating Check record to db
                     
            OleDbCommand cmdWriteStatus = new OleDbCommand();
            cmdWriteStatus.CommandType = CommandType.Text;
            cmdWriteStatus.Connection = dataconn;
            cmdWriteStatus.CommandText = "INSERT INTO tblPlatingCheck (platingcheck_ID, platingcheck_Lot, platingcheck_Operator, platingcheck_DateTime, platingcheck_SampleSize, platingcheck_SampleAverage, platingcheck_SampleStdev, platingcheck_GPH, platingcheck_SampleLCL, platingcheck_SampleUCL, platingcheck_High, platingcheck_Low, platingcheck_Estimate, platingcheck_Action) VALUES ('" + platingCheckID + "', " + lotID + ", " + platingOperator + ", #" + DateTime.Now + "#, " + Values.Length + ", " + sampleAverage + ", " + sampleStdev + ", " + gph + ", " + LCL + ", " + UCL + ", " + Values.Max() + ", " + Values.Min() + ", #" + estimatedCompletionDateTime + "#, '" + platingMessage + "')";
            try
            {
                dataconn.Open();
                cmdWriteStatus.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing plating status record: " + ex, "Error");
            }
            finally
            {
                cmdWriteStatus.Dispose();
                dataconn.Close();
            }

            // WRITE sample measurements to the tblSample table in the database
            OleDbCommand cmdWriteSamples = new OleDbCommand();
            cmdWriteSamples.CommandType = CommandType.Text;
            cmdWriteSamples.Connection = dataconn;
            try
            {
                dataconn.Open();
                for (int i = 0; i < Values.Length; i++)
                {
                    cmdWriteSamples.CommandText = "INSERT INTO tblSamples (sample_PlatingCheckID, sample_Measurement) VALUES ('" + platingCheckID + "', " + Convert.ToDouble(Values[i]) + ")";
                    cmdWriteSamples.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing sample into record: " + ex, "Error");
            }
            finally
            {
                cmdWriteSamples.Dispose();
                dataconn.Close();
            }
            #endregion


            #region Histogram Construction

            // Draw Histogram
            // reset bar heights and locations
            pnlBar1.Height = 0; pnlBar1.Top = this.pnlHorizontalLine.Top;
            pnlBar2.Height = 0; pnlBar2.Top = this.pnlHorizontalLine.Top;
            pnlBar3.Height = 0; pnlBar3.Top = this.pnlHorizontalLine.Top;
            pnlBar4.Height = 0; pnlBar4.Top = this.pnlHorizontalLine.Top;
            pnlBar5.Height = 0; pnlBar5.Top = this.pnlHorizontalLine.Top;
            pnlBar6.Height = 0; pnlBar6.Top = this.pnlHorizontalLine.Top;
            pnlBar7.Height = 0; pnlBar7.Top = this.pnlHorizontalLine.Top;

            // reset displayed counters for each histo bar
            lblBar1Count.Text = "0";
            lblBar2Count.Text = "0";
            lblBar3Count.Text = "0";
            lblBar4Count.Text = "0";
            lblBar5Count.Text = "0";
            lblBar6Count.Text = "0";
            lblBar7Count.Text = "0";


            //Bin Width in GN
            binWidth = Math.Round((Values.Max() - Values.Min()) / NUMBER_OF_BINS,2);
            double pixel_ratio = pnlBar4.Width / binWidth; // pnlBar4 is the middle bin represents the fixed width of the bars on the histogram 
            this.label1.Text = Convert.ToString(binWidth); // +"  PX:" + Convert.ToString(binWidthPixels);

            // Draw Control Limits using panels :-) - I know, I know .. crazy but simple
            this.pnlLCL.Left = pnlSampleAverage.Left - Convert.ToInt16((sampleAverage - LCL) * pixel_ratio);
            this.pnlUCL.Left = pnlSampleAverage.Left + Convert.ToInt16((UCL - sampleAverage) * pixel_ratio);
            
            // Draw 3 Sigma Control Limits
            //this.pnl3sLCL.Left = pnlSampleAverage.Left - Convert.ToInt16((sampleAverage - threeSigmaLCL) * pixel_ratio);
            //this.pnl3sUCL.Left = pnlSampleAverage.Left + Convert.ToInt16((threeSigmaUCL - sampleAverage) * pixel_ratio);

            // The Target Upper and Lower Control Limits need to be adjusted according to the sample mean
            this.pnlTargetLCL.Left = pnlSampleAverage.Left - Convert.ToInt32((sampleAverage - targetLCL) * pixel_ratio);
            this.pnlTargetUCL.Left = pnlSampleAverage.Left + Convert.ToInt32((targetUCL - sampleAverage) * pixel_ratio);

            // move control limit labels to match up with these panel lines
            int TEXTADJ = 5;  // nudging items to the left a bit - in pixels
            this.lblLCL2.Left = this.pnlLCL.Left - TEXTADJ;   // pixels
            this.lblUCL2.Left = this.pnlUCL.Left - TEXTADJ;
            this.lblTargetLCL2.Left = this.pnlTargetLCL.Left - TEXTADJ;
            this.lblTargetUCL2.Left = this.pnlTargetUCL.Left - TEXTADJ;
            //this.lbl3sLCL.Left = this.pnl3sLCL.Left - TEXTADJ;
            //this.lbl3sUCL.Left = this.pnl3sUCL.Left - TEXTADJ;


            double startingBinLowerLimit = Values.Min();
            // start with the mean and go 


            // populate the bins with the values in the listbox array
            foreach (double item in Values)
            {
                if (item >= sampleAverage - binWidth / 2 && item < sampleAverage + binWidth/2)  // Bin 4 (middle)
                {
                    this.pnlBar4.Height = this.pnlBar4.Height + 30; // 30 pixels = 1 sample count
                    this.pnlBar4.Top = this.pnlBar4.Top - 30;
                    this.lblBar4Count.Text = Convert.ToString(Convert.ToInt16(lblBar4Count.Text) + 1);
                }
                else if (item >= sampleAverage - (binWidth / 2 + binWidth) && item < sampleAverage - binWidth / 2)  // Bin 3

                {
                    this.pnlBar3.Height = this.pnlBar3.Height + 30;
                    this.pnlBar3.Top = this.pnlBar3.Top - 30;
                    this.lblBar3Count.Text = Convert.ToString(Convert.ToInt16(lblBar3Count.Text) + 1);
                }
                else if (item >= sampleAverage - (binWidth / 2 + 2 * binWidth) && item < sampleAverage - (binWidth / 2 + binWidth))  // Bin 2
                {
                    this.pnlBar2.Height = this.pnlBar2.Height + 30;
                    this.pnlBar2.Top = this.pnlBar2.Top - 30;
                    this.lblBar2Count.Text = Convert.ToString(Convert.ToInt16(lblBar2Count.Text) + 1);
                }
                //else if (item >= sampleAverage - (binWidth / 2 + 3 * binWidth) && item < sampleAverage - (binWidth / 2 + 2 * binWidth))  
                else if (item < sampleAverage - (binWidth / 2 + 2 * binWidth))  // Bin 1
               {
                    this.pnlBar1.Height = this.pnlBar1.Height + 30;
                    this.pnlBar1.Top = this.pnlBar1.Top - 30;
                    this.lblBar1Count.Text = Convert.ToString(Convert.ToInt16(lblBar1Count.Text) + 1);
                }
                else if (item >= sampleAverage + binWidth / 2 && item < sampleAverage + (binWidth / 2 + binWidth))  // Bin 5
                {
                    this.pnlBar5.Height = this.pnlBar5.Height + 30;
                    this.pnlBar5.Top = this.pnlBar5.Top - 30;
                    this.lblBar5Count.Text = Convert.ToString(Convert.ToInt16(lblBar5Count.Text) + 1);
                }
                else if (item >= sampleAverage + (binWidth / 2 + binWidth) && item < sampleAverage + (binWidth / 2 + 2 * binWidth))  // Bin 6
                {
                    this.pnlBar6.Height = this.pnlBar6.Height + 30;
                    this.pnlBar6.Top = this.pnlBar6.Top - 30;
                    this.lblBar6Count.Text = Convert.ToString(Convert.ToInt16(lblBar6Count.Text) + 1);
                }
                else if (item >= sampleAverage + (binWidth / 2 + 2 * binWidth))// && item < sampleAverage + (binWidth / 2 + 3 * binWidth))  // Bin 7
                {
                    this.pnlBar7.Height = this.pnlBar7.Height + 30;
                    this.pnlBar7.Top = this.pnlBar7.Top - 30;
                    this.lblBar7Count.Text = Convert.ToString(Convert.ToInt16(lblBar7Count.Text) + 1);
                }
                else 
                {
                    MessageBox.Show("Outlier - check values", "Error in bin calcs");
                }
            }

            // Move the bin count labels to directly above the bars
            int LEFTADJ = 4;  // nudging items to the left a bit - in pixels
            this.lblBar1Count.Left = this.pnlBar1.Left + LEFTADJ;
            this.lblBar1Count.Top = this.pnlBar1.Top - this.lblBar1Count.Height;
            this.lblBar2Count.Left = this.pnlBar2.Left + LEFTADJ;
            this.lblBar2Count.Top = this.pnlBar2.Top - this.lblBar1Count.Height;
            this.lblBar3Count.Left = this.pnlBar3.Left + LEFTADJ;
            this.lblBar3Count.Top = this.pnlBar3.Top - this.lblBar1Count.Height;
            this.lblBar4Count.Left = this.pnlBar4.Left + LEFTADJ;
            this.lblBar4Count.Top = this.pnlBar4.Top - this.lblBar1Count.Height;
            this.lblBar5Count.Left = this.pnlBar5.Left + LEFTADJ;
            this.lblBar5Count.Top = this.pnlBar5.Top - this.lblBar1Count.Height;
            this.lblBar6Count.Left = this.pnlBar6.Left + LEFTADJ;
            this.lblBar6Count.Top = this.pnlBar6.Top - this.lblBar1Count.Height;
            this.lblBar7Count.Left = this.pnlBar7.Left + LEFTADJ;
            this.lblBar7Count.Top = this.pnlBar7.Top - this.lblBar1Count.Height;
            #endregion

            updateLotRecord();

        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            // Lot to be pulled with the click of this button
            // Write PullDateTime information to tblLots for this lot
            OleDbCommand cmdWritePullData = new OleDbCommand();
            cmdWritePullData.CommandType = CommandType.Text;
            cmdWritePullData.Connection = dataconn;
            try
            {
                dataconn.Open();
                cmdWritePullData.CommandText = "UPDATE tblLots SET lot_PullDateTime = #" + DateTime.Now + "#, lot_PullOperator = '" + this.cboOperator.SelectedValue + "', lot_ToleranceIssue = '" + platingMessage + "'  WHERE lot_ID = " + Convert.ToInt32(this.lblL.Text);
                cmdWritePullData.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing Pull Date/Time to Lot Record: " + ex, "Error");
            }
            finally
            {
                cmdWritePullData.Dispose();
                dataconn.Close();
            }
            // Draw and store() and then print image of histogram data
            Bitmap bmp = new Bitmap(this.pnlHistogram.Width, this.pnlHistogram.Height);
            this.pnlHistogram.DrawToBitmap(bmp, new Rectangle(0, 0, this.pnlHistogram.Width, this.pnlHistogram.Height));
            string histogramFile = "Histo" + this.lblL.Text + ".jpg";
            bmp.Save(histogramFile, System.Drawing.Imaging.ImageFormat.Jpeg);
            PrintDocument documentToPrint = new PrintDocument();
            documentToPrint.PrintPage += new PrintPageEventHandler(documentToPrint_PrintPage);
            documentToPrint.Print();
            _sp.Close();
            this.Close();
        }

        private void documentToPrint_PrintPage(object sender, PrintPageEventArgs e)
        {
            string histogramFile = "Histo" + this.lblL.Text + ".jpg";
            FileStream fs = new FileStream(histogramFile, FileMode.Open, FileAccess.Read);
            System.Drawing.Image image = System.Drawing.Image.FromStream(fs);

            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;
            int width = image.Width;
            int height = image.Height;

            if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
            {
                width = e.MarginBounds.Width;
                height = image.Height * e.MarginBounds.Width / image.Width;
            }
            else
            {
                height = e.MarginBounds.Height;
                width = image.Width * e.MarginBounds.Height / image.Height;
            }
            System.Drawing.Rectangle destRect = new System.Drawing.Rectangle(x, y, width, height);
            e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
        }

        private void cboLot_SelectedIndexChanged(object sender, EventArgs e)
        {
            getProductSpecs();
            this.btnRecord.Focus();
        }

        private void getProductSpecs()
        {
            //This sub provides the correct product based on the lot selected
            // Critical because the histogram labels and construct are based upon the product tolerances
            if (this.cboLot.Text != String.Empty && this.pnlHistogram.Visible == false)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = dataconn;
                dataconn.Open();
                //cmd.CommandText = "SELECT tblLots.lot_ID, tblLots.lot_Product FROM tblProducts INNER JOIN tblLots ON tblProducts.[product_ID] = tblLots.[lot_Product] WHERE tblLots.lot_ID = " + this.cboLot.Text;
                cmd.CommandText = "SELECT tblLots.lot_Product FROM tblLots WHERE tblLots.lot_ID = " + this.cboLot.Text;
                OleDbDataReader dR = cmd.ExecuteReader();
                dR.Read();
                this.lblProduct.Text = Convert.ToString(dR["lot_Product"]);   // THIS IS ALL WE DO/RETURN
                dR.Close();
                cmd.Dispose();
                dataconn.Close();
            }
        }


        private void btnContinue_Click(object sender, EventArgs e)
        {
            _sp.Close();
            this.Close();
        }


        private void updateLotRecord()
        {
                      
            // Get current GPH and scrap pieces for lot in order to update the average GPH
            double avgGPH = 0;
            double accumGPH = 0;
            int platingcheckcount = 0;
            int totalSamples = 0;
            
            // Computer Average GPH using all plating checks for a particular lot
            OleDbCommand cmdGPH = new OleDbCommand();
            cmdGPH.CommandType = CommandType.Text;
            cmdGPH.Connection = dataconn;
            cmdGPH.CommandText = "SELECT tblPlatingCheck.platingcheck_GPH FROM tblPlatingCheck WHERE tblPlatingCheck.platingcheck_Lot = " + Convert.ToInt32(this.cboLot.Text);
            try
            {
                dataconn.Open();
                OleDbDataReader dR = cmdGPH.ExecuteReader();
                while (dR.Read())
                {
                    if (Convert.ToString(dR["platingcheck_GPH"]) != "")
                    {
                        accumGPH = Convert.ToDouble(dR["platingcheck_GPH"]);
                        platingcheckcount = platingcheckcount + 1;
                    }
                }
                dR.Close();
                if (platingcheckcount != 0)
                {
                    avgGPH = accumGPH / platingcheckcount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Averag GPH Calc Error :" + ex, "Error");
            }
            finally
            {
                cmdGPH.Dispose();
                dataconn.Close();
            }
            
            // Scrap Count and accumulation
            OleDbCommand cmdScrap = new OleDbCommand();
            cmdScrap.CommandType = CommandType.Text;
            cmdScrap.Connection = dataconn;
            cmdScrap.CommandText = "SELECT tblLots.lot_Scrap FROM tblLots WHERE tblLots.lot_ID = " + Convert.ToInt32(this.cboLot.Text);
            try
            {
                dataconn.Open();
                OleDbDataReader dR = cmdScrap.ExecuteReader();
                dR.Read();
                if (Convert.ToString(dR["lot_Scrap"]) != "")
                {
                    totalSamples = Convert.ToInt32(dR["lot_Scrap"]) + Convert.ToInt32(this.lblSampleCount2.Text);
                }
                else
                {
                    totalSamples = Convert.ToInt32(this.lblSampleCount2.Text);
                }
                dR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select Scrap Error :" + ex, "Error");
            }
            finally
            {
                cmdScrap.Dispose();
                dataconn.Close();
            }
            
            // Update command for tblLots
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dataconn;
            cmd.CommandText = "UPDATE tblLots SET lot_EstimatedPullDateTime = #" + estimatedCompletionDateTime + "#, lot_AvgGPH = " + avgGPH + ", lot_CheckDateTime = #" + estimatedCompletionDateTime + "#, lot_Scrap = " + totalSamples + " WHERE lot_ID = " + Convert.ToInt32(this.cboLot.Text);

            try
            {
                dataconn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating Lot Record: " + ex, "Error");
            }
            finally
            {
                cmd.Dispose();
                dataconn.Close();
            }
        }

       
             
  }
}
