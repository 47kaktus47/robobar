
namespace robobar
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.arduinoButton = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.turnOnButton = new System.Windows.Forms.Button();
            this.turnOffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arduinoButton
            // 
            this.arduinoButton.Location = new System.Drawing.Point(81, 35);
            this.arduinoButton.Name = "arduinoButton";
            this.arduinoButton.Size = new System.Drawing.Size(121, 23);
            this.arduinoButton.TabIndex = 0;
            this.arduinoButton.Text = "Get COM-port";
            this.arduinoButton.UseVisualStyleBackColor = true;
            this.arduinoButton.Click += new System.EventHandler(this.arduinoButton_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(81, 64);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 23);
            this.comboBox.TabIndex = 4;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(81, 91);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(121, 23);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // turnOnButton
            // 
            this.turnOnButton.Location = new System.Drawing.Point(104, 178);
            this.turnOnButton.Name = "turnOnButton";
            this.turnOnButton.Size = new System.Drawing.Size(75, 23);
            this.turnOnButton.TabIndex = 6;
            this.turnOnButton.Text = "On";
            this.turnOnButton.UseVisualStyleBackColor = true;
            this.turnOnButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // turnOffButton
            // 
            this.turnOffButton.Location = new System.Drawing.Point(244, 192);
            this.turnOffButton.Name = "turnOffButton";
            this.turnOffButton.Size = new System.Drawing.Size(75, 23);
            this.turnOffButton.TabIndex = 7;
            this.turnOffButton.Text = "Off";
            this.turnOffButton.UseVisualStyleBackColor = true;
            this.turnOffButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(378, 304);
            this.Controls.Add(this.turnOffButton);
            this.Controls.Add(this.turnOnButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.arduinoButton);
            this.Name = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button arduinoButton;
        public System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button turnOnButton;
        private System.Windows.Forms.Button turnOffButton;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
    }
}