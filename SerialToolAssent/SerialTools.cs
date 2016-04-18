using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Drawing.Drawing2D;

namespace SerialToolAssent
{
     public partial class SerialTools : Form
    {
        SerialClass dataDeal = new SerialClass(); //实例数据处理中心
        private delegate void DataReceiveHandle(SerialPort Sp);
        bool AutClder = false;
        bool StartStop = false,Runsing = true;
        StreamReader txtFile;
        public SerialTools()
        {
            InitializeComponent();
            //每次启动自动获取可用端口名
            comboBoxPortName.DataSource = SerialPort.GetPortNames();
            //开始默认的选项
            comboBoxPortName.SelectedIndex = 0;
            comboBoxBaudRate.SelectedIndex = 7;
            comboBoxParity.SelectedIndex = 0;
            comboBoxDataBits.SelectedIndex = 3;
            comboBoxStopBits.SelectedIndex = 1;
        }

        private void timerTimeDisplay_Tick(object sender, EventArgs e)
        {
            //状态栏的时间显示
            toolStripStatusLabelTimeDisplay.Text =  DateTime.Now.ToLongTimeString();
            Runsing = true;
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (SP.IsOpen)
            {
                g.FillEllipse(Brushes.Red, groupBox1.Size.Width - 50, groupBox1.Size.Height - 30, 20, 20);  
            }
            else
            {
                g.FillEllipse(Brushes.Black, groupBox1.Size.Width - 50, groupBox1.Size.Height - 30, 20, 20);  
            }

        }

        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            Graphics g = groupBox1.CreateGraphics();
            if (SP.IsOpen == false) //没有打开串口
            {
                try
                {
                    SP.Open();
                    //MessageBox.Show("串口打开成功");
                    g.FillEllipse(Brushes.Red, groupBox1.Size.Width - 50, groupBox1.Size.Height - 30, 20, 20);
                    buttonOpenPort.Text = "关闭串口";
                    toolStripStatusLabelPortStatus.Text = string.Format("Status：{0} Opend,{1},{2},{3},{4}",SP.PortName,SP.BaudRate.ToString(),SP.DataBits.ToString(),SP.Parity,SP.StopBits);
                    comboBoxBaudRate.Enabled = comboBoxPortName.Enabled = comboBoxDataBits.Enabled = comboBoxParity.Enabled = comboBoxPortName.Enabled = comboBoxStopBits.Enabled = false;
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message,"错误提示！");
                }
                
            }
            else
            {
                SP.Close();
                g.FillEllipse(Brushes.Black, groupBox1.Size.Width - 50, groupBox1.Size.Height - 30, 20, 20);
                buttonOpenPort.Text = "打开串口";
                toolStripStatusLabelPortStatus.Text = "Status：COM Port Closed                        ";
               comboBoxBaudRate.Enabled = comboBoxPortName.Enabled = comboBoxDataBits.Enabled = comboBoxParity.Enabled = comboBoxPortName.Enabled = comboBoxStopBits.Enabled = true ;
            }

        }
        #region SerialPostSet
        /*串口设置参数改变*/
        private void comboBoxPortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SP.PortName = comboBoxPortName.SelectedItem.ToString();
        }
        private void comboBoxBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SP.BaudRate = int.Parse(comboBoxBaudRate.SelectedItem.ToString());
        }
        private void comboBoxDataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxDataBits.SelectedItem.ToString())
            {
                case "5位": SP.DataBits = 5; break;
                case "6位": SP.DataBits = 6; break;
                case "7位": SP.DataBits = 7; break;
                case "8位": SP.DataBits = 8; break;
                default: break;
            }
        }
        private void comboBoxParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxParity.SelectedItem.ToString())
            {
                case "None":  SP.Parity = Parity.None;  break;
                case "Odd":   SP.Parity = Parity.Odd;   break;
                case "Even":  SP.Parity = Parity.Even;  break;
                case "Mark":  SP.Parity = Parity.Mark;  break;
                case "Space": SP.Parity = Parity.Space; break;
                default: break;
            }
            
        }
        private void comboBoxStopBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxStopBits.SelectedItem.ToString())
                {
                    case "None": SP.StopBits = StopBits.None; break;
                    case "One": SP.StopBits = StopBits.One; break;
                    case "Two": SP.StopBits = StopBits.Two; break;
                    case "OnePointFive": SP.StopBits = StopBits.OnePointFive; break;
                    default:
                        break;
                }
        }
        #endregion

        private void btnClearRec_Click(object sender, EventArgs e)
        {
            textBoxReceive.Clear();
        }

        private void buttonSaveReciveData_Click(object sender, EventArgs e)
        {
            if (StartStop || Runsing == true)
            {
                Runsing =true;
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "文本文件(*.txt;*.log)|*.txt;*.log";
                saveFile.Title = "保存接收的数据";
                // FileStream sw;
                StreamWriter ss;
                if (textBoxReceive.Text != "")
                {
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fil = new FileInfo(saveFile.FileName);
                        if (fil.Exists)
                        {
                            fil.Delete();
                        }
                        //sw = fil.Create();
                        ss = fil.CreateText();
                        ss.Write(textBoxReceive.Text);
                        ss.Close();
                        MessageBox.Show("保存数据成功！");
                    }
                }
                else
                {
                    MessageBox.Show("数据为空时，不能保存！");
                }               
            }
            else
            {
                MessageBox.Show("请暂停接收显示，然后保存数据！");
            }

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "文本文件(*.txt;*.log)|*.txt;*.log";
            openFile.Title = "打开文件";
            openFile.Multiselect = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFile.FileName;
                txtFile = new StreamReader(openFile.FileName,System.Text.Encoding.GetEncoding("GBK"));
                textBoxTransmit.Text = txtFile.ReadToEnd();
                txtFile.Close();
                if (textBoxTransmit.Text == "")
                {
                    MessageBox.Show("打开的文件内容为空！");
                    textBoxFilePath.Text = "";
                }

            }
            
        }

        private void buttonClearTrans_Click(object sender, EventArgs e)
        {
            textBoxTransmit.Clear();
            textBoxFilePath.Text = "TXT文本路径";
        }

        private void buttonResetCounter_Click(object sender, EventArgs e)
        {
            RxLabel.Text = TxLabel.Text = "0";
        }

        private void buttonHandSend_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)//每次点击发送按钮时确保串口已经打开
            {
                SendDataFunction();//若串口打开就发送数据
            }
            else
            {
                MessageBox.Show("你还没有打开串口！\n   请打开串口!!!");
            }
        }
        #region updateCunter
        //跟新数据计数器
        private void UpdateCounterR(int data)
        {
            long RxDataLenth = int.Parse(RxLabel.Text.Trim());
            RxDataLenth += data;
            RxLabel.Text = RxDataLenth.ToString();
        }
        private void UpdateCounterT()
        {
            long TxDataLenth = int.Parse(TxLabel.Text.Trim());
            TxDataLenth += textBoxTransmit.Text.Length;
            TxLabel.Text = TxDataLenth.ToString();
        }
        #endregion
        //发送数据函数
        private void SendDataFunction()
        {
            if (checkBoxTHex.Checked == false)//默认以字符串的方式发送
            {
                if (textBoxTransmit.Text != "" && textBoxTransmit.Text != null)
                {
                    byte[] Data = dataDeal.StringToBytes(textBoxTransmit.Text);
                    SP.Write(Data, 0, Data.Length);
                    UpdateCounterT();//更新数据计数
                }
                else //如没有输入数据，给出提示信息！
                {
                    if (timerDataSend.Enabled == true)
                    {
                        timerDataSend.Enabled = false;
                        checkBoxTAutClear.Checked = false;
                    }
                    MessageBox.Show("你没有输入你要发送的数据，请输入！！", "提示");
                }
            }
            else
            {
                if (checkBoxTHex.Checked)//以十六进制发送
                {
                    if (textBoxTransmit.Text != "" && textBoxTransmit.Text != null)
                    {
                        string Componetn = textBoxTransmit.Text.Replace(" ", "");//把空格字符去掉
                        long DataLenth = Componetn.Length / 2;//说明输入的数据个数只能是偶数
                        byte[] DataArray = new byte[DataLenth];
                        try
                        {
                            for (int i = 0; i < DataLenth; i++)//分割字符串
                            {
                                DataArray[i] = Convert.ToByte(Componetn.Substring(i * 2, 2),16);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("输入格式错误！");
                        }
                        //好了，然后发送数据
                        SP.Write(DataArray, 0, DataArray.Length);
                        UpdateCounterT();//更新数据计数
                    }
                    else //如没有输入数据，给出提示信息！
                    {
                        if (timerDataSend.Enabled == true)
                        {
                            timerDataSend.Enabled = false;
                            checkBoxTAutClear.Checked = false;
                        }
                        MessageBox.Show("你没有输入你要发送的数据，请输入！！", "提示");
                    }
                }
            } 
        }

        private void checkBoxTAutClear_CheckedChanged(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                if (checkBoxTAutClear.Checked)
                {
                    if (textBoxTimerpick.Text != "")
                    {
                        timerDataSend.Interval = int.Parse(textBoxTimerpick.Text.Trim());
                        timerDataSend.Enabled = true;
                        textBoxTimerpick.Enabled = false;
                    }
                }
                else
                {
                    timerDataSend.Enabled = false;
                    textBoxTimerpick.Enabled = true;
                }               
            }
            else
            {
                checkBoxTAutClear.Checked = false;
               
            }
 
        }

        private void timerDataSend_Tick(object sender, EventArgs e)
        {
            SendDataFunction();
        }

        private void checkBoxTHex_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTHex.Checked == true)//十六进制
            {
                if (textBoxTransmit.Text != null && textBoxTransmit.Text != "")
                {
                    byte[] change = dataDeal.StringToBytes(textBoxTransmit.Text);
                    string Disp = change[0].ToString("X2");
                    for (int i = 1; i < change.Length; i++)
                    {
                        Disp += " " + change[i].ToString("X2");
                    }
                    textBoxTransmit.Text = Disp;                    
                }

            }
            else if(checkBoxTHex.Checked == false)
            {
                string array = dataDeal.StringToBytesTab(textBoxTransmit.Text);
                textBoxTransmit.Clear();
                textBoxTransmit.Text = array;
            }
        }

        private void SP_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            DataReceiveHandle DataRecec = new DataReceiveHandle(HandData);
            BeginInvoke(DataRecec, SP);
        }
         //接收数据处理中心
        string str = "";
        private void HandData(SerialPort sp)
        {
            int RecDataLent = sp.BytesToRead;
            byte[] array = new byte[RecDataLent];
            sp.Read(array, 0, array.Length);            
            Runsing = false;
            if (!StartStop)
            {
                if (checkBoxRHex.Checked == false)//字符显示
                {
                    str +=(dataDeal.BytesToString(array));
                }
                else
                {
                    if (checkBoxRHex.Checked)
                    {
                        foreach (byte arr in array)
                        {
                            if (arr.ToString("X2").Length > 1)
                            {
                                str += (arr.ToString("X2") + " ");
                            }
                            else
                            {
                                str += (arr.ToString("X2"));
                            }
                        }
                    }
                }
                if (AutClder && textBoxReceive.Text.Length > textBoxReceive.MaxLength)
                {
                    textBoxReceive.Clear();
                }
                UpdateCounterR(RecDataLent);
                textBoxReceive.Text += str;
                str = "";
            }

        }

        private void checkBoxRAutClear_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRAutClear.Checked)
            {
                AutClder = true;
            }
            else
            {
                AutClder = false;
            }
        }

        private void checkBoxRHex_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRHex.Checked == true)//十六进制
            {
                if (textBoxReceive.Text != null && textBoxReceive.Text != "")
                {
                    byte[] change = dataDeal.StringToBytes(textBoxReceive.Text);
                    string Disp = change[0].ToString("X2");
                    for (int i = 1; i < change.Length; i++)
                    {
                        Disp += " " + change[i].ToString("X2");
                    }
                    textBoxReceive.Text = Disp;
                }

            }
            else if (checkBoxRHex.Checked == false)
            {
                String array = dataDeal.StringToBytesTab(textBoxReceive.Text);
                textBoxReceive.Clear();
                textBoxReceive.Text = array;
            }
        }

        private void checkBoxStop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStop.Checked)
            {
                StartStop = true;
            }
            else
            {
                StartStop = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("1.数据的处理能力不行，只要数据过于庞大，程序就会死机\n出现这样的问题在于，接收数据显示到TextBox中的方式有问题\n2.读取上次配置文件的问题\n4.扩展发送按钮没有做");
        }
    }
}

