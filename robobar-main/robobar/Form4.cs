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

namespace robobar
{
    
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       public bool isConnected = false;



        private void Form4_Load_1(object sender, EventArgs e)
        {

        }

        private void arduinoButton_Click(object sender, EventArgs e)
        {
            comboBox.Items.Clear();
            // Получаем список COM портов доступных в системе
            string[] portnames = SerialPort.GetPortNames(); 
            // Проверяем есть ли доступные
            if (portnames.Length == 0)
            {
                MessageBox.Show("COM PORT not found");
            }
            foreach (string portName in portnames)
            {
                //добавляем доступные COM порты в список           
                comboBox.Items.Add(portName);
                Console.WriteLine(portnames.Length);
                if (portnames[0] != null)
                {
                    comboBox.SelectedItem = portnames[0];
                }
            }
        }

        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBox.GetItemText(comboBox.SelectedItem);
            serialPort.PortName = selectedPort;
            serialPort.Open();
            connectButton.Text = "Disconnect";
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            serialPort.Close();
            connectButton.Text = "Connect";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // При закрытии программы, закрываем порт
            if (serialPort.IsOpen) serialPort.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                serialPort.Write("n1n2d1|1000 1000 1000");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(); this.Hide(); form.Closed += (s, args) => this.Close();
            form.fr4 = this;
            form.Show();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}