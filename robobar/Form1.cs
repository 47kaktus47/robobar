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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chose_1.Click += chose_1_Click;
        }
            Form2 go = new Form2(); 
        
        private void chose_1_Click(object sender, EventArgs e)
        {
        }

        private void make_1_Click(object sender, EventArgs e)
        {
            this.Hide();
            go.ShowDialog();
            this.Show();

        }

        private void exit_1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setings_1_Click(object sender, EventArgs e)
        {

        }
    }
}
