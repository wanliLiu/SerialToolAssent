namespace SerialToolAssent
{
    partial class SerialTools
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialTools));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SP = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxPortName = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.buttonOpenPort = new System.Windows.Forms.Button();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxRHex = new System.Windows.Forms.CheckBox();
            this.checkBoxRAutClear = new System.Windows.Forms.CheckBox();
            this.checkBoxTHex = new System.Windows.Forms.CheckBox();
            this.checkBoxTAutClear = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTimerpick = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTransmit = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonSendFile = new System.Windows.Forms.Button();
            this.buttonHandSend = new System.Windows.Forms.Button();
            this.buttonClearTrans = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelRX = new System.Windows.Forms.ToolStripStatusLabel();
            this.RxLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTX = new System.Windows.Forms.ToolStripStatusLabel();
            this.TxLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPortStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTimeDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonResetCounter = new System.Windows.Forms.Button();
            this.buttonSaveReciveData = new System.Windows.Forms.Button();
            this.timerTimeDisplay = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnClearRec = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxStop = new System.Windows.Forms.CheckBox();
            this.timerDataSend = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "波特率：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "校验位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "停止位：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "数据位：";
            // 
            // SP
            // 
            this.SP.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SP_DataReceived);
            // 
            // comboBoxPortName
            // 
            this.comboBoxPortName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPortName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxPortName.FormattingEnabled = true;
            this.comboBoxPortName.Location = new System.Drawing.Point(61, 23);
            this.comboBoxPortName.Name = "comboBoxPortName";
            this.comboBoxPortName.Size = new System.Drawing.Size(63, 20);
            this.comboBoxPortName.TabIndex = 1;
            this.comboBoxPortName.SelectedIndexChanged += new System.EventHandler(this.comboBoxPortName_SelectedIndexChanged);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxBaudRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "153600",
            "230400",
            "307200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(61, 46);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(63, 20);
            this.comboBoxBaudRate.TabIndex = 1;
            this.comboBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaudRate_SelectedIndexChanged);
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBits.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "5位",
            "6位",
            "7位",
            "8位"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(61, 71);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(63, 20);
            this.comboBoxDataBits.TabIndex = 1;
            this.comboBoxDataBits.SelectedIndexChanged += new System.EventHandler(this.comboBoxDataBits_SelectedIndexChanged);
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(61, 97);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(63, 20);
            this.comboBoxParity.TabIndex = 1;
            this.comboBoxParity.SelectedIndexChanged += new System.EventHandler(this.comboBoxParity_SelectedIndexChanged);
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(61, 123);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(63, 20);
            this.comboBoxStopBits.TabIndex = 1;
            this.comboBoxStopBits.SelectedIndexChanged += new System.EventHandler(this.comboBoxStopBits_SelectedIndexChanged);
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOpenPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenPort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonOpenPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOpenPort.Location = new System.Drawing.Point(8, 158);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(65, 22);
            this.buttonOpenPort.TabIndex = 2;
            this.buttonOpenPort.Text = "打开串口";
            this.buttonOpenPort.UseVisualStyleBackColor = true;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReceive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxReceive.Location = new System.Drawing.Point(6, 14);
            this.textBoxReceive.MaxLength = 2048;
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxReceive.Size = new System.Drawing.Size(396, 316);
            this.textBoxReceive.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonOpenPort);
            this.groupBox1.Controls.Add(this.comboBoxStopBits);
            this.groupBox1.Controls.Add(this.comboBoxParity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxDataBits);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxBaudRate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxPortName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通信端口设置";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxReceive);
            this.groupBox2.Location = new System.Drawing.Point(151, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 336);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据接收显示区";
            // 
            // checkBoxRHex
            // 
            this.checkBoxRHex.AutoSize = true;
            this.checkBoxRHex.Location = new System.Drawing.Point(2, 78);
            this.checkBoxRHex.Name = "checkBoxRHex";
            this.checkBoxRHex.Size = new System.Drawing.Size(66, 16);
            this.checkBoxRHex.TabIndex = 6;
            this.checkBoxRHex.Text = "Hex显示";
            this.checkBoxRHex.UseVisualStyleBackColor = true;
            this.checkBoxRHex.CheckedChanged += new System.EventHandler(this.checkBoxRHex_CheckedChanged);
            // 
            // checkBoxRAutClear
            // 
            this.checkBoxRAutClear.AutoSize = true;
            this.checkBoxRAutClear.Location = new System.Drawing.Point(67, 78);
            this.checkBoxRAutClear.Name = "checkBoxRAutClear";
            this.checkBoxRAutClear.Size = new System.Drawing.Size(72, 16);
            this.checkBoxRAutClear.TabIndex = 6;
            this.checkBoxRAutClear.Text = "自动清空";
            this.checkBoxRAutClear.UseVisualStyleBackColor = true;
            this.checkBoxRAutClear.CheckedChanged += new System.EventHandler(this.checkBoxRAutClear_CheckedChanged);
            // 
            // checkBoxTHex
            // 
            this.checkBoxTHex.AutoSize = true;
            this.checkBoxTHex.Location = new System.Drawing.Point(2, 20);
            this.checkBoxTHex.Name = "checkBoxTHex";
            this.checkBoxTHex.Size = new System.Drawing.Size(66, 16);
            this.checkBoxTHex.TabIndex = 6;
            this.checkBoxTHex.Text = "Hex发送";
            this.checkBoxTHex.UseVisualStyleBackColor = true;
            this.checkBoxTHex.CheckedChanged += new System.EventHandler(this.checkBoxTHex_CheckedChanged);
            // 
            // checkBoxTAutClear
            // 
            this.checkBoxTAutClear.AutoSize = true;
            this.checkBoxTAutClear.Location = new System.Drawing.Point(2, 40);
            this.checkBoxTAutClear.Name = "checkBoxTAutClear";
            this.checkBoxTAutClear.Size = new System.Drawing.Size(72, 16);
            this.checkBoxTAutClear.TabIndex = 6;
            this.checkBoxTAutClear.Text = "定时发送";
            this.checkBoxTAutClear.UseVisualStyleBackColor = true;
            this.checkBoxTAutClear.CheckedChanged += new System.EventHandler(this.checkBoxTAutClear_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "定时时间";
            // 
            // textBoxTimerpick
            // 
            this.textBoxTimerpick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTimerpick.Location = new System.Drawing.Point(59, 62);
            this.textBoxTimerpick.Name = "textBoxTimerpick";
            this.textBoxTimerpick.Size = new System.Drawing.Size(48, 21);
            this.textBoxTimerpick.TabIndex = 8;
            this.textBoxTimerpick.Text = "100";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "毫秒";
            // 
            // textBoxTransmit
            // 
            this.textBoxTransmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTransmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxTransmit.Location = new System.Drawing.Point(6, 45);
            this.textBoxTransmit.Multiline = true;
            this.textBoxTransmit.Name = "textBoxTransmit";
            this.textBoxTransmit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTransmit.Size = new System.Drawing.Size(390, 41);
            this.textBoxTransmit.TabIndex = 9;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile.Location = new System.Drawing.Point(6, 19);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(63, 21);
            this.buttonOpenFile.TabIndex = 10;
            this.buttonOpenFile.Text = "打开文件";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilePath.Location = new System.Drawing.Point(75, 20);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(254, 21);
            this.textBoxFilePath.TabIndex = 11;
            this.textBoxFilePath.Text = "Txt文件路径";
            // 
            // buttonSendFile
            // 
            this.buttonSendFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendFile.Location = new System.Drawing.Point(335, 17);
            this.buttonSendFile.Name = "buttonSendFile";
            this.buttonSendFile.Size = new System.Drawing.Size(65, 23);
            this.buttonSendFile.TabIndex = 12;
            this.buttonSendFile.Text = "发送文件";
            this.buttonSendFile.UseVisualStyleBackColor = true;
            this.buttonSendFile.Click += new System.EventHandler(this.buttonHandSend_Click);
            // 
            // buttonHandSend
            // 
            this.buttonHandSend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonHandSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHandSend.Location = new System.Drawing.Point(76, 38);
            this.buttonHandSend.Name = "buttonHandSend";
            this.buttonHandSend.Size = new System.Drawing.Size(62, 22);
            this.buttonHandSend.TabIndex = 13;
            this.buttonHandSend.Text = "手动发送";
            this.buttonHandSend.UseVisualStyleBackColor = true;
            this.buttonHandSend.Click += new System.EventHandler(this.buttonHandSend_Click);
            // 
            // buttonClearTrans
            // 
            this.buttonClearTrans.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonClearTrans.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClearTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearTrans.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonClearTrans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.buttonClearTrans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonClearTrans.Location = new System.Drawing.Point(66, 13);
            this.buttonClearTrans.Name = "buttonClearTrans";
            this.buttonClearTrans.Size = new System.Drawing.Size(79, 21);
            this.buttonClearTrans.TabIndex = 13;
            this.buttonClearTrans.Text = "清空发送区";
            this.buttonClearTrans.UseVisualStyleBackColor = false;
            this.buttonClearTrans.Click += new System.EventHandler(this.buttonClearTrans_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRX,
            this.RxLabel,
            this.toolStripStatusLabelTX,
            this.TxLabel,
            this.toolStripStatusLabelPortStatus,
            this.toolStripStatusLabelTimeDisplay});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(560, 26);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 14;
            // 
            // toolStripStatusLabelRX
            // 
            this.toolStripStatusLabelRX.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelRX.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.toolStripStatusLabelRX.Name = "toolStripStatusLabelRX";
            this.toolStripStatusLabelRX.Size = new System.Drawing.Size(29, 21);
            this.toolStripStatusLabelRX.Text = "Rx:";
            // 
            // RxLabel
            // 
            this.RxLabel.AutoSize = false;
            this.RxLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.RxLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.RxLabel.Name = "RxLabel";
            this.RxLabel.Size = new System.Drawing.Size(60, 21);
            this.RxLabel.Text = "0";
            this.RxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelTX
            // 
            this.toolStripStatusLabelTX.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelTX.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.toolStripStatusLabelTX.Name = "toolStripStatusLabelTX";
            this.toolStripStatusLabelTX.Size = new System.Drawing.Size(28, 21);
            this.toolStripStatusLabelTX.Text = "Tx:";
            // 
            // TxLabel
            // 
            this.TxLabel.AutoSize = false;
            this.TxLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TxLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.TxLabel.Name = "TxLabel";
            this.TxLabel.Size = new System.Drawing.Size(60, 21);
            this.TxLabel.Text = "0";
            this.TxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelPortStatus
            // 
            this.toolStripStatusLabelPortStatus.AutoSize = false;
            this.toolStripStatusLabelPortStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelPortStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.toolStripStatusLabelPortStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelPortStatus.Name = "toolStripStatusLabelPortStatus";
            this.toolStripStatusLabelPortStatus.Size = new System.Drawing.Size(250, 21);
            this.toolStripStatusLabelPortStatus.Text = "Status：COM Port Closed                        ";
            // 
            // toolStripStatusLabelTimeDisplay
            // 
            this.toolStripStatusLabelTimeDisplay.AutoSize = false;
            this.toolStripStatusLabelTimeDisplay.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelTimeDisplay.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.toolStripStatusLabelTimeDisplay.Name = "toolStripStatusLabelTimeDisplay";
            this.toolStripStatusLabelTimeDisplay.Size = new System.Drawing.Size(120, 21);
            this.toolStripStatusLabelTimeDisplay.Text = "时间显示      ";
            this.toolStripStatusLabelTimeDisplay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // buttonResetCounter
            // 
            this.buttonResetCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonResetCounter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonResetCounter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetCounter.Location = new System.Drawing.Point(3, 414);
            this.buttonResetCounter.Name = "buttonResetCounter";
            this.buttonResetCounter.Size = new System.Drawing.Size(79, 23);
            this.buttonResetCounter.TabIndex = 15;
            this.buttonResetCounter.Text = "复位计数器";
            this.buttonResetCounter.UseVisualStyleBackColor = false;
            this.buttonResetCounter.Click += new System.EventHandler(this.buttonResetCounter_Click);
            // 
            // buttonSaveReciveData
            // 
            this.buttonSaveReciveData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSaveReciveData.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaveReciveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveReciveData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSaveReciveData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSaveReciveData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSaveReciveData.Location = new System.Drawing.Point(2, 49);
            this.buttonSaveReciveData.Name = "buttonSaveReciveData";
            this.buttonSaveReciveData.Size = new System.Drawing.Size(78, 23);
            this.buttonSaveReciveData.TabIndex = 16;
            this.buttonSaveReciveData.Text = "保存显示数据";
            this.buttonSaveReciveData.UseVisualStyleBackColor = false;
            this.buttonSaveReciveData.Click += new System.EventHandler(this.buttonSaveReciveData_Click);
            // 
            // timerTimeDisplay
            // 
            this.timerTimeDisplay.Enabled = true;
            this.timerTimeDisplay.Tick += new System.EventHandler(this.timerTimeDisplay_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.buttonSendFile);
            this.groupBox3.Controls.Add(this.textBoxFilePath);
            this.groupBox3.Controls.Add(this.buttonOpenFile);
            this.groupBox3.Controls.Add(this.textBoxTransmit);
            this.groupBox3.Location = new System.Drawing.Point(152, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 92);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据发送区";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(177, 7);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 12);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "存在的问题";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnClearRec
            // 
            this.btnClearRec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClearRec.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClearRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearRec.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearRec.Location = new System.Drawing.Point(2, 20);
            this.btnClearRec.Name = "btnClearRec";
            this.btnClearRec.Size = new System.Drawing.Size(78, 23);
            this.btnClearRec.TabIndex = 18;
            this.btnClearRec.Text = "清空接收区";
            this.btnClearRec.UseVisualStyleBackColor = false;
            this.btnClearRec.Click += new System.EventHandler(this.btnClearRec_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonClearTrans);
            this.groupBox4.Controls.Add(this.buttonHandSend);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.checkBoxTAutClear);
            this.groupBox4.Controls.Add(this.checkBoxTHex);
            this.groupBox4.Controls.Add(this.textBoxTimerpick);
            this.groupBox4.Location = new System.Drawing.Point(3, 329);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(151, 85);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "发送设置";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxStop);
            this.groupBox5.Controls.Add(this.btnClearRec);
            this.groupBox5.Controls.Add(this.buttonSaveReciveData);
            this.groupBox5.Controls.Add(this.checkBoxRAutClear);
            this.groupBox5.Controls.Add(this.checkBoxRHex);
            this.groupBox5.Location = new System.Drawing.Point(3, 198);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(145, 125);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "接收设置";
            // 
            // checkBoxStop
            // 
            this.checkBoxStop.AutoSize = true;
            this.checkBoxStop.Location = new System.Drawing.Point(2, 100);
            this.checkBoxStop.Name = "checkBoxStop";
            this.checkBoxStop.Size = new System.Drawing.Size(96, 16);
            this.checkBoxStop.TabIndex = 19;
            this.checkBoxStop.Text = "暂停接收显示";
            this.checkBoxStop.UseVisualStyleBackColor = true;
            this.checkBoxStop.CheckedChanged += new System.EventHandler(this.checkBoxStop_CheckedChanged);
            // 
            // timerDataSend
            // 
            this.timerDataSend.Tick += new System.EventHandler(this.timerDataSend_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(92, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SerialTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 466);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonResetCounter);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(576, 504);
            this.Name = "SerialTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口调试助手 测试版本(V1.0) ----作者：刘万里，QQ:451211604,E-mail:liuwanli50@126.com";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort SP;
        private System.Windows.Forms.ComboBox comboBoxPortName;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Button buttonOpenPort;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxRHex;
        private System.Windows.Forms.CheckBox checkBoxRAutClear;
        private System.Windows.Forms.CheckBox checkBoxTHex;
        private System.Windows.Forms.CheckBox checkBoxTAutClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTimerpick;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTransmit;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonSendFile;
        private System.Windows.Forms.Button buttonHandSend;
        private System.Windows.Forms.Button buttonClearTrans;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPortStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRX;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTX;
        private System.Windows.Forms.Button buttonResetCounter;
        private System.Windows.Forms.Button buttonSaveReciveData;
        private System.Windows.Forms.Timer timerTimeDisplay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClearRec;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripStatusLabel RxLabel;
        private System.Windows.Forms.ToolStripStatusLabel TxLabel;
        private System.Windows.Forms.Timer timerDataSend;
        private System.Windows.Forms.CheckBox checkBoxStop;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimeDisplay;
        private System.Windows.Forms.Button button1;
    }
}

