namespace MultiSoftware
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend22 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea23 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend23 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea24 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend24 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SpanelTimer = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.CheckPortButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.PlotGraph = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartGraph = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.StopGraph = new System.Windows.Forms.Button();
            this.CleardataButton = new System.Windows.Forms.Button();
            this.SaveScreenButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SensorlistButton = new System.Windows.Forms.Button();
            this.Spanel = new System.Windows.Forms.Panel();
            this.HelpButton = new System.Windows.Forms.Button();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart6 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LogScreen = new System.Windows.Forms.RichTextBox();
            this.helpUserControl1 = new MultiSoftware.HelpUserControl();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Spanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpanelTimer
            // 
            this.SpanelTimer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.CheckPortButton);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.PlotGraph);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.comboBox);
            this.panel2.Controls.Add(this.cBoxComPort);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 726);
            this.panel2.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 39;
            this.label7.Text = "Plot Range";
            // 
            // CheckPortButton
            // 
            this.CheckPortButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckPortButton.FlatAppearance.BorderSize = 0;
            this.CheckPortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckPortButton.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.CheckPortButton.ForeColor = System.Drawing.Color.White;
            this.CheckPortButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckPortButton.Location = new System.Drawing.Point(40, 31);
            this.CheckPortButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckPortButton.Name = "CheckPortButton";
            this.CheckPortButton.Size = new System.Drawing.Size(119, 29);
            this.CheckPortButton.TabIndex = 34;
            this.CheckPortButton.Text = "Check Port";
            this.CheckPortButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckPortButton.UseVisualStyleBackColor = false;
            this.CheckPortButton.Click += new System.EventHandler(this.CheckPortButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Location = new System.Drawing.Point(6, 532);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(161, 181);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop Bits";
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(71, 153);
            this.cBoxParityBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(72, 21);
            this.cBoxParityBits.TabIndex = 7;
            this.cBoxParityBits.Text = "None";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(71, 104);
            this.cBoxStopBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(72, 21);
            this.cBoxStopBits.TabIndex = 6;
            this.cBoxStopBits.Text = "One";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(71, 60);
            this.cBoxDataBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(72, 21);
            this.cBoxDataBits.TabIndex = 5;
            this.cBoxDataBits.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(71, 20);
            this.cBoxBaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(72, 21);
            this.cBoxBaudRate.TabIndex = 2;
            this.cBoxBaudRate.Text = "9600";
            // 
            // PlotGraph
            // 
            this.PlotGraph.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlotGraph.FlatAppearance.BorderSize = 0;
            this.PlotGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlotGraph.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.PlotGraph.ForeColor = System.Drawing.Color.White;
            this.PlotGraph.Image = ((System.Drawing.Image)(resources.GetObject("PlotGraph.Image")));
            this.PlotGraph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlotGraph.Location = new System.Drawing.Point(6, 471);
            this.PlotGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlotGraph.Name = "PlotGraph";
            this.PlotGraph.Size = new System.Drawing.Size(161, 46);
            this.PlotGraph.TabIndex = 27;
            this.PlotGraph.Text = "    Select Sensor";
            this.PlotGraph.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlotGraph.UseVisualStyleBackColor = false;
            this.PlotGraph.Click += new System.EventHandler(this.PlotGraph_Click);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(15, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "SENSOR LIST";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(6, 182);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(159, 285);
            this.listBox1.TabIndex = 12;
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.Silver;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(75, 102);
            this.comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(90, 21);
            this.comboBox.TabIndex = 38;
            this.comboBox.Text = "100";
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.Location = new System.Drawing.Point(69, 3);
            this.cBoxComPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(90, 21);
            this.cBoxComPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com Port";
            // 
            // StartGraph
            // 
            this.StartGraph.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartGraph.FlatAppearance.BorderSize = 0;
            this.StartGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGraph.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.StartGraph.ForeColor = System.Drawing.Color.White;
            this.StartGraph.Image = ((System.Drawing.Image)(resources.GetObject("StartGraph.Image")));
            this.StartGraph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartGraph.Location = new System.Drawing.Point(170, -1);
            this.StartGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartGraph.Name = "StartGraph";
            this.StartGraph.Size = new System.Drawing.Size(178, 46);
            this.StartGraph.TabIndex = 29;
            this.StartGraph.Text = "Start Graph";
            this.StartGraph.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartGraph.UseVisualStyleBackColor = false;
            this.StartGraph.Click += new System.EventHandler(this.StartGraph_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1060, 41);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.StopGraph);
            this.panel4.Controls.Add(this.StartGraph);
            this.panel4.Controls.Add(this.CleardataButton);
            this.panel4.Location = new System.Drawing.Point(377, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(683, 42);
            this.panel4.TabIndex = 33;
            // 
            // StopGraph
            // 
            this.StopGraph.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StopGraph.FlatAppearance.BorderSize = 0;
            this.StopGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopGraph.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.StopGraph.ForeColor = System.Drawing.Color.White;
            this.StopGraph.Image = ((System.Drawing.Image)(resources.GetObject("StopGraph.Image")));
            this.StopGraph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StopGraph.Location = new System.Drawing.Point(354, -3);
            this.StopGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopGraph.Name = "StopGraph";
            this.StopGraph.Size = new System.Drawing.Size(148, 48);
            this.StopGraph.TabIndex = 33;
            this.StopGraph.Text = "Stop Graph";
            this.StopGraph.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StopGraph.UseVisualStyleBackColor = false;
            this.StopGraph.Click += new System.EventHandler(this.StopGraph_Click);
            // 
            // CleardataButton
            // 
            this.CleardataButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CleardataButton.FlatAppearance.BorderSize = 0;
            this.CleardataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleardataButton.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.CleardataButton.ForeColor = System.Drawing.Color.White;
            this.CleardataButton.Image = ((System.Drawing.Image)(resources.GetObject("CleardataButton.Image")));
            this.CleardataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CleardataButton.Location = new System.Drawing.Point(508, -2);
            this.CleardataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CleardataButton.Name = "CleardataButton";
            this.CleardataButton.Size = new System.Drawing.Size(142, 47);
            this.CleardataButton.TabIndex = 31;
            this.CleardataButton.Text = "Clear Data";
            this.CleardataButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CleardataButton.UseVisualStyleBackColor = false;
            this.CleardataButton.Click += new System.EventHandler(this.CleardataButton_Click);
            // 
            // SaveScreenButton
            // 
            this.SaveScreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.SaveScreenButton.FlatAppearance.BorderSize = 0;
            this.SaveScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveScreenButton.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.SaveScreenButton.ForeColor = System.Drawing.Color.White;
            this.SaveScreenButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveScreenButton.Image")));
            this.SaveScreenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveScreenButton.Location = new System.Drawing.Point(0, 341);
            this.SaveScreenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveScreenButton.Name = "SaveScreenButton";
            this.SaveScreenButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SaveScreenButton.Size = new System.Drawing.Size(218, 48);
            this.SaveScreenButton.TabIndex = 32;
            this.SaveScreenButton.Text = "Screen Shot";
            this.SaveScreenButton.UseVisualStyleBackColor = false;
            this.SaveScreenButton.Click += new System.EventHandler(this.SaveScreenButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ConnectButton.FlatAppearance.BorderSize = 0;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.ForeColor = System.Drawing.Color.White;
            this.ConnectButton.Image = ((System.Drawing.Image)(resources.GetObject("ConnectButton.Image")));
            this.ConnectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConnectButton.Location = new System.Drawing.Point(-13, 97);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(234, 48);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "     Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location = new System.Drawing.Point(3, 393);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(218, 56);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save Log";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.FlatAppearance.BorderSize = 0;
            this.DisconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisconnectButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectButton.ForeColor = System.Drawing.Color.White;
            this.DisconnectButton.Image = ((System.Drawing.Image)(resources.GetObject("DisconnectButton.Image")));
            this.DisconnectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DisconnectButton.Location = new System.Drawing.Point(-4, 173);
            this.DisconnectButton.Margin = new System.Windows.Forms.Padding(4);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(222, 43);
            this.DisconnectButton.TabIndex = 2;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(0, 638);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(211, 56);
            this.SettingsButton.TabIndex = 28;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // SensorlistButton
            // 
            this.SensorlistButton.FlatAppearance.BorderSize = 0;
            this.SensorlistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SensorlistButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorlistButton.ForeColor = System.Drawing.Color.White;
            this.SensorlistButton.Image = ((System.Drawing.Image)(resources.GetObject("SensorlistButton.Image")));
            this.SensorlistButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SensorlistButton.Location = new System.Drawing.Point(0, 239);
            this.SensorlistButton.Margin = new System.Windows.Forms.Padding(4);
            this.SensorlistButton.Name = "SensorlistButton";
            this.SensorlistButton.Size = new System.Drawing.Size(210, 43);
            this.SensorlistButton.TabIndex = 29;
            this.SensorlistButton.Text = "Sensor List";
            this.SensorlistButton.UseVisualStyleBackColor = true;
            this.SensorlistButton.Click += new System.EventHandler(this.SensorlistButton_Click);
            // 
            // Spanel
            // 
            this.Spanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Spanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.Spanel.Controls.Add(this.HelpButton);
            this.Spanel.Controls.Add(this.SensorlistButton);
            this.Spanel.Controls.Add(this.SettingsButton);
            this.Spanel.Controls.Add(this.pictureBox2);
            this.Spanel.Controls.Add(this.SaveScreenButton);
            this.Spanel.Controls.Add(this.DisconnectButton);
            this.Spanel.Controls.Add(this.SaveButton);
            this.Spanel.Controls.Add(this.ConnectButton);
            this.Spanel.Location = new System.Drawing.Point(0, -4);
            this.Spanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Spanel.Name = "Spanel";
            this.Spanel.Size = new System.Drawing.Size(211, 853);
            this.Spanel.TabIndex = 25;
            // 
            // HelpButton
            // 
            this.HelpButton.FlatAppearance.BorderSize = 0;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.HelpButton.ForeColor = System.Drawing.Color.White;
            this.HelpButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpButton.Image")));
            this.HelpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpButton.Location = new System.Drawing.Point(0, 604);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(211, 46);
            this.HelpButton.TabIndex = 34;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // chart4
            // 
            chartArea19.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            this.chart4.Legends.Add(legend19);
            this.chart4.Location = new System.Drawing.Point(501, 327);
            this.chart4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart4.Name = "chart4";
            this.chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series19.BorderWidth = 2;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Legend = "Legend1";
            series19.Name = "Data1";
            this.chart4.Series.Add(series19);
            this.chart4.Size = new System.Drawing.Size(495, 314);
            this.chart4.TabIndex = 37;
            this.chart4.Text = "chart4";
            // 
            // chart1
            // 
            chartArea20.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.chart1.Legends.Add(legend20);
            this.chart1.Location = new System.Drawing.Point(0, 3);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series20.BorderWidth = 2;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Legend = "Legend1";
            series20.Name = "Data1";
            this.chart1.Series.Add(series20);
            this.chart1.Size = new System.Drawing.Size(495, 314);
            this.chart1.TabIndex = 34;
            this.chart1.Text = "chart1";
            // 
            // chart5
            // 
            chartArea21.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea21);
            legend21.Name = "Legend1";
            this.chart5.Legends.Add(legend21);
            this.chart5.Location = new System.Drawing.Point(1002, 3);
            this.chart5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart5.Name = "chart5";
            this.chart5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series21.BorderWidth = 2;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Legend = "Legend1";
            series21.Name = "Data1";
            this.chart5.Series.Add(series21);
            this.chart5.Size = new System.Drawing.Size(495, 314);
            this.chart5.TabIndex = 38;
            this.chart5.Text = "chart5";
            // 
            // chart2
            // 
            chartArea22.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea22);
            legend22.Name = "Legend1";
            this.chart2.Legends.Add(legend22);
            this.chart2.Location = new System.Drawing.Point(0, 327);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series22.BorderWidth = 2;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Legend = "Legend1";
            series22.Name = "Data1";
            this.chart2.Series.Add(series22);
            this.chart2.Size = new System.Drawing.Size(495, 314);
            this.chart2.TabIndex = 35;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea23.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea23);
            legend23.Name = "Legend1";
            this.chart3.Legends.Add(legend23);
            this.chart3.Location = new System.Drawing.Point(501, 3);
            this.chart3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart3.Name = "chart3";
            series23.BorderWidth = 2;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Legend = "Legend1";
            series23.Name = "Data1";
            this.chart3.Series.Add(series23);
            this.chart3.Size = new System.Drawing.Size(495, 314);
            this.chart3.TabIndex = 36;
            this.chart3.Text = "chart3";
            // 
            // chart6
            // 
            chartArea24.Name = "ChartArea1";
            this.chart6.ChartAreas.Add(chartArea24);
            legend24.Name = "Legend1";
            this.chart6.Legends.Add(legend24);
            this.chart6.Location = new System.Drawing.Point(1002, 327);
            this.chart6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart6.Name = "chart6";
            this.chart6.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series24.BorderWidth = 2;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Legend = "Legend1";
            series24.Name = "Data1";
            this.chart6.Series.Add(series24);
            this.chart6.Size = new System.Drawing.Size(495, 314);
            this.chart6.TabIndex = 39;
            this.chart6.Text = "chart6";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.LogScreen);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.helpUserControl1);
            this.panel5.Controls.Add(this.chart6);
            this.panel5.Controls.Add(this.chart3);
            this.panel5.Controls.Add(this.chart2);
            this.panel5.Controls.Add(this.chart5);
            this.panel5.Controls.Add(this.chart1);
            this.panel5.Controls.Add(this.chart4);
            this.panel5.Location = new System.Drawing.Point(46, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1014, 726);
            this.panel5.TabIndex = 37;
            // 
            // LogScreen
            // 
            this.LogScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogScreen.Location = new System.Drawing.Point(526, 639);
            this.LogScreen.Name = "LogScreen";
            this.LogScreen.Size = new System.Drawing.Size(470, 94);
            this.LogScreen.TabIndex = 40;
            this.LogScreen.Text = "";
            // 
            // helpUserControl1
            // 
            this.helpUserControl1.BackColor = System.Drawing.Color.White;
            this.helpUserControl1.Location = new System.Drawing.Point(171, 2);
            this.helpUserControl1.Name = "helpUserControl1";
            this.helpUserControl1.Size = new System.Drawing.Size(1015, 789);
            this.helpUserControl1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 767);
            this.Controls.Add(this.Spanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Software";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Spanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer SpanelTimer;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button PlotGraph;
        private System.Windows.Forms.Button StartGraph;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CleardataButton;
        private System.Windows.Forms.Button SaveScreenButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button StopGraph;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button SensorlistButton;
        private System.Windows.Forms.Panel Spanel;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxComPort;
        public System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart6;
        private HelpUserControl helpUserControl1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox LogScreen;
        private System.Windows.Forms.Button CheckPortButton;
        private System.Windows.Forms.Label label7;
    }
}

