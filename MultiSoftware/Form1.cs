using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace MultiSoftware
{
    public partial class Form1 : Form
    {
        int PW,ch1w,ch1h,ch2w;                // spanel&chart width or height
        bool hided;                           // panel handler
        private SerialPort sensport;          // Serial decleration
       // long maxm = 100, minm = 0;            // Graph scaler
        long maxm , minm;            // Graph scaler
        string NData = "names";               // comunication sensor names command
        string StpData = "stop";              // comunication stop command
        string SData = "start";               // comunication start command
        bool first = false;                   // get names or data event
        string[] sp_data;                     // separated data
        int switcher;                         // number of chart switcher
        bool Plothandle = false;              // plot handler
        int a1, a2, a3, a4, a5, a6;           // seperated data handler (used in update chart function)

        List<string> gpdata = new List<string>();

        public Form1()
        {
            InitializeComponent();             // initialize all the components
            ch1w = chart1.Width;               // declarations of chart w.h
            ch1h = chart1.Height;              
            ch2w = chart2.Width;               
            PW = Spanel.Width;                 // spanel op ctrl
            hided = false;                     // spanel event variable
            groupBox1.Visible = false;         // setting page handler
            DisconnectButton.Enabled = false;  // button controlls
            PlotGraph.Enabled = false;        
            StartGraph.Enabled = false;
            StopGraph.Enabled = false;
            CleardataButton.Enabled = false;
            SaveScreenButton.Enabled = false;
            SaveButton.Enabled = false;
            SensorlistButton.Enabled = false;
            comboBox.Enabled = false;
            chart1.Hide();                      // hiding all charts
            chart2.Hide();
            chart3.Hide();
            chart4.Hide();
            chart5.Hide();
            chart6.Hide();
            panel4.Hide();
            Control.CheckForIllegalCrossThreadCalls = false;  // thread cross 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBoxComPort.DataSource = SerialPort.GetPortNames();     // Getting the serial port name
            ClearData();                                            // clear all data func
            comcheck();                                             // com check func
           
        }
        private void comcheck()                                                     // checks the com port 
        {
            if (cBoxComPort.Text == "")                         // if port is not available makes connect button disable
            {
                ConnectButton.Enabled = false;
            }
            else
            {
                ConnectButton.Enabled = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)         // When Closing the SW
        {
            sensport.Close();                                                       // closes the serial port connection
        }
        private void ConnectButton_Click(object sender, EventArgs e)                // connect buttton func
        {
            if (Spanel.Width >= PW)                                                 // hide the Spanel if it's not hidden already 
            {
                Spanel.Width = Spanel.Width - 230;
                hided = true;
            }
            if (cBoxBaudRate.Text == "")                                            // checks baudrate available or not
            {
                MessageBox.Show("!!!Baudrate seçimi yapınız.");
            }
            else
            {
                ConnectButton.Enabled = false;                                                 // button situations
                DisconnectButton.Enabled = true;
                PlotGraph.Enabled = true;
                SensorlistButton.Enabled = true;
                PlotGraph.Enabled = true;
                comboBox.Enabled = true;

                sensport = new SerialPort();                                                   // serial port declaration
                sensport.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);                        //gets baudrate
                sensport.PortName = cBoxComPort.Text;                                          //com portun seçildiği yer
                sensport.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);     // gets parity
                sensport.DataBits = Convert.ToInt32(cBoxDataBits.Text);                        //get databits
                sensport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text); //gets stopbits
                sensport.Handshake = Handshake.None;
                sensport.RtsEnable = true;
                sensport.DataReceived += sensport_DataReceived;                                //+= denildikten sonra 2 kere tab yap  new SerialDataReceivedEventHandler(DataReceivedHandler)
                try
                {
                    sensport.Open();        // opens serial connection
                    sensport.Write(NData);  // sends name data command
                    panel2.Show();          //panel ops
                    panel4.Show(); 
                }
                catch (Exception ex)        // if connection failed
                {
                    MessageBox.Show(ex.Message, "Connection error!");
                }
            }
        }

        private void StartGraph_Click(object sender, EventArgs e)                   // Start button func
        {
            if (0 <= Convert.ToInt32(comboBox.Text)&Convert.ToInt32(comboBox.Text)<=10000)      // plot rate should be in range
            {
                SensorlistButton.Enabled = false;               // button ops
                StopGraph.Enabled = true;
                StartGraph.Enabled = false;
                first = true;
                CleardataButton.Enabled = false;
                Plothandle = false;
                comboBox.Enabled = false;
                SaveScreenButton.Enabled = false;
                SaveButton.Enabled = false;
                PlotGraph.Enabled = false;
                if (!sensport.IsOpen)
                {
                    sensport.Open();
                }
                sensport.Write(SData);                              // send Start command
            }
            else
            {
                MessageBox.Show("Sayı 1-10000 arasında olmalıdır"); 
            }  
        }

        private void PictureBox2_Click(object sender, EventArgs e)                  // Slide menu button
        {
            SpanelTimer.Start();        //sliding panel op
        }

        private void StopGraph_Click(object sender, EventArgs e)                    // Stop command func    
        {
            StartGraph.Enabled = true;                     // button ops
            StopGraph.Enabled = false;
            SensorlistButton.Enabled = true;
            Plothandle = true;
            CleardataButton.Enabled = true;
            comboBox.Enabled = false;
            SaveScreenButton.Enabled = true;
            SaveButton.Enabled = true;
            sensport.Write(StpData);                        // send Stop command
        }

        private void SensorlistButton_Click(object sender, EventArgs e)             // Sensor list func
        {
            if (Spanel.Width >= PW)       // hide the Spanel if it's not hidden already 
            {
                Spanel.Width = Spanel.Width - 230;
                hided = true;
            }
            panel2.Show();                          // show the SL panel 
            SaveScreenButton.Enabled = false;       // button ops
            SaveButton.Enabled = false;
            comboBox.Enabled = true;
            PlotGraph.Enabled = true;
            ClearData();
        }

        private void CleardataButton_Click(object sender, EventArgs e)              // Clear data button func
        {
            maxm = Convert.ToInt32(comboBox.Text);   // resets the max range of plotting
            SaveScreenButton.Enabled = false;        // button ops
            SaveButton.Enabled = false;
            comboBox.Enabled = true;
            ClearData();                             // clear func
        }

        private void SaveScreenButton_Click(object sender, EventArgs e)             // Screenshot func
        {
            saveFileDialog1.Title = "Please select the path for screenshot";            // dialog declarations
            saveFileDialog1.Filter = "BMP Dosyaları|*.bmp";                             // filter dec
            saveFileDialog1.FileName = "FileName";                                      // file name dec

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)                
            {
                using (var bmp = new Bitmap(panel5.Width, panel5.Height))               //screenshot ops
                {
                    panel5.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save(saveFileDialog1.FileName + ".bmp");                        // save as
                    MessageBox.Show("Saved!!!!");
                }
            }
            else
            {
                MessageBox.Show("You should select the path");
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)                   // Help button func
        {
            helpUserControl1.Show();
            if (hided)
            {
                Spanel.Width = Spanel.Width + 230;   //show
                if (Spanel.Width >= PW)
                {
                    SpanelTimer.Stop();
                    hided = false;
                    this.Refresh();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)       // closing SW
        {
            if (first==true)                           // if connection still on send Stop command
            {
                sensport.Write(StpData);
            }
            Plothandle = true;
            if (LogScreen.Text != string.Empty)        // if there is data ask for save
            {
                DialogResult result1 = MessageBox.Show("Do you want to save the data before exit?", "Save Data", MessageBoxButtons.YesNo);

                if (result1 == DialogResult.Yes)
                {
                    SaveButton.PerformClick();
                }
            }
          
        }

        private void CheckPortButton_Click(object sender, EventArgs e)              // chom check butt    
        {
            cBoxComPort.DataSource = SerialPort.GetPortNames();      // Getting the serial port name
            comcheck();                                              // checks
        }


        void sensport_DataReceived(object sender, SerialDataReceivedEventArgs e)    // receive data via serial   
        {
            SerialPort sp = (SerialPort)sender;
            if (first == false)                                     // first get name op
            {
                string Comdata = sp.ReadLine();                     //  name data

                LogScreen.Text += Comdata;                          // write to log screen
                LogScreen.SelectionStart = LogScreen.TextLength;
                LogScreen.ScrollToCaret();

                string[] sensor_name = Comdata.Split(",".ToCharArray());   // seperation of the sensor names 
                listBox1.DataSource = sensor_name;                         // putting them in to listbox 


                listBox1.ClearSelected();                            
            }
            else
            {
                //string dataLine = sp.ReadLine();
                //sp_data = dataLine.Split(",".ToCharArray());

                string dataLine = sp.ReadExisting();
                sp_data = dataLine.Split(",".ToCharArray());
                //gpdata.Add(sp_data[0]);
                //minm = dataLine.Lenght;
                maxm = minm + 100;

                if (Plothandle == false)
                {
                    if (sensport.IsOpen)
                    {
                        try
                        {
                             this.Invoke((MethodInvoker)delegate { UpdateChart(); });
                             LogScreen.Text += dataLine;  
                             LogScreen.SelectionStart = LogScreen.TextLength;
                             LogScreen.ScrollToCaret();

                             minm = LogScreen.Lines.Count(); 

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Sth goes wrong");
                        }
                        //Thread.Sleep(10);            you get sloower the data
                    }
                    else
                    {
                        MessageBox.Show("Sensport is not open");
                    }
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)                   // save button func
        {
            saveFileDialog2.Title = "Please select the path for data.txt";          // dialog declarations
            saveFileDialog2.Filter = "Text Files|*.txt";                            // file type
            saveFileDialog2.FileName = "FileName";                                  // file name
            SaveButton.Enabled = false;                                             // button op
            if (LogScreen.Text != string.Empty)                                     // if there is data 
            {
                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writte = File.AppendText(saveFileDialog2.FileName.ToString());     // write data to file
                    writte.Write(LogScreen.Text);                                                   // write screen to file
                    writte.Close();                                                                 // close file
                    MessageBox.Show("Saved!!!!");
                }
                else
                {
                    MessageBox.Show("You should select the path");
                }
            }
            else
            {
                MessageBox.Show("Empty Log!!");
            }

        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)      // range op
        {
               maxm= minm + Convert.ToInt32(comboBox.Text);                                     // read the range 
        }

        private void DisconnectButton_Click(object sender, EventArgs e)             // disconnect button func
        {
            ConnectButton.Enabled = true;           // button situations
            DisconnectButton.Enabled = false;
            StartGraph.Enabled = false;
            PlotGraph.Enabled = false;
            StopGraph.Enabled = false;
            SaveButton.Enabled = false;
            SaveScreenButton.Enabled = false;
            SensorlistButton.Enabled = false;
            CleardataButton.Enabled = false;
            
            ClearData();                            // clear data func
            chart1.Hide();                          // hide all the charts
            chart2.Hide();
            chart3.Hide();
            chart4.Hide();
            chart5.Hide();
            chart6.Hide();
            first = false;
            try
            {
                sensport.Write(StpData);             // send stop command 
                sensport.Close();                    // close the connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Mesajı");
            }
        }
            
        private void PlotGraph_Click(object sender, EventArgs e)                    // Plot graph button func
        {
            maxm = Convert.ToInt32(comboBox.Text);              // resets max range
            StartGraph.Enabled = true;                          //start button disable
            comboBox.Enabled = false;                           
            panel2.Hide();                                      // hide panels
            panel5.Show();
            helpUserControl1.Hide();

            if (chart1.Width > ch1w)                            // chart scale ops
            {
                chart1.Width = chart1.Width / 2;

                if (chart1.Height > ch1h)
                {
                    chart1.Height = chart1.Height / 2;
                }
            }
            if (chart2.Width > ch2w)
            {
                chart2.Width = chart2.Width / 2;
            }
            if (listBox1.SelectedIndices.Count == 1)            // if 1 sensor selected op
            {
                chart1.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[0]);        // gives chart names
                WindowState = FormWindowState.Normal;           // widow state
                chart1.Width = chart1.Width * 2;
                chart1.Height = chart1.Height * 2;
                a1 = listBox1.SelectedIndices[0];               //selected sensor number
                switcher = 1;                                   // trigger the switch
                chart1.Show();                                  // show only 1 chart
                chart2.Hide();
                chart3.Hide();
                chart4.Hide();
                chart5.Hide();
                chart6.Hide();


            }
            else if (listBox1.SelectedIndices.Count == 2)      // if 2 sensor selected op
            {
                chart1.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[0]);
                chart2.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[1]);
                WindowState = FormWindowState.Normal;
                chart1.Width = chart1.Width * 2;
                chart2.Width = chart2.Width * 2;
                a1 = listBox1.SelectedIndices[0];
                a2 = listBox1.SelectedIndices[1];
                switcher = 2;
                chart1.Show();
                chart2.Show();
                chart3.Hide();
                chart4.Hide();
                chart5.Hide();
                chart6.Hide();
            }
            else if (listBox1.SelectedIndices.Count == 3)        // if 3 sensor selected op
            {
                chart1.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[0]);
                chart2.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[1]);
                chart3.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[2]);
                WindowState = FormWindowState.Normal;
                a1 = listBox1.SelectedIndices[0];
                a2 = listBox1.SelectedIndices[1];
                a3 = listBox1.SelectedIndices[2];
                switcher = 3;
                chart1.Show();
                chart2.Show();
                chart3.Show();
                chart4.Hide();
                chart5.Hide();
                chart6.Hide();
            }
            else if (listBox1.SelectedIndices.Count == 4)      // if 4 sensor selected op
            {
                chart1.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[0]);
                chart2.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[1]);
                chart3.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[2]);
                chart4.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[3]);
                WindowState = FormWindowState.Normal;
                a1 = listBox1.SelectedIndices[0];
                a2 = listBox1.SelectedIndices[1];
                a3 = listBox1.SelectedIndices[2];
                a4 = listBox1.SelectedIndices[3];
                switcher = 4;
                chart1.Show();
                chart2.Show();
                chart3.Show();
                chart4.Show();
                chart5.Hide();
                chart6.Hide();
            }
            else if (listBox1.SelectedIndices.Count == 5)   // if 5 sensor selected op
            {
                chart1.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[0]);
                chart2.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[1]);
                chart3.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[2]);
                chart4.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[3]);
                chart5.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[4]);
                WindowState = FormWindowState.Maximized;
                a1 = listBox1.SelectedIndices[0];
                a2 = listBox1.SelectedIndices[1];
                a3 = listBox1.SelectedIndices[2];
                a4 = listBox1.SelectedIndices[3];
                a5 = listBox1.SelectedIndices[4];
                switcher = 5;
                chart1.Show();
                chart2.Show();
                chart3.Show();
                chart4.Show();
                chart5.Show();
                chart6.Hide();
            }
            else if (listBox1.SelectedIndices.Count == 6)     // if 6 sensor selected op
            {
                chart1.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[0]);
                chart2.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[1]);
                chart3.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[2]);
                chart4.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[3]);
                chart5.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[4]);
                chart6.Series["Data1"].LegendText = Convert.ToString(listBox1.SelectedItems[5]);
                WindowState = FormWindowState.Maximized;
                a1 = listBox1.SelectedIndices[0];
                a2 = listBox1.SelectedIndices[1];
                a3 = listBox1.SelectedIndices[2];
                a4 = listBox1.SelectedIndices[3];
                a5 = listBox1.SelectedIndices[4];
                a6 = listBox1.SelectedIndices[5];
                switcher = 6;
                chart1.Show();
                chart2.Show();
                chart3.Show();
                chart4.Show();
                chart5.Show();
                chart6.Show();
            }
            else
            {
                MessageBox.Show("You didn't select data correctly");
            }
        }

        private void UpdateChart()                                           // Update the chart op
        {
            this.chart1.ChartAreas[0].AxisX.Minimum = minm;             // chart decs
            this.chart1.ChartAreas[0].AxisX.Maximum = maxm;
            this.chart1.ChartAreas[0].AxisX.ScaleView.Zoom(minm, maxm);
            this.chart2.ChartAreas[0].AxisX.Minimum = minm;
            this.chart2.ChartAreas[0].AxisX.Maximum = maxm;
            this.chart2.ChartAreas[0].AxisX.ScaleView.Zoom(minm, maxm);
            this.chart3.ChartAreas[0].AxisX.Minimum = minm;
            this.chart3.ChartAreas[0].AxisX.Maximum = maxm;
            this.chart3.ChartAreas[0].AxisX.ScaleView.Zoom(minm, maxm);
            this.chart4.ChartAreas[0].AxisX.Minimum = minm;
            this.chart4.ChartAreas[0].AxisX.Maximum = maxm;
            this.chart4.ChartAreas[0].AxisX.ScaleView.Zoom(minm, maxm);
            this.chart5.ChartAreas[0].AxisX.Minimum = minm;
            this.chart5.ChartAreas[0].AxisX.Maximum = maxm;
            this.chart5.ChartAreas[0].AxisX.ScaleView.Zoom(minm, maxm);
            this.chart6.ChartAreas[0].AxisX.Minimum = minm;
            this.chart6.ChartAreas[0].AxisX.Maximum = maxm;
            this.chart6.ChartAreas[0].AxisX.ScaleView.Zoom(minm, maxm);


            switch (switcher)           // according to number of charts
            {
                case 1:

                    this.chart1.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a1]);          // plot the seperated data in range                                                                                            //    chart1.Update();                                                                              //  maxm++;    // sonradan deistirdim denemek icin
                  //  chart1.Update();
                    break;
                case 2:
                    this.chart1.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a1]);
                    this.chart2.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a2]);
                    chart1.Update();
                    chart2.Update();
                    break;
                case 3:
                    this.chart1.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a1]);
                    this.chart2.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a2]);
                    this.chart3.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a3]);
                    chart1.Update();
                    chart2.Update();
                    chart3.Update();
                    break;
                case 4:
                    this.chart1.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a1]);
                    this.chart2.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a2]);
                    this.chart3.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a3]);
                    this.chart4.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a4]);
                    chart1.Update();
                    chart2.Update();
                    chart3.Update();
                    chart4.Update();
                    break;
                case 5:
                    this.chart1.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a1]);
                    this.chart2.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a2]);
                    this.chart3.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a3]);
                    this.chart4.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a4]);
                    this.chart5.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a5]);
                    chart1.Update();
                    chart2.Update();
                    chart3.Update();
                    chart4.Update();
                    chart5.Update();
                    break;
                case 6:
                    this.chart1.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a1]);
                    this.chart2.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a2]);
                    this.chart3.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a3]);
                    this.chart4.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a4]);
                    this.chart5.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a5]);
                    this.chart6.Series["Data1"].Points.AddXY((minm + maxm), sp_data[a6]);
                    chart1.Update();
                    chart2.Update();
                    chart3.Update();
                    chart4.Update();
                    chart5.Update();
                    chart6.Update();
                    break;

            }

        }
        private void ClearData()                                             // Clear data func
        {
            LogScreen.Clear();                              //clear log
            maxm = Convert.ToInt32(comboBox.Text);          //reset range max
            minm = 0;                                       //reset range min
            foreach (var series in chart1.Series)           // clear all charts
            {
                series.Points.Clear();
            }
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chart3.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chart4.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chart5.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chart6.Series)
            {
                series.Points.Clear();
            }
        }
        private void SettingsButton_Click(object sender, EventArgs e)        // Save Log data butt
        {
            if (Spanel.Width >= PW)       // hide the Spanel if it's not hidden already 
            {
                Spanel.Width = Spanel.Width - 230;
                hided = true;
            }
            groupBox1.Visible = true; // setting page handler
            panel2.Visible = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)                 //slide panel movements
        {
            if (hided)
            {
                Spanel.Width = Spanel.Width + 230;   //show
                if (Spanel.Width >= PW)
                {
                    SpanelTimer.Stop();
                    hided = false;
                    this.Refresh();
                }
            }
            else
            {
                Spanel.Width = Spanel.Width - 230;    //hide
                if (Spanel.Width >= 0)
                {
                    SpanelTimer.Stop();
                    hided = true;
                    this.Refresh();
                }
            }
        }

    }
}
