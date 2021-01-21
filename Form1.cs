using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace High_Speed_UART_Communication
{
    public partial class Form1 : Form
    {
        private SerialPort _serialPort;
        private bool _serialAllowToSend = true;
        private bool _serialConnected = false;
        private int _richTextBoxPreviousPosition = 0;
        private string _rxString;
        private ulong rxDataLen = 0;
        private ulong txDataLen = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1_baudrate.Text = "9600";

            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            comboBox1_COMPort.DataSource = ports;
        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            // Connect or disconnect to the COM Port
            if (_serialConnected)
            {

                _serialPort.Close();
                _serialConnected = false;
                button_Connect.Text = "Connect";

                comboBox1_COMPort.Enabled = true;
                comboBox1_baudrate.Enabled = true;

                rxDataLen = 0;
                label3_rx_data.Text = "Rx: " + rxDataLen.ToString() + " Byte";
                txDataLen = 0;
                label3_tx_data.Text = "Tx: " + txDataLen.ToString() + " Byte";

                richTextBox1.SelectionColor = Color.Green;
                richTextBox1.AppendText("Serial port " + comboBox1_COMPort.SelectedItem.ToString() + " closed\r\n");
                richTextBox1.SelectionColor = Color.Black;
            }
            else
            {
                if (comboBox1_COMPort.SelectedItem == null)
                {
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.AppendText("Please select COM port.\r\n");
                    richTextBox1.SelectionColor = Color.Black;
                    return;
                }

                if (comboBox1_baudrate.SelectedItem == null)
                {
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.AppendText("Please select baud rate.\r\n");
                    richTextBox1.SelectionColor = Color.Black;
                    return;
                }


                _serialPort = new SerialPort(comboBox1_COMPort.SelectedItem.ToString(), Int32.Parse(comboBox1_baudrate.SelectedItem.ToString()));
                _serialPort.DataReceived += MyPort_DataReceived;

                // Set the read/write timeouts
                _serialPort.ReadTimeout = 100;
                _serialPort.WriteTimeout = 100;

                try
                {
                    _serialPort.Open();

                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.AppendText("Serial port " + comboBox1_COMPort.SelectedItem.ToString() + " opened\r\n");
                    richTextBox1.SelectionColor = Color.Black;

                    button_Connect.Text = "Disconnect";
                    _serialConnected = true;

                    comboBox1_COMPort.Enabled = false;
                    comboBox1_baudrate.Enabled = false;
                }
                catch (Exception eSerial)
                {
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.AppendText(eSerial.Message + "\r\n");
                    richTextBox1.SelectionColor = Color.Black;
                }
            }

            _serialAllowToSend = false;
        }

        // Receive incoming data and write to screen
        private void MyPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            _rxString = _serialPort.ReadExisting();
            this.Invoke(new EventHandler(RTBDisplayText));
        }

        // Write data to screend
        private void RTBDisplayText(object sender, EventArgs e)
        {
            _serialAllowToSend = false;
            richTextBox1.AppendText(_rxString);
            _richTextBoxPreviousPosition = richTextBox1.SelectionStart;

            rxDataLen += (ulong)_rxString.Length;
            label3_rx_data.Text = "Rx: " + rxDataLen.ToString() + " Byte";

            // Scroll it automatically if enabled
            if (checkBox1_autoscroll.Checked == true)
                richTextBox1.ScrollToCaret();
        }

        // Send incoming data from screen to COM port
        private void RichTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Send data if COM port is opening. If com port is not available, do not write to serial port
            if (_serialConnected)
            {
                if (_serialPort.IsOpen)
                {
                    if (_serialAllowToSend)
                    {
                        int length = richTextBox1.SelectionStart - _richTextBoxPreviousPosition;
                        if ((length > 0) || (_richTextBoxPreviousPosition < richTextBox1.SelectionStart))
                        {
                            string data = richTextBox1.Text.Substring(_richTextBoxPreviousPosition, length);
                            _serialPort.Write(data);
                            txDataLen += (ulong)data.Length;
                        }
                        else
                        {
                            _serialPort.Write(new byte[] { 8 }, 0, 1);    // backspace
                            txDataLen += 1;
                        }
                        label3_tx_data.Text = "Tx: " + txDataLen.ToString() + " Byte";
                    }
                }
            }

            _richTextBoxPreviousPosition = richTextBox1.SelectionStart;
            _serialAllowToSend = true;
        }

        // Enable/Disable autoscroll
        private void CheckBox1_autoscroll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1_autoscroll.Checked == true)
                richTextBox1.ScrollToCaret();
        }

        // Update available COM ports
        private void ComboBox1_COMPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            comboBox1_COMPort.DataSource = ports;
        }

        // Clear content on richtextbox
        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            rxDataLen = 0;
            label3_rx_data.Text = "Rx: " + rxDataLen.ToString() + " Byte";
        }
    }
}
