
namespace High_Speed_UART_Communication
{
    partial class Form1
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
            this.label_COM_Port = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox1_autoscroll = new System.Windows.Forms.CheckBox();
            this.comboBox1_baudrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1_COMPort = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3_rx_data = new System.Windows.Forms.Label();
            this.label3_tx_data = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_COM_Port
            // 
            this.label_COM_Port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_COM_Port.AutoSize = true;
            this.label_COM_Port.Location = new System.Drawing.Point(6, 16);
            this.label_COM_Port.Name = "label_COM_Port";
            this.label_COM_Port.Size = new System.Drawing.Size(53, 13);
            this.label_COM_Port.TabIndex = 0;
            this.label_COM_Port.Text = "COM Port";
            // 
            // button_Connect
            // 
            this.button_Connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Connect.Location = new System.Drawing.Point(6, 117);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(87, 23);
            this.button_Connect.TabIndex = 1;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 25);
            this.richTextBox1.MaxLength = 10240000;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(630, 425);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RichTextBox1_KeyPress);
            // 
            // checkBox1_autoscroll
            // 
            this.checkBox1_autoscroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1_autoscroll.AutoSize = true;
            this.checkBox1_autoscroll.Checked = true;
            this.checkBox1_autoscroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1_autoscroll.Location = new System.Drawing.Point(659, 433);
            this.checkBox1_autoscroll.Name = "checkBox1_autoscroll";
            this.checkBox1_autoscroll.Size = new System.Drawing.Size(76, 17);
            this.checkBox1_autoscroll.TabIndex = 4;
            this.checkBox1_autoscroll.Text = "Autoscrool";
            this.checkBox1_autoscroll.UseVisualStyleBackColor = true;
            this.checkBox1_autoscroll.CheckedChanged += new System.EventHandler(this.CheckBox1_autoscroll_CheckedChanged);
            // 
            // comboBox1_baudrate
            // 
            this.comboBox1_baudrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1_baudrate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1_baudrate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1_baudrate.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1_baudrate.DropDownHeight = 158;
            this.comboBox1_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_baudrate.DropDownWidth = 70;
            this.comboBox1_baudrate.FormattingEnabled = true;
            this.comboBox1_baudrate.IntegralHeight = false;
            this.comboBox1_baudrate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "34800",
            "57600",
            "115200",
            "230400",
            "256000",
            "460800",
            "921600",
            "1000000",
            "1500000",
            "2000000",
            "3000000",
            "4000000"});
            this.comboBox1_baudrate.Location = new System.Drawing.Point(6, 76);
            this.comboBox1_baudrate.MaxDropDownItems = 10;
            this.comboBox1_baudrate.Name = "comboBox1_baudrate";
            this.comboBox1_baudrate.Size = new System.Drawing.Size(87, 21);
            this.comboBox1_baudrate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Receive/Send data";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1_COMPort);
            this.groupBox1.Controls.Add(this.comboBox1_baudrate);
            this.groupBox1.Controls.Add(this.button_Connect);
            this.groupBox1.Controls.Add(this.label_COM_Port);
            this.groupBox1.Location = new System.Drawing.Point(653, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 150);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baudrate";
            // 
            // comboBox1_COMPort
            // 
            this.comboBox1_COMPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1_COMPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_COMPort.FormattingEnabled = true;
            this.comboBox1_COMPort.Location = new System.Drawing.Point(6, 32);
            this.comboBox1_COMPort.Name = "comboBox1_COMPort";
            this.comboBox1_COMPort.Size = new System.Drawing.Size(87, 21);
            this.comboBox1_COMPort.TabIndex = 1;
            this.comboBox1_COMPort.Click += new System.EventHandler(this.ComboBox1_COMPort_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(659, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3_rx_data
            // 
            this.label3_rx_data.AutoSize = true;
            this.label3_rx_data.Location = new System.Drawing.Point(660, 355);
            this.label3_rx_data.Name = "label3_rx_data";
            this.label3_rx_data.Size = new System.Drawing.Size(56, 13);
            this.label3_rx_data.TabIndex = 9;
            this.label3_rx_data.Text = "Rx: 0 Byte";
            // 
            // label3_tx_data
            // 
            this.label3_tx_data.AutoSize = true;
            this.label3_tx_data.Location = new System.Drawing.Point(661, 336);
            this.label3_tx_data.Name = "label3_tx_data";
            this.label3_tx_data.Size = new System.Drawing.Size(55, 13);
            this.label3_tx_data.TabIndex = 10;
            this.label3_tx_data.Text = "Tx: 0 Byte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label3_tx_data);
            this.Controls.Add(this.label3_rx_data);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1_autoscroll);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "High Speed UART Communication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_COM_Port;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1_autoscroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1_COMPort;
        private System.Windows.Forms.ComboBox comboBox1_baudrate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3_rx_data;
        private System.Windows.Forms.Label label3_tx_data;
    }
}

