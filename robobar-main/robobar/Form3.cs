using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robobar
{
    public partial class Form3 : Form
    {
        public Form4 fr4set;
        public Form3()
        {
            InitializeComponent();
        }

        private void back_2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(); this.Hide(); form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fr4set.isConnected)
            {
                fr4set.serialPort.Write("n1n2d1|1000 1000 1000");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
